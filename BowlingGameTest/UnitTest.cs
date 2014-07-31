using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class UnitTest
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

        [TestMethod]
        public void OneSpareTest()
        {
            RollSpare();
            game.Roll(3);
            RollMany(17, 0);

            Assert.AreEqual(16, game.Score());
        }

        [TestMethod]
        public void OneStrikeTest()
        {
            game.Roll(10);
            game.Roll(2);
            game.Roll(2);
            RollMany(16, 0);

            Assert.AreEqual(24, game.Score());
        }

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < pins; i++)
            {
                game.Roll(rolls);
            }
        }

        private void RollSpare()
        {
            game.Roll(4);
            game.Roll(6);
        }

    }
}
