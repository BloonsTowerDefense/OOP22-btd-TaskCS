using penazziRiccardo.src.utils;

namespace penazziRiccardo.src.map
{
    public interface IPath
    {
        List<Direction> GetDirections();

        Position GetSpawnPosition();

        int GetPathDistance();

        int GetTileSize();
    }
}
