using System.Collections.Generic;
using MartignaniDaniele.entity;

namespace MartignaniDaniele.waves
{
    // Represents an implementation of the IWave interface in the tower defense game.
    public class WaveImpl : IWave
    {
        private readonly List<IBloon> bloons;

        // Constructs a WaveImpl object with the specified list of bloons.
        public WaveImpl(List<IBloon> bloons)
        {
            this.bloons = bloons;
        }

        // Returns a list containing the bloons in the wave.
        public List<IBloon> GetBloons()
        {
            return new List<IBloon>(bloons);
        }
    }
}