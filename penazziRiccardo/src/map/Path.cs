using penazziRiccardo.src.utils;

namespace penazziRiccardo.src.map
{
    public class Path : IPath
    {
        private readonly List<Direction> _path;
        private Position _spawnPosition;

        public Path(string source, bool test)
        {
            _path = new List<Direction>();
            LoadPath(source, test);
        }

        public List<Direction> GetDirections()
        {
            return new List<Direction>(_path);
        }

        public Position GetSpawnPosition()
        {
            return new Position(_spawnPosition.GetX(), _spawnPosition.GetY());
        }

        public int GetPathDistance()
        {
            return _path.Count;
        }

        public int GetTileSize()
        {
            return MapPanel.FINAL_SPRITE_SIZE;
        }

        private void LoadPath(string source, bool test)
        {
            string realSource = test ? "bloonsPathTest.txt" : $"/map/{source}/bloonsPath.txt";

            try
            {
                string fileContent = File.ReadAllText(realSource);

                string[] lines = fileContent.Split('\n');

                if (lines.Length >= 2)
                {
                    string[] spawnPosition = lines[0].Split(' ');
                    _spawnPosition = new Position(double.Parse(spawnPosition[0]), double.Parse(spawnPosition[1]));
                    int step = int.Parse(spawnPosition[2]);

                    string[] path = lines[1].Split(' ');
                    for (int i = 0; i < step && i < path.Length; i++)
                    {
                        _path.Add(DecodeDirection(int.Parse(path[i])));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        private Direction DecodeDirection(int input)
        {
            return input switch
            {
                1 => Direction.Up,
                2 => Direction.Down,
                3 => Direction.Right,
                4 => Direction.Left,
                _ => Direction.Down
            };
        }
    }
}
