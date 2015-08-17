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
            Console.WriteLine("Weather app - enter City:");

            string city = Console.ReadLine();

            getWeather(city);

            // Prevent app from closing
            Console.ReadKey();
        }

            static async void getWeather(string city) {
            Console.WriteLine("Loading weather data ... ");

            try
            {
                HttpClient client = new HttpClient();

                Weather_Object.RootObject rootObject = JsonConvert.DeserializeObject<Weather_Object.RootObject>(await client.GetStringAsync(new Uri("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&APPID=440e3d0ee33a977c5e2fff6bc12448ee")));

                Console.WriteLine("Current City is : "+rootObject.name);
                Console.WriteLine("Temperate : \t"+ rootObject.main.temp+"C");
                Console.WriteLine("Wind Speed : \t" + rootObject.wind.speed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.WriteLine("Press any key to exit");

        }
    }
}
