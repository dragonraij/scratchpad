using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World");
            Console.ReadLine();
            int x;
            int y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            
       
            string myFirstName;
            myFirstName = "Raj";
            */
            //            var myFirstName = "Raj";

            //Console.WriteLine(myFirstName);

            //int x = 7;
            //string y = "Raj";
            //string myString = x.ToString() + y;

            //Console.WriteLine(myString);
            //Console.ReadLine();
            //int mySecondTry = x + int.Parse(y);
            //Console.WriteLine("Type something and press Enter key.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed " + userValue);
            //Console.ReadLine();

            //Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");
            //string userValue = Console.ReadLine();
            ////if (userValue == "1")
            //     Console.WriteLine("You won a new car!");
            //else if (userValue == "2")
            //     Console.WriteLine("You won a new boat!");
            //else if (userValue == "3")
            //      Console.WriteLine("You won a new cat!");
            //else
            //       Console.WriteLine("Sorry, we did not understand. You lose!");

            //string message = (userValue == "1")? "boat : "strand of lint;
            //Console.WriteLine("You won a {0}", message);

            //for (int i= 0; i < 10; i++)
            //{
            //    Console.WriteLine(i.ToString());

            //    }
            //    if (i == 7)
            //    {
            //        Console.WriteLine("Found seven");
            //        break;
            //    }
            //}

            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            //int[] numbers = new int[] {4, 8, 15, 32 };

            //string[] names = new string[] { "alf", "Bob", "carl", "Dave" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(numbers[i].ToString());

            //}

            //string zig = "You can get what you want out of life";
            //char[] charArray = zig.ToCharArray();
            //Array.Reverse(charArray);

            //foreach (char zigChar in charArray)
            //    Console.Write(zigChar);

            //Console.ReadLine();
            //string myValue = superSecretFo("sunshine");
            //Console.WriteLine(myValue);
            //Console.ReadLine();

            //**
            //READWRITE TEXT FILES
            //**

            //StreamReader myReader = new StreamReader("Values.txt");
            //string line = "";

            //while (line != null)
            //{
            //    line = myReader.ReadLine();
            //    if (line != null)
            //        Console.WriteLine(line);
            //}

            //myReader.Close();
            //Console.ReadLine();

            //**
            //Working with strings
            //**

            // string myString = "Go to \"your\" \n c:\\ drive";

            // string myString = string.Format("Make: {0} (Model: {1})", "BMW", "Bonzai");

            //string myString = string.Format("{0:C}", 123.45); // c= currency p = percent n = number also use for currency format

            //StringBuilder myString = new StringBuilder();

            //for (int i = 0; i < 100; i++)
            //{
            //    myString.Append("--");
            //    myString.Append(i);

            //}

            //   string myString = "Hello my name is ";

            //myString = myString.Substring(3,9);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");

            //Console.WriteLine(myString);


            //**
            //Working with date/time
            //**

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.AddDays(3).ToShortDateString());
            Console.WriteLine(myValue.Month);

            DateTime mybirth = new DateTime(1969,3,3);
            TimeSpan myAge = DateTime.Now.Subtract(mybirth);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();

            //
            // Working with classes
            //

            Car myNewCar = new Car();
            myNewCar.Make = "oldsmobile";
            myNewCar.Model = "Cutlass Supereme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            Console.WriteLine("{0} - {1} - {2}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Color);

            Console.ReadLine();
        }

        private static string superSecretFo()
        {
            // some cool suff here
            return "Hello World!";
        }

        private static string superSecretFo(string name)
        {
            return String.Format("Hello, {0}!", name);
        }

        
        
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

    }
}
