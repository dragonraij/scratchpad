using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squareroot
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("{0} {1}", "The root of 12345 is",  Math.Round(Math.Sqrt(12345), 2));
            Console.ReadKey();
        }
    }
}
