using penazziRiccardo.src.utils;

namespace penazziRiccardo.src.map
{
    public interface IPath
    {
        List<Direction> GetDirections();

        /// <summary>
        /// Returns the spawn position of bloons at the beginning of the path.
        /// </summary>
        /// <returns>Spawn position as a Position instance.</returns>
        Position GetSpawnPosition();

        /// <summary>
        /// Returns the distance of the path as the number of steps.
        /// </summary>
        /// <returns>Distance of the path.</returns>
        int GetPathDistance();

        /// <summary>
        /// Returns the size of each tile.
        /// </summary>
        /// <returns>The size of each tile.</returns>
        int GetTileSize();
    }
}
