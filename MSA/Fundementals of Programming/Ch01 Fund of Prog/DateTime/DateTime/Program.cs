using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} : {1}", "The current time is", DateTime.Now.ToShortTimeString());
            Console.WriteLine("{0} : {1}", "Todays date is", DateTime.Now.ToLongDateString());
            Console.ReadKey();
        }
    }
}
