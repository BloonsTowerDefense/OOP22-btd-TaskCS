using System.Reflection;
using SkiaSharp;

namespace penazziRiccardo.src.map
{
    public class MapManager : IMapManager
    {
        private readonly List<MapElement> _mapElementList;
        private int[,] _mapNum;
        private readonly MapLoader _mapLoader;
        private Path _bloonPath;
        private readonly string _mapName;

        public MapManager(string mapName)
        {
            _mapName = mapName;
            _mapElementList = new List<MapElement>();
            _mapNum = new int[MapPanel.GAME_COL, MapPanel.GAME_ROW];
            _mapLoader = new MapLoader();
            LoadMapImage();
            SetMap(mapName);
        }

        public void Draw(SKCanvas graphics2d)
        {
            for (int currentRow = 0; currentRow < MapPanel.GAME_ROW; currentRow++)
            {
                for (int currentCol = 0; currentCol < MapPanel.GAME_COL; currentCol++)
                {
                    int tileNum = _mapNum[currentCol, currentRow];
                    MapElement mapElement = _mapElementList[tileNum];
                    int x = currentCol * MapPanel.FINAL_SPRITE_SIZE;
                    int y = currentRow * MapPanel.FINAL_SPRITE_SIZE;
                    SKRect destRect = SKRect.Create(x, y, MapPanel.FINAL_SPRITE_SIZE, MapPanel.FINAL_SPRITE_SIZE);
                    graphics2d.DrawBitmap(mapElement.GetImg(), destRect);
                }
            }
        }

        public int[,] GetMapNum()
        {
            int rows = _mapNum.GetLength(0);
            int cols = _mapNum.GetLength(1);
            int[,] copy = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    copy[i, j] = _mapNum[i, j];
                }
            }
            return copy;
        }

        public Path GetBloonPath()
        {
            return _bloonPath;
        }

        public bool CanPlace(int x, int y)
        {
            int newX = x / MapPanel.FINAL_SPRITE_SIZE;
            int newY = y / MapPanel.FINAL_SPRITE_SIZE;
            return _mapNum[newX, newY] == 2;
        }

        public string GetMapName()
        {
            return _mapName;
        }

        private void LoadMapImage()
        {
            try
            {
                _mapElementList.Add(
                    new MapElement(SKBitmap.Decode(Assembly.GetExecutingAssembly().GetManifestResourceStream("Btd.Resources.mapSprite.sand.png"))));
                _mapElementList.Add(
                    new MapElement(SKBitmap.Decode(Assembly.GetExecutingAssembly().GetManifestResourceStream("Btd.Resources.mapSprite.tree.png"))));
                _mapElementList.Add(
                    new MapElement(SKBitmap.Decode(Assembly.GetExecutingAssembly().GetManifestResourceStream("Btd.Resources.mapSprite.wall.png"))));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString);
            }
        }

        private void SetMap(string mapName)
        {
            string src = $"/map/{mapName}/{mapName}.txt";
            _mapNum = _mapLoader.LoadMap(src);
            _bloonPath = new Path(mapName, false);
        }
    }
}
