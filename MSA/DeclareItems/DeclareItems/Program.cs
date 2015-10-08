using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareItems
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte first = -115;
            sbyte second = 97;
            ushort third = 52130;
            int fourth = 4825932;
            short fifth = -10000;
            short sixth = 20000;
            byte seven = 224;
            uint eight = 970700000;
            sbyte nine = 112;
            sbyte ten = -44;
            int elev = -1000000;
            long twelv = 123456789123456789;
            float thir = 5f;
            double four = 34.242423222;
            decimal fif = 3045.3898790907868768767864432432223475m;

            Console.WriteLine("Min Max of {0} {1} {2}", fif.GetType(), decimal.MinValue, decimal.MaxValue);
             Console.ReadKey();
        }
    }
}
