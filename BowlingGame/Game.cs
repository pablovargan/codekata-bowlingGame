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
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int roll = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[roll] + rolls[roll + 1] == 10)
                {
                    score += 10 + rolls[roll + 2];
                    roll += 2; 
                }
                else
                {
                    score += rolls[roll] + rolls[roll + 1];
                    roll += 2;
                }
            }

            return score; 
        }
    }
}
