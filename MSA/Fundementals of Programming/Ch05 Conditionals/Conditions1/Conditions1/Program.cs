using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions1
{
    class Program
    {
        static void Main(string[] args)
        {
            //   1.Write an if-statement that takes two integer variables and exchanges
            //  their values if the first one is greater than the second one.
            int a = 2, b = 4, c=-3, temp = 0;
            if (a>b)
            {
                temp = a;
                a = b;
                b = a;
            }


            //2. Write a program that shows the sign (+ or -) of the product of three real
            //numbers, without calculating it.Use a sequence of if operators.

            if (a<0)
            {
                temp++;
            }

            if (b < 0)
            {
                temp++;
            }

            if (c < 0)
            {
                temp++;
            }

            //check if the number of negatives is odd or even
            if (temp%2==0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }



            //3. Write a program that finds the biggest of three integers, using nested
            //if statements.3.Write a program that finds the biggest of three integers, using nested
            //if statements.
            if (a>b)
            {
                if (a>c)
                {
                    temp = a;
                }
                else
                {
                    temp = c;
                }
            }
            else
            {
                if (b>c)
                {
                    temp = b;
                }
                else
                {
                    temp = c;
                }
            }

            Console.WriteLine("Largest number is {0}",temp);
                       Console.ReadKey();

        }
    }
}
