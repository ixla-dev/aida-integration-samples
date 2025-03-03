using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;
using Sharprompt;

namespace Aida.Samples.PcScGatewayApiUsageDemo
{
    internal class PcScSample
    {
        private readonly IntegrationApi _api;
        private Dictionary<string, SCardReader> Readers { get; set; }
        public PcScSample(IntegrationApi api)
        {
            _api = api;
        }

        public async Task Run()
        {
            await _api.EstablishContextAsync(new SCardEstablishContextParamsDto(SCardScope.User));
            Readers = (await _api.GetReadersAsync()).ToDictionary(r => r.ReaderName, r => r);

            var reader = Prompt.Select("Select a reader",
                Readers.Values,
                textSelector: sCardReader => $"{sCardReader.ReaderName} [{sCardReader.ReaderState.CurrentState.ToString()}]");

            var selectedShareMode = Prompt.Select("Select share mode", new[]
            {
                SCardShare.Shared,
                SCardShare.Exclusive
            });

            var protocol = Prompt.Select("Preferred protocol", new[]
            {
                SCardProtocol.T0,
                SCardProtocol.T1,
                SCardProtocol.Any
            });

            var result = await _api.SmartCardConnectAsync(reader.Index, new SCardConnectParamsDto
            {
                PreferredProtocol = protocol,
                Share = selectedShareMode
            });

            if (result.Success)
            {
                reader = await _api.GetReaderAsync(reader.Index);
                Readers[reader.ReaderName] = reader;

                var atr = await _api.GetSmartCardAtrAsync(reader.Index);
                var mf = await _api.TransmitAsync(0, new byte[] { 0x00, 0xa4, 0x04, 0x00, 0x00 });
                var cpLcData = await _api.TransmitAsync(0, new byte[] { 0x00, 0xca, 0x9f, 0x7f, 0x00 });
                var separator = new string('-', 54);

                Console.WriteLine(@$"
ATR
{separator}
{FormatByteArray(atr)}

Select MF
{separator}
{FormatByteArray(mf)}

CPLC Data 
{separator}
{FormatByteArray(cpLcData)}

");
            }
            else
            {
                Console.WriteLine($"SmartCard connection failed: {result.ErrorCode}");
            }
        }


        string FormatByteArray(byte[] data)
        {
            var sb = new StringBuilder();
            for (int byteIndex = 0; byteIndex < data.Length; byteIndex++)
            {
                if (byteIndex % 16 == 0)
                    sb.Append($"0x{byteIndex:x4} ");
                sb.Append($"{data[byteIndex]:x2} ");
                if ((byteIndex + 1) % 16 == 0)
                {
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
    }
}