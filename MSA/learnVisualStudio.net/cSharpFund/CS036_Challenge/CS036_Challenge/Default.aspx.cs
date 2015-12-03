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
            Dice currentDice = new Dice();

            //create 2 character classes and assign value
            Charact hero = new Charact();
            Charact monster = new Charact();
            hero.Name = "Galleon"; hero.Health = 99; hero.DamageMax = 10; hero.Attackbonus = true;
            monster.Name = "Garados"; monster.Health = 80; monster.DamageMax = 10; monster.Attackbonus = fal;


            //If a character has attack bonus they get an extra attack in begining
            if (hero.Attackbonus)
            {
              monster.Defend(hero.Attack(currentDice));   
            }

            if (monster.Attackbonus)
            {
                hero.Defend(monster.Attack(currentDice));
                
            }
            //Calculate Damage
            hero.Defend(monster.Attack(currentDice));
            monster.Defend(hero.Attack(currentDice));

            //Display results
            heroLabel.Text = String.Format("{0} health remaining is {1}", hero.Name, hero.Health);
            monsterLabel.Text = String.Format("{0} health remaining is {1}", monster.Name, monster.Health);
        }

        public class Dice
        {
            public int Sides { get; set; }
            Random random = new Random();

            public int Roll() {
                return random.Next(this.Sides);
            }
        }
        public class Charact {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMax { get; set; }
            public bool Attackbonus { get; set; }

            public int Attack(Dice currentDice) {
                //used to calculate damage amount
                currentDice.Sides = DamageMax;
        
                return currentDice.Roll();
            }

            public void Defend(int attack) {
                Health -= attack;
            }
        }
    }
}