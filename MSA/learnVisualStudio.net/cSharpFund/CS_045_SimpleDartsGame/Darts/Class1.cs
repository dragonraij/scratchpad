using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        Random random = new Random();
        private int sections { get; set; } // number of sections on board, zero is bulls eye
        private int chanceOfDouble { get; set; }
        private int chanceOfTriple { get; set; }
        public int chanceOfInnerBullsEye { get; set; }

        public int Section { get; set; }
        public int RingPosition { get; set; } // inner =0 outer =1 otherwise=3

        public Dart()
        {
            this.sections = 20; // number of sections on dart board, 0 is bulls eye
            this.chanceOfDouble = 5; //5%
            this.chanceOfTriple = 5; //5%
            this.chanceOfInnerBullsEye = 3; //3% chance
        }

        public void Throw()
        {
            this.Section = determineSection();
            this.RingPosition = determineRing();
        }

        private int determineSection()
        {
            return random.Next(sections + 1);
        }

        private int determineRing()
        {
            //Zero means you have hit bulls eye otherwise you are in different part of board
            if (Section == 0)
                return bullsEyeRing();
            else
                return boardRing();
        }

        private int bullsEyeRing() 
        {
            //get number between one and hundred
            int position = random.Next(100 + 1);
            if (position <= this.chanceOfInnerBullsEye)
            {
                return 0;
            }
            else return 1;
        }

        private int boardRing() {
            //get number between one and hundred
            int position = random.Next(100 + 1);

            //using percentage value determines which ring was hit. inner ring =0, outer ring =1, otherwise =2
            if (position <= this.chanceOfTriple)
                return 0;
            else if (position <= this.chanceOfTriple + chanceOfDouble)
                return 1;
            else return 2;        
        }


    }
}
