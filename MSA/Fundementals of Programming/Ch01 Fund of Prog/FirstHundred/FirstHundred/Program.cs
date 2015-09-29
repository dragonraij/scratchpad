using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prints the first 100 numbers of the sequence: 2, -3, 4, -5, 6 ...");

            int num = 1;

            for (int i = 0; i < 100; i++)
            {
                num++;
                if (num%2==1)
                {
                    Console.WriteLine(-num);
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadKey();
        }
    }
}
