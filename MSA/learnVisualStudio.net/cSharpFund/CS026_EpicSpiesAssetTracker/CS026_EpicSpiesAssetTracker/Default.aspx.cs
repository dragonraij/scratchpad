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
                string[] name = new string[0];
                int[] elections = new int[0];
                int[] subterfuges = new int[0];

                ViewState.Add("name", name);
                ViewState.Add("elections", elections);
                ViewState.Add("subterfuges",subterfuges);
            }
        }

        protected void asset_Click(object sender, EventArgs e)
        {

        }
    }
}