using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare varialbes
            int num = 735;

            // check if even
            if (num%2==0)
            {
                Console.WriteLine("it is even");
            }
            else
            {
                Console.WriteLine("it is odd isnt it?");
            }


            //check if is divisible by 5 and  7

            if ((num%7==0&&num%5==0)==true)
            {
                Console.WriteLine("Is divisible by both 5 and 7 ");
            }

            //Check if the value of third digit from right is 7 in given number
            int num2 = num / 100;
            num2 = num2 % 10;
            if (num2 == 7)
            {
                Console.WriteLine("The third digit of " + num + " is " + num2);
            }

            Console.ReadKey();
        }
    }
}
