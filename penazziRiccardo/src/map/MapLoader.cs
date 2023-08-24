namespace penazziRiccardo.src.map
{
    /// <summary>
    /// This class implements the <see cref="IMapLoader"/> interface.
    /// </summary>
    public class MapLoader : IMapLoader
    {
        /// <inheritdoc />
        public int[,] LoadMap(string mapName)
        {
            Console.WriteLine("Sono loadMap");
            int[,] ret = new int[MapPanel.GAME_COL, MapPanel.GAME_ROW];

            try
            {
                string filePath = mapName; // Inserisci il percorso completo del file
                Console.WriteLine("Provo ad aprire il file: " + filePath);
                
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
