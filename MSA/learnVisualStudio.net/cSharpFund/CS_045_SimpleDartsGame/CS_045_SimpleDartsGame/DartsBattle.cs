//Use less then 6 lines per method

using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_045_SimpleDartsGame
{
    public class DartsBattle
    {
        private Dart dartsGame = new Dart();
        private Player player1 { get; set; }
        private Player player2 { get; set; }
        public int winPoints { get; set; }

        public DartsBattle(Player Player1, Player Player2)
        {
            this.player1 = Player1;
            this.player2 = Player2;
            this.winPoints = 300; // winning condition is 300+ points
        }

        public void Battle()
        {
            while (this.player1.Score < this.winPoints && player2.Score < winPoints)
            {
                playRound(player1);
                playRound(player2);
            }

            


        }

        private void playRound(Player player)
        {
            for (int throws = 0; throws < 3; throws++)
            {
                player.Score += calculateScore();                
            }

        }

        private int calculateScore() {
            dartsGame.Throw();
            if (dartsGame.Section == 0)
                return bullseyeScore();
            else
                return sectionScore();
        
        }

        private int bullseyeScore()
        {
            if (dartsGame.RingPosition == 0)
                return 50;
            else return 25;
        }

        private int sectionScore()
        {
            if (dartsGame.RingPosition == 0)
                return dartsGame.Section * 3;
            else if (dartsGame.RingPosition == 1)
                return dartsGame.Section * 2;
            else return dartsGame.Section;
                
        }

        public string DisplayScore(){
            return String.Format("Player 1: {0} {1}pts - Player 2: {2} {3}pts", player1.Name, player1.Score, player2.Name, player2.Score);
        }

        public string WinnerName()
        {
            if (player1.Score > player2.Score)
                return player1.Name;
            else
                return player2.Name;
            
        }
    }


}