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
            //Declare two varialbes
            int x , y = 0;

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
        }
    }
}
