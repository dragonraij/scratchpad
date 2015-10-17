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
            int a, largest = 0, smallest = 999999;
            bool valid = true;


            //1. Write a program that prints on the console the numbers from 1 to N.
            // The number N should be read from the standard input.


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

            for (int i = 1; i <= a; i++)
            {
                if (!(i%3==0 && i%7==0))
                {
                    Console.Write(i+" ");
                }
            }



            // 3. Write a program that reads from the console a series of integers and
            // prints the smallest and largest of them.

            Console.WriteLine("Type a series of numbers to find the largest and the smallest of them");

            do
            {
                valid = int.TryParse(Console.ReadLine(), out a);
                if (!valid)
                {
                    break;
                }
                if (a>largest)
                {
                    largest = a;

                }

                if (a<smallest)
                {
                    smallest = a;
                }
            } while (valid);

            Console.WriteLine("Smallest Number is {0} Largest Number is {1}", smallest, largest);
                                   Console.ReadKey();
        }
    }
}
