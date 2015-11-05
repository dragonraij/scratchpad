using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS016_DaysElapsed
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void differenceButton_Click(object sender, EventArgs e)
        {
            //hackety hack code: gets two dates from calender controllers, subtracts to get difference
            //in terms of days, the absolute value calculated to give difference of days
            resultLabel.Text = ""+Math.Abs((Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate)).Days);
        }
    }
}