using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            for (int i = 0; i < 18; i++)
            {
                game.Roll(0);
            }

            game.Roll(2);
            game.Roll(8);
            game.Roll(1);

            System.Diagnostics.Debug.WriteLine(game.Score());
        }
    }
}
