using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Weather2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency app - enter Country Code (eg NZD):");

            string baseRate = Console.ReadLine();

            getCurrency(baseRate);

            // Prevent app from closing
            Console.ReadKey();
        }

            static async void getCurrency(string BaseRate) {
            Console.WriteLine("Loading currency data ... ");

            try
            {
                HttpClient client = new HttpClient();

                Currency.RootObject rootObject = JsonConvert.DeserializeObject<Currency.RootObject>(await client.GetStringAsync(new Uri("http://api.fixer.io/latest?base="+BaseRate)));

                Console.WriteLine("Base Rate: \t\t" + rootObject.@base)
                    ;
                Console.WriteLine("Exchange Rate for USD: \t\t" + rootObject.rates.AUD);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.WriteLine("Press any key to exit");

        }
    }
}
