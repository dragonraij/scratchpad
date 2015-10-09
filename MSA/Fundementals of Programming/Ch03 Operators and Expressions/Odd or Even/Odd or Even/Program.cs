using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare varialbes
            int num = 30;


            if (num%2==0)
            {
                Console.WriteLine("it is even");
            }
            else
            {
                Console.WriteLine("it is odd isnt it?");
            }

            Console.ReadKey();
        }
    }
}
