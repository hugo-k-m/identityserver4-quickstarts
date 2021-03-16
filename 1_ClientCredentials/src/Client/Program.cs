using System;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;

namespace Client
{
    class Program
    {
        private static async Task Main()
        {
            // discover endpoints from metadata
            var client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:5001");

            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
                return;
            }
        }
    }
}
