using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS012_NotePreferance
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                ResultLabel.Text = "So you like making notes with a pencil";
            }
            else if (penRadioButton.Checked)
            {
                ResultLabel.Text = "So you like making notes with a pen";
            }
            else if (tabletRadioButton.Checked)
            {
                ResultLabel.Text = "So you like making notes on your tablet";
            }
            else if (phoneRadioButton.Checked)
            {
                ResultLabel.Text = "So you like making notes on your phone";                
            }
            else
            {
                ResultLabel.Text = "So you think you are too good to be taking notes";                
            }
        }


    }
}