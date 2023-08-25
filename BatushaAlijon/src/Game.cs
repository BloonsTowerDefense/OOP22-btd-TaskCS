using System;
using System.Threading;

namespace BatushaAlijon.src
{
    public class Game
    {
        private static readonly long FrameTimeValue = 200; // 200 ms per frame
        private readonly long frameTime;
        public GameCondition gameCondition { get; private set; }  

        public Game()
        {
            this.frameTime = FrameTimeValue;
            this.gameCondition = GameCondition.MENU;
        }

        private void WaitForNextFrame(long currentTime)
        {
            long dt = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds - currentTime;
            if (dt < frameTime)
            {
                try
                {
                    Thread.Sleep((int)(frameTime - dt));
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine($"Exception: {e}");
                }
            }
        }

        public void StartGame()
        {
            long lastUpdateTime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
            while (RunningGame())
            {
                long currentTime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
                long elapsedTime = currentTime - lastUpdateTime;
                Update(elapsedTime);
                WaitForNextFrame(currentTime);
                lastUpdateTime = currentTime;
                Render();
            }
        }

        public bool RunningGame()
        {
            return this.gameCondition != GameCondition.EXIT;
        }

        public void Render()
        {
            switch (this.gameCondition)
            {
                case GameCondition.MENU:
                    // Render menu
                    break;
                case GameCondition.PLAY:
                    // Render game
                    break;
                case GameCondition.OVER:
                    // Render game over
                    break;
                default:
                    break;
            }
        }

        public void Update(long elapsedTime)
        {
            switch (this.gameCondition)
            {
                case GameCondition.PLAY:
                    // Update game state
                    break;
                default:
                    break;
            }
        }

        public void RestartGame()
        {
            this.gameCondition = GameCondition.MENU;
        }
    }
}