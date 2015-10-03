using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTenYears
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            Console.WriteLine("Type your age in numbersals to find out how old you will be in 10 years time");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("In 10 years you will be {0} years old", age+10);
            Console.ReadKey();



        }
    }
}
