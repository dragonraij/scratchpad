using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to my gangster as weather app!!");
            Console.WriteLine("Which city would you liek to find the weather for?");

            //Reads whatever the user typess into console and assignes it to string city
            string city = Console.ReadLine();

            //Calls the method getweather and passes it the string "city"
            getWeather(city);

            //This line preventes the app from closing
            Console.ReadKey();
        }

        //Getweather method uses async
        static async void getWeather(string city) {
            // Let the user know something is happening
            Console.WriteLine("Loading Weather Data ...");
            Console.WriteLine(city);

            //Use try catch fore errors
            try
            {
                //Initializing HTTPClient.
                HttpClient client = new HttpClient();

                //Creating a new Weather Object to bind the results from our APAI call
                Weather_Object.RootObject rootObject;

                //Call the weather aPI and apply to x
                string x = await client.GetStringAsync(new Uri("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&APPID=440e3d0ee33a977c5e2fff6bc12448ee"));

                // We are now binding the returned data assigned to rootobject
                rootObject = JsonConvert.DeserializeObject<Weather_Object.RootObject>(x);

                // Printing the results to console for the users to see
                Console.WriteLine(rootObject.name + "\t\t" + rootObject.main.temp + "C");
                Console.WriteLine("Wind Speed: \t\t" + rootObject.wind.speed + "m/s");
                Console.WriteLine("Pressure: \t\t" + rootObject.main.pressure + "hPa");
                Console.WriteLine("Humidity: \t\t" + rootObject.main.humidity + "%");
                Console.WriteLine("\t" + rootObject.weather[0].description);
            }

            //Catch statement
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to exit");
        }
    }
}
