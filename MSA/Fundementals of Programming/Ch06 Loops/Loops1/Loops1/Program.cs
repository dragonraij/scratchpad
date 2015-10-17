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



            //2. Write a program that prints on the console the numbers from 1 to N,
            //which are not divisible by 3 and 7 simultaneously.The number N
            //should be read from the standard input.

            Console.WriteLine("I print up to n excluding numbers divisble by 3 and 7 simultaneously");
            Console.WriteLine("Enter number =>");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i < a; i++)
            {
                if (!(i%3==0 && i%7==0))
                {
                    Console.Write(i+" ");
                }
            }
                       Console.ReadKey();
        }
    }
}
