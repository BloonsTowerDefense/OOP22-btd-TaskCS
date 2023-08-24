namespace penazziRiccardo.src.map
{
    public class MapLoader : IMapLoader
    {
        public int[,] LoadMap(string mapName)
        {
            int[,] ret = new int[MapPanel.GAME_COL, MapPanel.GAME_ROW];

            try
            {
                string filePath = mapName;
                
                if (!File.Exists(filePath))
                {
                    throw new ArgumentException("Map file not found: " + mapName);
                }

                string fileContent = File.ReadAllText(filePath);

                Console.WriteLine("Contenuto del file:");
                Console.WriteLine(fileContent);

                string[] lines = fileContent.Split('\n');
                for (int row = 0; row < lines.Length && row < MapPanel.GAME_ROW; row++)
                {
                    string[] numbers = lines[row].Split(' ');

                    for (int col = 0; col < numbers.Length && col < MapPanel.GAME_COL; col++)
                    {
                        if (int.TryParse(numbers[col], out int currentNum))
                        {
                            ret[col, row] = currentNum;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number in the file at row " + row + " and column " + col);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }

            return ret;
        }

    }
}
