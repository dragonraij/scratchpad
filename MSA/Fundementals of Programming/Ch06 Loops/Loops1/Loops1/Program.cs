using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables


            //1. Write a program that prints on the console the numbers from 1 to N.
            // The number N should be read from the standard input.

            int a = 0;
            Console.WriteLine("Count up to what?");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine("");


            Console.ReadKey();
        }
    }
}
