using System.Collections.Generic;
using MartignaniDaniele.entity;

namespace MartignaniDaniele.waves
{
    // Represents a wave of bloons in the tower defense game.
    public interface IWave
    {
        // Returns a list of bloons present in the wave.
        List<IBloon> GetBloons();
    }
}