using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await GetData();
        }
        public static async Task GetData()
        {
            try
            {
                string uri = $"https://rest.entitysport.com/v2/matches/?status=2&token=ec471071441bb2ac538a0ff901abd249&per_page=10&&paged=1";
                Console.WriteLine(uri);
                var responseBody = await client.GetStringAsync(uri);
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message {0}", e.Message);
            }
        }
    }
}
