using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class Test
    {
        private Game game;

        [TestInitialize]
        public void Init()
        {
            game = new Game();
        }

        [TestMethod]
        public void GutterGameTest()
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void AllOneTest()
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            Assert.AreEqual(20, game.Score());
        }

    }
}
