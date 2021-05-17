using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestConnection
{
    class Program
    {
        static HttpClient g_httpClient = new HttpClient();
            
        static async Task Main(string[] args)
        {
            try
            {
                if (args.Length == 1)
                {
                    var result = await g_httpClient.GetStringAsync(args[0]);
                    Console.WriteLine("Success!");
                    Console.WriteLine(result);
                }
                else { Console.WriteLine("Error: please pass http or https argument 'TestConnection https://jsandersrocks.com'"); }

            }
            catch (Exception ex) {
                Console.WriteLine("Failed to connect: {0}", ex.Message);
            }


        }
    }
}
