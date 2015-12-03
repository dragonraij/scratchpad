using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS036_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Charact hero = new Charact();
            Charact monster = new Charact();


        }

        public class Charact {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMax { get; set; }
            public int Attackbonus { get; set; }

            public int Attack() {
                Random damage = new Random();
                return Attackbonus*(damage.Next(DamageMax)+1);
            }

            public void Defend(int attack) {
                Health -= attack;
            }
        }
    }
}