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

        //Variables
        int vacationDays = 14;
        int dailyRate = 500;
        int bonus = 1000; //paid out if assisgned days > 21
        int bonusDays = 21;
        int totalPayment = 0;

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
            if (startCalendar.SelectedDate.Subtract(previousCalendar.SelectedDate).Days<vacationDays) 
            {
                resultLabel.Text = "Spy needs two weeks of break before next assignment to recuperate";
            }
            else{
                totalPayment =  endCalendar.SelectedDate.Subtract(startCalendar.SelectedDate).Days * dailyRate;

                if (startCalendar.SelectedDate.Subtract(endCalendar.SelectedDate).Days>bonusDays)
                {
                    totalPayment += 1000;
                }
                 resultLabel.Text = spyNameTextBox.Text+" has been assigned to "+assignmentNameTextBox.Text+", total payment is $"+totalPayment;
	        }
        }

        protected void previousCalendar_SelectionChanged(object sender, EventArgs e)
        {
            startCalendar.SelectedDate = previousCalendar.SelectedDate.AddDays(14);
        }
    }
}