using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_042
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car() {
            this.Make = "Undefined";
            this.Model = "Undefined";
            this.Year = 1900;
            //this.Color = "Undefined";
        }

        public string FormatDetailsForDisplay() {
            return String.Format("Make: {0} - Model: {1} - Year: {2} - Color: {3}", Make, Model, Year, Color);
        }
    }
}