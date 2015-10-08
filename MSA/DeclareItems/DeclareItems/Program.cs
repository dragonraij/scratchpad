using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            sbyte first = -115;
            sbyte second = 97;
            ushort third = 52130;
            int fourth = 4825932;
            short fifth = -10000;
            short sixth = 20000;
            byte seven = 224;
            uint eight = 970700000;
            sbyte nine = 112;
            sbyte ten = -44;
            int elev = -1000000;
            long twelv = 123456789123456789;
            float thir = 5f;
            double four = 34.242423222;
            decimal fif = 3045.3898790907868768767864432432223475m;

            Console.WriteLine("Min Max of {0} {1} {2}", fif.GetType(), decimal.MinValue, decimal.MaxValue);

            //difference of floats
            float a = 0.23313476f;
            float b = 0.23313475f;
            Console.WriteLine(Math.Abs(a - b) < 0.000001);

            //literal value numbers
            int hexy = 0x100;
            Console.WriteLine("hexy of 100 is:" + hexy);

            //print a unicode
            Console.WriteLine("\u0048");

            //using bools
            bool isMale = true;

            //string cats
            string hello = "Hello";
            string world = "World";

            object join1 = hello + " " + world;
            Console.WriteLine(join1);

            //object to string

            string join2 = (string) join1;

            //using quotations in strings
            string quot = "The \"use\" of quotations can cause problems";

            //literal heart
            string heart = @"
     o   o
    o  o   o
     o   o
       o

";
            Console.WriteLine(heart);
            Console.ReadKey();
        }
    }
}
