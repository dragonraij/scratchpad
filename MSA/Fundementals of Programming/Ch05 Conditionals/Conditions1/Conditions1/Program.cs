﻿using System;
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
            switch (b)
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
                    Console.WriteLine("I counnt only till four");
                    break;
            }


            //Write a program that, depending on the user’s choice, inputs int, double
            // or string variable. If the variable is int or double, the program
            // increases it by 1.If the variable is a string, the program appends "*" at
            // the end.Print the result at the console. Use switch statement.
            Console.WriteLine("Please select a variable type:");
            Console.WriteLine("1=int 2=double 3=string");
            bool checkin = int.TryParse(Console.ReadLine(), out b);
            if (!checkin)
            {
                Console.WriteLine("No number was entered !");
            }
            else
            {
                switch (b)
                {
                    case 1:
                        Console.WriteLine("Enter an integer =>");
                        c =int.Parse(Console.ReadLine())+1;
                        Console.WriteLine("{0} was entered", c);
                        break;
                    case 2:
                        Console.WriteLine("Enter a double =>");
                        double dd = double.Parse(Console.ReadLine()) + 1D;
                        Console.WriteLine("{0} was entered", dd);
                        break;
                    case 3:
                        Console.WriteLine("Enter a string =>");
                        string ss = Console.ReadLine() +"*";
                        
                        Console.WriteLine("{0} was entered", ss);
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }

            }



            //10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
            //- If the score is between 1 and 3, the program multiplies it by 10.
            //- If the score is between 4 and 6, the program multiplies it by 100.
            //- If the score is between 7 and 9, the program multiplies it by 1000.
            //- If the score is 0 or more than 9, the program prints an error message.

            Console.WriteLine("Enter a number between 1-9 to find your bonus points");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                case 3: Console.WriteLine("Bonus points =>{0}", a*10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Bonus points =>{0}", a * 100);
                    break;

                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Bonus points =>{0}", a * 1000);
                    break;
                default:
                    Console.WriteLine("The number is outside the range");
                    break;
            }

            Console.ReadKey();



        }
    }
}
