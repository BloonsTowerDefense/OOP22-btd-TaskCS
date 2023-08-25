using Microsoft.VisualStudio.TestTools.UnitTesting;
using BatushaAlijon.src;  
using System.Threading.Tasks;

namespace BatushaAlijon.test
{
    [TestClass]
    public class GameTests
    {
        private Game game;

        [TestInitialize]
        public void SetUp()
        {
            game = new Game();
        }

        [TestMethod]
        public void TestRunningGameInitiallyReturnsTrue()
        {
            Assert.IsTrue(game.RunningGame());
        }

        [TestMethod]
        public void TestUpdateMethod()
        {
           
            game.Update(100);
        }

        [TestMethod]
        public void TestRestartGame()
        {
            game.RestartGame();
            Assert.AreEqual(GameCondition.MENU, game.gameCondition);  
        }

        [TestMethod]
        public async Task TestGameLoopRuns()
        {
            // Start the game loop in a separate Task
            var gameLoopTask = Task.Run(() => game.StartGame());

            // Let the game run for a short period
            await Task.Delay(500);  // 500 ms

            Assert.AreEqual(GameCondition.MENU, game.gameCondition);  

            // Exit the game
            game.gameCondition = GameCondition.EXIT;  
        }
    }
}