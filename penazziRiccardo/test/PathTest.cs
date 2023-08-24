using Microsoft.VisualStudio.TestTools.UnitTesting;
using penazziRiccardo.src.map;
using penazziRiccardo.src.utils;

namespace penazziRiccardo.tests.map
{
    [TestClass]
    public class PathTest
    {
        private List<Direction> _test;

        [TestInitialize]
        public void SetUp()
        {
            _test = new List<Direction>
            {
                Direction.Up, Direction.Down, Direction.Right, Direction.Left, Direction.Down,
                Direction.Down, Direction.Right, Direction.Right, Direction.Right, Direction.Right,
                Direction.Right, Direction.Left, Direction.Left, Direction.Up, Direction.Up, Direction.Left
            };
        }

        [TestMethod]
        public void TestPathImpl1()
        {
            src.map.Path path = new src.map.Path("", true);

            Assert.IsNotNull(path.GetSpawnPosition());
            Assert.IsNotNull(path.GetDirections());

            List<Direction> directions = path.GetDirections();
            Assert.IsTrue(directions.Count > 0);

            foreach (Direction direction in directions)
            {
                Assert.IsNotNull(direction);
            }

            for (int i = 0; i < _test.Count; i++)
            {
                Assert.AreEqual(_test[i], path.GetDirections()[i]);
            }
        }

        [TestMethod]
        public void TestPathImpl2()
        {
            src.map.Path path = new src.map.Path("", true);

            List<Direction> directions = path.GetDirections();

            for (int i = 0; i < _test.Count; i++)
            {
                Assert.AreEqual(_test[i], directions[i]);
            }
        }
    }
}
