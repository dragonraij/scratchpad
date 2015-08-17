using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display program title to user
            Console.WriteLine("Currency convesionator");
            Console.WriteLine("Enter Currency code");

            // Save user currency input
            string currency = Console.ReadLine();

            // calls the getExchange  method and passes currency
            getExchange(currency);

            //Prevents the app from closing
            Console.ReadLine();

                

        }

        //getcurrenc method. makes use of the async method as it is using HTTPClient to use fixr.io API
        static async void getExchange(string currency)
        {
            //Display message to know that the program is doing something
            Console.WriteLine("Loading exchange Rates ...");

            //Using try catch on the input to check for unsual inputs
            try
            {

                // Initializing HTTPClient.
                HttpClient client = new HttpClient();

                // Create a new currency object
                Currency_Object.RootObject rootObject;

                //Call API and assign json object to string
                string x = await client.GetStringAsync(new Uri("http://api.fixer.io/latest?symbols=NZD"));

                // bind the returned object to rootobject
                rootObject = JsonConvert.DeserializeObject<Currency_Object.RootObject>(x);
                Console.WriteLine(rootObject);
                Console.WriteLine(rootObject.rates);

                // Display the exchange rate information
                // Console.WriteLine("Exchange rate for " + rootObject.rates.currency + " against EURO's");
                // Console.WriteLine("One Euro = "+ rootObject.rates + " "+rootObject.rates.currency+"'s" );



            }
            //in case of errors
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to exit");
        }
    }
}
