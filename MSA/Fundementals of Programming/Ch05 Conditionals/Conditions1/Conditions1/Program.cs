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



            // 4.Sort 3 numbers in descending order. Use nested if statements.
            if (a < b)
            {
                if (b<c)
                {

                }
                else
                {
                    if (a<c)
                    {
                        temp = b;
                        b = c;
                        c = temp;
                    }
                    else
                    {
                        temp = a;
                        a = c;
                        c = b;
                        b = temp;

                    }
                }
            }
            // revisit
            
            Console.WriteLine("The three numbers in descending order: {0} {1} {2}", c,b,a);



            //. 5.Just use a switch statement to check for first five digits.
            switch (a)
            {
                case 0: Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                default:
                    Console.WriteLine("Something bigger than four"+a);
                    break;
            }
            Console.ReadKey();

        }
    }
}
