using System;
using System.Collections.Generic;
using MartignaniDaniele.entity;

namespace MartignaniDaniele.waves
{
    // Represents an implementation of the ILevel interface in the tower defense game.
    public class LevelImpl : ILevel
    {
        private int round;
        private readonly int difficultyMultiplier;
        private readonly Random rand;
        private bool waveInProgress;

        // Constructs a LevelImpl object with the specified difficulty and path.
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

        // Returns the current wave of bloons for this level.
        public IWave GetWave()
        {
            if (waveInProgress)
            {
                return null;
            }

            var bloons = new List<IBloon>();
            var numBloons = rand.Next(5, 15) + round * difficultyMultiplier;

            // Add bloons to the list based on bloonType
            for (var i = 0; i < numBloons; i++)
            {
                var bloonType = i % 3;
                IBloon b = null;

                // Create different types of bloons
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

        // Marks the current wave as finished.
        public void WaveFinished()
        {
            waveInProgress = false;
        }
    }
}
