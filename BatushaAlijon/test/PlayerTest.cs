using Microsoft.VisualStudio.TestTools.UnitTesting;
using BatushaAlijon;

namespace BatushaAlijonTest
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void TestHealth()
        {
            Player player = new Player();
            Assert.AreEqual(15, player.GetHealth());

            player.SetHealth(10);
            Assert.AreEqual(10, player.GetHealth());

            player.LoseHealth(5);
            Assert.AreEqual(5, player.GetHealth());
        }

        [TestMethod]
        public void TestScore()
        {
            Player player = new Player();
            Assert.AreEqual(0, player.GetScore());

            player.SetScore(10);
            Assert.AreEqual(10, player.GetScore());

            player.GainScore(10);
            Assert.AreEqual(20, player.GetScore());
        }

        [TestMethod]
        public void TestCoins()
        {
            Player player = new Player();
            Assert.AreEqual(200, player.GetCoins());

            player.SetCoins(100);
            Assert.AreEqual(100, player.GetCoins());

            player.GainCoins(50);
            Assert.AreEqual(150, player.GetCoins());
        }
    }
}
