using MartignaniDaniele.entity;

namespace MartignaniDaniele.waves
{
    public class WaveImpl : IWave
    {
        private readonly List<IBloon> bloons;

        public WaveImpl(List<IBloon> bloons)
        {
            this.bloons = bloons;
        }

        public List<IBloon> GetBloons()
        {
            return new List<IBloon>(bloons);
        }
    }
}