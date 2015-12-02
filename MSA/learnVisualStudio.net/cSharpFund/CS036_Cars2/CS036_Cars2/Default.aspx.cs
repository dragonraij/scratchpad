using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS036_Cars2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myNewCar = new Car();
            myNewCar.Color = "Red";
            myNewCar.Make = "Nissan";
            myNewCar.Model = "Helios";
            myNewCar.Year = 1999;

            resultLabel.Text = String.Format("{0} {1} {2} {3} {4:C}", myNewCar.Year, myNewCar.Color, myNewCar.Make, myNewCar.Model, myNewCar.determineMarketValue());
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string  Color { get; set; }

        public double determineMarketValue() {
            if (Year>2000)
            {
                return 10000;
            }
            else
            {
                return 5000;
            }
        }
    }


}