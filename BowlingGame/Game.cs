﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private int score;

        public void Roll(int pins)
        {
            score += pins;
        }

        public int Score()
        {
            return score; 
        }
    }
}
