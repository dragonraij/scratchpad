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
            //declare num
            int num =0;


            //get a value of num
            Console.WriteLine("Please enter a number...");
            num =int.Parse(Console.ReadLine());
            
            
            // check if even
            if (num%2==0)
            {
                Console.WriteLine(num+" is even");
            }
            else
            {
                Console.WriteLine(num+" is odd isnt it?");
            }


            //check if is divisible by 5 and  7

            if ((num%7==0&&num%5==0)==true)
            {
                Console.WriteLine(num+" is divisible by both 5 and 7 ");
            }

            //Check if the value of third digit from right is 7 in given number
            int num2 = num / 100;
            num2 = num2 % 10;
            if (num2 == 7)
            {
                Console.WriteLine("The third digit of " + num + " is " + num2);
            }
            else
            {
                Console.WriteLine("The third digit of " + num + " is " + num2);
            }

            //Find the value of the third bit of num (counting bits from zero)
            //sol: using & operator compare to 000001000 to see if is zero or not

            if ((num&8)==0)
            {
                Console.WriteLine("Third binary value of "+num+" is not 1");
            }
            else
            {
                Console.WriteLine("Third binary value of "+num+" is 1");
            }
            Console.ReadKey();
        }
    }
}
