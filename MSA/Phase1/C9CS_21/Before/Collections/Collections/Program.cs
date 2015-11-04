using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "oldsmobile";
            car1.Model = "cutlas supreme";

            Car car2 = new Car();
            car2.Make = "geo";
            car2.Model = "prism";

            //book b1 = new book();
            //b1.author = "robert tabor";
            //b1.title = "microsoft .net xml web services";
            //b1.isbn = "0-000-00000-0";


            /*
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            */

            Dictionary<string, Car> myDict = new Dictionary<string, Car>();
            myDict.Add(car1.Make, car1);
            myDict.Add(car2.Make, car2);
Console.WriteLine(myDict["geo"].Model);
 
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }


    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}
