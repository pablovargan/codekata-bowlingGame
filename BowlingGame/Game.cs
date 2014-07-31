using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private int[] rolls;
        private int currentRoll;

        public Game()
        {
            rolls = new int[21];
            currentRoll = 0;
        }

        public void Roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int Score()
        {
            int score = 0;
            int roll = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(roll))
                {
                    score += 10 + StrikeBonus(roll);
                    roll++;
                }
                else if (IsSpare(roll))
                {
                    score += 10 + SpareBonus(roll);
                    roll += 2; 
                }
                else
                {
                    score += SumOfPinInFrame(roll);
                    roll += 2;
                }
            }

            return score; 
        }

        private bool IsSpare(int roll)
        {
            bool isSpare = false;
            if ((rolls[roll] + rolls[roll + 1]) == 10)
            {
                isSpare = true;
            }

            return isSpare;
        }

        private bool IsStrike(int roll)
        {
            bool isStrike = false;
            if (rolls[roll] == 10)
            {
                isStrike = true;
            }

            return isStrike;
        }

        private int StrikeBonus(int roll)
        {
            return rolls[roll + 1] + rolls[roll + 2];
        }
        private int SpareBonus(int roll)
        {
            return rolls[roll + 2];
        }

        private int SumOfPinInFrame(int roll)
        {
            return rolls[roll] + rolls[roll + 1];
        }
    }
}
