// See https://aka.ms/new-console-template for more information

using System.Collections.Immutable;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddCommandLine(args)
    .Build();

args = args.Select(a => a.Trim()).ToArray();

if (args.Contains("--help") || args.Contains("-h"))
{
    PrintUsage();
    return;
}

var ipAddress       = configuration.GetValue<string>("IpAddress");
var cardCount       = configuration.GetValue<int>("CardCount");
var readerInterface = configuration.GetValue<string>("InterfaceType")?.ToLower();
var basePath        = $"http://{ipAddress}:5000";
var apiConfig       = new Configuration { BasePath = basePath };
var healthCheckApi  = new HealthCheckApi(apiConfig);
var pcsc            = new PCSCGatewayApi(apiConfig);
var transport       = new TransportApi(apiConfig);

if (string.IsNullOrEmpty(ipAddress))
{
    LogError("Missing required parameter IpAddress");
    PrintUsage();
    return;
}

if (cardCount < 1)
{
    cardCount = 100;
}

if (readerInterface is null)
{
    LogWarning("Reader interface not specified. Using default 'contactless'");
    readerInterface = "contactless";
}

if (readerInterface != "contact" && readerInterface != "contactless")
{
    LogError("Invalid reader interface type. Valid values are 'contact' or 'contactless' (without quotes)");
    return;
}

try
{
    LogInformation($"Trying to connect to machine: {ipAddress}");
    await healthCheckApi.CheckAsync();
    LogInformation("Connection established");
}
catch (Exception e) when (e is HttpRequestException or ApiException)
{
    LogError("Connection failed. Make sure the provided IpAddress is correct and AIDA is running on the machine");
    return;
}

LogInformation("Resetting transport");
try
{
    await transport.ResetAsync();
}
catch (ApiException)
{
    LogError("Transport reset failed");
    return;
}


var encoderPosition = readerInterface == "contact" ? "00_encodercontact" : "00_encodercontactless";

for (var i = 1; i <= cardCount; i++)
{
    __feedCard:
    try
    {
        await transport.FeedAsync("00_feeder", encoderPosition);
    }
    catch (Exception)
    {
        var state   = await transport.GetTransportStateAsync();
        var feeders = state.Feeders;
        if (feeders.All(f => f.Status is FeederStatus.FeederEmpty))
        {
            LogWarning($"[Card:{i:000}] Feeder Empty. Put some cards in the input feeder and write C (continue) or Q (quit) to exit.");
            while (true)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.C: goto __feedCard;
                    case ConsoleKey.Q: goto __exit;
                }
            }
        }

        while (true)
        {
            LogError("Failed to load card. Do you want to reset the transport and try again? (Y/n)");
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                case ConsoleKey.Y:
                    try
                    {
                        await transport.ResetAsync();
                        goto __feedCard;
                    }
                    catch (Exception)
                    {
                        LogError("Transport reset failed. Make sure there are no cards stuck in the machine and try again.");
                        return;
                    }

                    break;
                case ConsoleKey.N:
                    return;
            }
        }
    }

    await pcsc.EstablishContextAsync(new SCardEstablishContextParamsDto(SCardScope.User));
    var readers = await pcsc.GetReadersAsync();

    var selectedReaderInterface = readerInterface == "contact" ? ReaderInterfaceType.Contact : ReaderInterfaceType.Contactless;
    var reader  = readers.FirstOrDefault(r => r.ReaderInterfaceType == selectedReaderInterface);

    if (reader is null)
    {
        LogError($"[ERR] Could not find any encoder with the selected reader interface '{selectedReaderInterface}'");
        return;
    }

    var result = await pcsc.SmartCardConnectAsync(
        reader.Index, new SCardConnectParamsDto
        {
            PreferredProtocol = SCardProtocol.Any,
            Share = SCardShare.Direct
        }
    );

    if (result.Success)
    {
        var atr = await pcsc.GetSmartCardAtrAsync(reader.Index);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        var byteString = string.Join(" ", atr.Select(b => b.ToString("X2")));
        Console.WriteLine($"[Card:{i:###}] ATR = {byteString}");
        Console.ResetColor();
    }
    else
    {
        LogError($"[Card:{i:###}] SmartCard connection failed. ErrorCode = {result.ErrorCode}");
    }

    await transport.MoveAsync(encoderPosition, "00_exit");
}

__exit:
return;

void LogWarning(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("[WRN] " + message);
    Console.ResetColor();
}

void LogError(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("[ERR] " + message);
    Console.ResetColor();
}

void LogInformation(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("[INF] " + message);
    Console.ResetColor();
}


void PrintUsage()
{
    Console.WriteLine(
        """
        AIDA PCSC Test. 

        This is a simple tool that loads cards in the encoder position and tries to retrieve the ATR form the smart-cards. 

        Usage: 

        .\pcsc-test.exe --IpAddress=[MACHINE_IP_ADDRESS] --CardCount=[NUMBER_OF_CARDS_TO_TEST] --InterfaceType=[contact/contactless]

        Parameters: 
        
          IpAddress:
            The IP address of the machine 
          
          CardCount:
            The number of cards the test will run on 
            
          InterfaceType:
            Specifies which reader interface should be used during the test
            
            Accepted values: contact, contactless
            
        HELP:
          Use the following command to display this message:
          
          .\pcsc-test.exe --help

        EXAMPLE: 
        
          Read the ATR 10 consecutive cards, on machine 192.168.3.103 using the contactless interface: 
          
          .\pcsc-test.exe --IpAddress=192.168.3.103 --CardCount=10 --InterfaceType=contactless
        """
    );
}