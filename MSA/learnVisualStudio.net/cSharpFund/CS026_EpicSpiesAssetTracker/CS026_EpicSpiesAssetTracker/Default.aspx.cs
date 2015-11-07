using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS026_EpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] names = new string[0];
                int[] elections = new int[0];
                int[] subterfuges = new int[0];

                ViewState.Add("names", names);
                ViewState.Add("elections", elections);
                ViewState.Add("subterfuges",subterfuges);
            }
        }

        protected void asset_Click(object sender, EventArgs e)
        {
            //retrieve items from viewstate
            string[] names = (string[])ViewState["names"];
            int[] elections = (int[])ViewState["elections"];
            int[] subterfuges = (int[])ViewState["subterfuges"];

            //Increase the sizes of the arrays by one
            Array.Resize(ref names, names.Length+1);
            Array.Resize(ref elections, elections.Length + 1);
            Array.Resize(ref subterfuges, subterfuges.Length + 1);

            //find the position of the last item in the array
            int lastItem = names.GetUpperBound(0);

            //Add items added by users to arrays
            names[lastItem] = nameTextBox.Text;
            elections[lastItem] = int.Parse(electionsTextBox.Text);
            subterfuges[lastItem] = int.Parse(subterfugeTextBox.Text);

            //display the output
            resultLabel.Text = string.Format("Total elections rigged is {0}, average subterfuge performed {1:N2}, the last spy added was {2}", elections.Sum(), subterfuges.Average(), names[lastItem]);

            //save arrays in viewstate
            ViewState["names"] = names;
            ViewState["elections"] = elections;
            ViewState["subterfuges"] = subterfuges;
        }
    }
}