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

            Console.ReadKey();
        }
    }
}
