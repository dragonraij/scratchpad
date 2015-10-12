//Writen By Raj Prasad 11/10/15
//continueing with more examples from Fundamentals of Computer Programming
//Exercise 8 onwards
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreExpressions
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Declare varialbes
            int x , y,z, w, num = 0;

            //Get user to enter two values of x and y
            Console.WriteLine("Please enter a number for x axis");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for y axis");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Checking for a given point {x, y} if it is within the circle K({ 0, 0}, R = 5). \nExplanation: the point { 0, 0} is the center of the circle and 5 is the radius.");

            //use pythogoras thereom and the given radius to calculate whether it is less than 5
            if (Math.Sqrt((x * x) + (y * y))<=5)
            {
                Console.WriteLine("The point (x,y) is within a radius of 5");
            }
            else
            {
                Console.WriteLine("The point (x,y) is outside the radius of 5");
            }

            //Find if the number given  is outside a defined rectangle, given its coordinates
            Console.WriteLine("\n\nChecking if outside of the rectangle [{-1, 1}, {5, 5}].\nClarification: for the rectangle the lower left and the upper right corners are given.");

            //the point is outside the rectange if either the x value or the y value is outside the given range
            if ( ((x<-1)||(x>5)) || ((y<1)||(y>5)) )
            {
                Console.WriteLine("The coordinates are outside the specified rectangle");
            }
            else
            {
                Console.WriteLine("The coordinates are within the rectangle");
            }

            //Ask user for a four digit number and do various operations on it
            Console.WriteLine("\n\nPlease enter a four digit number");
            num = int.Parse(Console.ReadLine());
            w = num / 1000;
            x = (num / 100)%10;
            y = (num / 10)%10;
            z = num % 10;
            Console.WriteLine("The sum of the four digits is :\t\t\t"+(w+x+y+z));
            Console.WriteLine("The numbers in reverse order are:\t\t" +z+y+x+w);
            Console.WriteLine("When last digit is in the first place:\t\t" +z+w+x+y);
            Console.WriteLine("When the second and third digits are swapped:\t" +w+y+x+z);
            
            //Find the value of the fifth binary digit in the number num (counting starts from zero)
            int position = 5;
            int i = 00000001;
            int mask = i << position; //move the first bit left by n positions

            //if i and p are positive than the result of the bitwise operation is one
            Console.WriteLine("The {0}th binary digit of {1} is {2}.", position, num, (num&mask)!=0?1:0);
            Console.ReadKey();
        }
    }
}
