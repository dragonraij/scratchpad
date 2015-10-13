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
            int a, b, c = 0;
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

            Console.ReadKey();
        }
    }
}
