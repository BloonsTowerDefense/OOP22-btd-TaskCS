using penazziRiccardo.src;
using penazziRiccardo.src.map;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace penazziRiccardo.test
{
    [TestClass]
    public class MapLoaderTest
    {
        private int[,] _expectedMap = new int[MapPanel.GAME_COL, MapPanel.GAME_ROW];

        [TestInitialize]
        public void SetUp()
        {
            _expectedMap[1, 1] = 1;
            for (int i = 0; i < MapPanel.GAME_COL; i++)
            {
                for (int j = 0; j < MapPanel.GAME_ROW; j++)
                {
                    _expectedMap[i, j] = 1;
                }
            }
        }

        [TestMethod]
        public void TestLoadMap()
        {
            IMapLoader mapLoader = new MapLoader();

            string basePath = Directory.GetCurrentDirectory();
            string relativePath = "mapTest01.txt"; // Percorso relativo al file
            string fullPath = System.IO.Path.Combine(basePath, relativePath);

            int[,] actualMap = mapLoader.LoadMap(relativePath);

            Assert.IsNotNull(actualMap);
            Assert.AreEqual(_expectedMap.GetLength(0), actualMap.GetLength(0));
            Assert.AreEqual(_expectedMap.GetLength(1), actualMap.GetLength(1));
            for (int i = 0; i < _expectedMap.GetLength(0); i++)
            {
                for (int j = 0; j < _expectedMap.GetLength(1); j++)
                {
                    Assert.AreEqual(_expectedMap[i, j], actualMap[i, j]);
                }
            }
        }
    }
}
