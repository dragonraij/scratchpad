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



            // 4.Write a program that prints all possible cards from a standard deck
            // of cards, without jokers (there are 52 cards: 4 suits of 13 cards).

            //define variables
            string suit="", card="";
            Console.WriteLine("The cards in a deck are:");
            //loop for time for suits
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0: suit = "hearts";
                        break;
                    case 1: suit = "clubs";
                        break;
                    case 2: suit = "diamonds";
                        break;
                    case 3: suit = "spades";
                        break;
                    default:
                        suit = "Incorrect suit";
                        break;
                }

                //loop 13 times for cards
                for (int j = 0; j < 13; j++)
                {
                    switch (j)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                            card = (j + 2)+"";
                            break;
                        case 9:
                            card = "Jack";
                            break;
                        case 10:
                            card = "Queen";
                            break;
                        case 11:
                            card = "King";
                            break;
                        case 12:
                            card = "Ace";
                            break;
                        default:
                            card = "Invalid card";
                            break;
                    }

                    Console.WriteLine("{0, -7} of {1, -10}", card, suit);
                }

                Console.WriteLine("");
            }



            //5. Write a program that reads from the console number N and print the sum
            //of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,
            //13, 21, 34, 55, 89, 144, 233, 377, …

            //declare variables
            int previous = 1, current = 1, temp = 0;

            Console.WriteLine("How manyFibonacci numbers do you want?");
            a= int.Parse(Console.ReadLine());

            //MAnually print the first 3 numbers of the series
            Console.Write("0, 1, 1");
            for (int i = 3; i <= a; i++)
            {
                temp = previous + current;
                previous = current;
                current = temp;
                //print current with a spacing before
                Console.Write(", "+current);

            }

            //Write blank line before next problem
            Console.Write("\n\n");



            //6.Write a program that calculates N!/ K! for given N and K(1 < K < N).
            Console.WriteLine("Enter N and K for: N!/ K! for given N and K(1 < K < N)");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            temp = 1;

            //Calculat the factorial
            for (int i = k+1; i <= n; i++)
            {
                temp *= i;

            }

            Console.WriteLine("the factorial is {0}",temp);
            Console.ReadKey();
        }
    }
}
