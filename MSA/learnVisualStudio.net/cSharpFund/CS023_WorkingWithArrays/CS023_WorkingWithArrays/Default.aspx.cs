using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS023_WorkingWithArrays
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] hours = new double[0];
                ViewState.Add("Hours", hours);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double[] hours = (double[])ViewState["Hours"];

            Array.Resize(ref hours, hours.Length + 1);
            int newestItem = hours.GetUpperBound(0);
            hours[newestItem] = double.Parse(TextBox1.Text);

            ViewState["Hours"] = hours;

            Label1.Text = String.Format("Total hours: {0}<br>Minimum Hours: {1} <br>Max hours : {2} <br> Average HOurs: {3:N2}", hours.Sum(), hours.Min(), hours.Max(), hours.Average());
        }
    }
}