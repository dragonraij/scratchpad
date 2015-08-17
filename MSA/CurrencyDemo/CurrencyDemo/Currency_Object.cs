using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyDemo
{
    class Currency_Object
    {
        public class Rates
        {
            public double currency { get; set; }
        }

        public class RootObject
        {
            public string @base { get; set; }
            public string date { get; set; }
            public Rates rates { get; set; }
        }
    }
}
