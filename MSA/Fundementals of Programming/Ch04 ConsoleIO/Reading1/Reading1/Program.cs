/*Written by Rajehwar prasad
13/10/2015
This program follows through the exercises in the Fundermentals of Computer Science Book by Nakov
Covering Chapter4Console Input and output
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int a, b, c, count = 0;
            //1. Write a program that reads from the console three numbers of type int and prints their sum.
            Console.WriteLine("Give me three numbers and I will tell you its sum");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            //Sum and Display the output to console
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, (a+b+c) );



            //2. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            Console.WriteLine("Give me the radius of a circle and I can tell you its area and perimeter");
            a = int.Parse(Console.ReadLine());

            //Display Results
            Console.WriteLine("The area is {0} and the perimeter is {1}", 3.14*a*a, 2*3.14*a);



            /*4. Write a program that prints three numbers in three virtual columns
            on the console. Each column should have a width of 10 characters and
            the numbers should be left aligned. The first number should be an
            integer in hexadecimal; the second should be fractional positive; and
            the third – a negative fraction. The last two numbers have to be
            rounded to the second decimal place. */

            Console.WriteLine("|{0,-10:x}|{1,-10:F2}|{2,-10:f2}|", a,b,c);



            /*5. Write a program that reads from the console two integer numbers (int)
            and prints how many numbers between them exist, such that the
            remainder of their division by 5 is 0. Example: in the range (14, 25)
            there are 3 such numbers: 15, 20 and 25.
            In this case uses b and c entered previously*/

            for (int i = b; i <= c; i++)
            {
                if (i%5==0)
                {
                    count++;
                }
            }

            //Display results
            Console.WriteLine("There are {0} multiples of 5 between {1} and {2}", count, b, c);



            /*6. Write a program that reads two numbers from the console and prints the
            greater of them.Solve the problem without using conditional
           statements.*/

            Console.WriteLine("The bigger number of {0} and {1} is {2}", b, c, b>c? b :c);



            /*7. Write a program that reads five integer numbers and prints their
            sum. If an invalid number is entered the program should prompt the user
            to enter another number.*/

            //set counter to zero, use variable a as total, make zero
            count = a = 0;

            Console.WriteLine("Give me five numbers and I will total them up for you");

            do
            {
                //prompt for a number
                Console.WriteLine("Please enter a number ({0} more needed)", 5-count);

                //parse and see if number is valid if so add to total, incement counter otherwise
                //inform user the input is invalid and to try again
                if (int.TryParse(Console.ReadLine(), out c))
                {
                    a += c;
                    count++;
                }
                else
                {
                    Console.WriteLine("The input was not accepted, please try again");
                }

            } while (count<5);

            Console.WriteLine("The total of the 5 numbers is " +a);

            /*8. Write a program that reads five numbers from the console and prints the
            greatest of them. */
            //reuses code from the previous example to get input

            count = a = 0;
            Console.WriteLine("Enter 5 different numbers to find which is the largest number enterd");
            do
            {
                Console.WriteLine("Please enter a number ({0} more needed)", 5-count);
                if (int.TryParse(Console.ReadLine(), out c))
                {
                    //assign larger value to a and increment counter
                    a =  c>a? c :a;
                    count++;
                }
                else
                {
                    Console.WriteLine("Number not accepted, try again");
                }
            } while (count <5);

            //Display results
            Console.WriteLine("The largest number entered was " + a);



            // 9. Write a program that reads an integer number n from the console. After
            // that reads n numbers from the console and prints their sum.

            a = b = 0; //a is num of varialbes, b is sum
            Console.WriteLine("\n How many numbers do you want to sum up?");
            int.TryParse(Console.ReadLine(), out a); //implement check later

            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter a number =>");
                b += int.Parse(Console.ReadLine()); // add input to the total
            }

            //Display the total
            Console.WriteLine("The total of the {0} numbers is {1}", a, b);

                                   Console.ReadKey();
        }
    }
}
