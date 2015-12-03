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
            //used to calculate damage amount
            Random damage = new Random();

            //create 2 character classes and assign value
            Charact hero = new Charact();
            Charact monster = new Charact();
            hero.Name = "Galleon"; hero.Health = 99; hero.DamageMax = 10; hero.Attackbonus = 3;
            monster.Name = "Garados"; monster.Health = 80; hero.DamageMax = 10; hero.Attackbonus = 3;

            //Calculate Damage
            hero.Defend(monster.Attack());
            monster.Defend(hero.Attack());

            //Display results
            heroLabel.Text = String.Format("{0} health remaining is {1}", hero.Name, hero.Health);
            monsterLabel.Text = String.Format("{0} health remaining is {1}", monster.Name, monster.Health);
        }

        public class Charact {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMax { get; set; }
            public int Attackbonus { get; set; }

            public int Attack() {
                //used to calculate damage amount
                Random damage = new Random();
        
                return Attackbonus*(damage.Next(DamageMax)+1);
            }

            public void Defend(int attack) {
                Health -= attack;
            }
        }
    }
}