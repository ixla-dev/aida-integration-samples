using System.Threading.Tasks;
using Aida.Sdk.Mini.Api;

namespace Aida.Samples.PcScGatewayApiUsageDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var api = new IntegrationApi(args[0]);
            await new PcScSample(api).Run();
        }
    }
}