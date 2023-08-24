using MartignaniDaniele.entity;

namespace MartignaniDaniele.waves
{
    public class LevelImpl : ILevel
    {
        private int round;
        private readonly int difficultyMultiplier;
        private readonly Random rand;
        private bool waveInProgress;

        public LevelImpl(string difficulty)
        {
            round = 1;
            rand = new Random();
            waveInProgress = false;
            if (string.Equals(difficulty, "facile", StringComparison.OrdinalIgnoreCase))
            {
                difficultyMultiplier = 1;
            }
            else if (string.Equals(difficulty, "normale", StringComparison.OrdinalIgnoreCase))
            {
                difficultyMultiplier = 2;
            }
            else
            {
                difficultyMultiplier = 3;
            }
        }

        public IWave GetWave()
        {
            if (waveInProgress)
            {
                return null;
            }

            var bloons = new List<IBloon>();
            var numBloons = rand.Next(5, 15) + round * difficultyMultiplier;

            for (var i = 0; i < numBloons; i++)
            {
                var bloonType = i % 3;
                IBloon b = null;

                if (bloonType == 0)
                {
                    b = new BloonImpl(BloonType.RedBloon);
                    b.Health = BloonTypeExtensions.GetHealth(b.BloonType) + round;
                }
                else if (bloonType == 1)
                {
                    b = new BloonImpl(BloonType.BlueBloon);
                    b.Health = BloonTypeExtensions.GetHealth(b.BloonType) + round;
                }
                else
                {
                    b = new BloonImpl(BloonType.BlackBloon);
                    b.Health = BloonTypeExtensions.GetHealth(b.BloonType) + round;
                }

                bloons.Add(b);
            }

            round++;
            waveInProgress = true;
            return new WaveImpl(bloons);
        }

        public void WaveFinished()
        {
            waveInProgress = false;
        }
    }
}
