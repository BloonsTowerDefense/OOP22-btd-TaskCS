namespace MartignaniDaniele.waves
{
    // Represents a level in the tower defense game, which contains information about the waves of bloons that will spawn.
    public interface ILevel
    {
        // Returns the current wave of bloons for this level.
        IWave GetWave();
    }
}