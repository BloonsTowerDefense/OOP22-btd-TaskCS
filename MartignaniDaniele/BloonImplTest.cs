using MartignaniDaniele.entity;

namespace MartignaniDanieleTest
{
    [TestClass]
    public class BloonImplTest
    {
        private IBloon CreateBloon()
        {
            return new BloonImpl(BloonType.RedBloon);
        }

        [TestMethod]
        public void TestInitialHealth()
        {
            IBloon bloon = CreateBloon();
            Assert.AreEqual(BloonType.RedBloon.GetHealth(), bloon.Health);
        }

        [TestMethod]
        public void TestHit()
        {
            IBloon bloon = CreateBloon();
            var damage = 5;
            bloon.Hit(damage);
            Assert.AreEqual(BloonType.RedBloon.GetHealth() - damage, bloon.Health);
        }

        [TestMethod]
        public void TestUpdate()
        {
            IBloon bloon = CreateBloon();
            Assert.IsFalse(bloon.IsDead());
            bloon.Hit((int)bloon.Health);
            Assert.IsTrue(bloon.IsDead());
        }

        [TestMethod]
        public void TestGetType()
        {
            IBloon bloon = CreateBloon();
            Assert.AreEqual(BloonType.RedBloon, bloon.BloonType);
        }


        [TestMethod]
        public void TestSetHealth()
        {
            IBloon bloon = CreateBloon();
            var newHealth = 50;
            bloon.Health = newHealth;
            Assert.AreEqual(newHealth, bloon.Health);
        }
    }
}