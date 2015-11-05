using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS019_EpicSpies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousCalendar.SelectedDate = DateTime.Now.Date;
                startCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void previousCalendar_SelectionChanged(object sender, EventArgs e)
        {
            startCalendar.SelectedDate = previousCalendar.SelectedDate.AddDays(14);
        }
    }
}