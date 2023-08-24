using SkiaSharp;

namespace penazziRiccardo.src.map
{
    public interface IMapManager
    {
        void Draw(SKCanvas graphics2d);

        int[,] GetMapNum();

        Path GetBloonPath();

        bool CanPlace(int x, int y);

        string GetMapName();
    }
}
