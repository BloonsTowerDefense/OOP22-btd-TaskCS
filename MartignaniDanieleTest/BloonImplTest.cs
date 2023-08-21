using System;
using System.Collections.Generic;
using MartignaniDaniele.entity;
using MartignaniDaniele.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MartignaniDanieleTest
{
    [TestClass]
    public class BloonImplTest
    {
        private IBloon bloon;

        private IBloon CreateBloon(){
            bloon = new BloonImpl(BloonType.RedBloon);
        }

        [TestMethod]
        public void TestInitialHealth()
        {
            Assert.AreEqual(BloonType.RedBloon.GetHealth(), bloon.GetHealth());
        }

        [TestMethod]
        public void TestHit()
        {
            var damage = 5;
            bloon.Hit(damage);
            Assert.AreEqual(BloonType.RedBloon.GetHealth() - damage, bloon.GetHealth());
        }

        [TestMethod]
        public void TestUpdate()
        {
            Assert.IsFalse(bloon.IsDead());
            bloon.Hit((int)bloon.GetHealth());
            Assert.IsTrue(bloon.IsDead());
        }

        [TestMethod]
        public void TestGetType()
        {
            Assert.AreEqual(BloonType.RedBloon, bloon.GetBloonType());
        }


        [TestMethod]
        public void TestSetHealth()
        {
            var newHealth = 50;
            bloon.Health = newHealth;
            Assert.AreEqual(newHealth, bloon.Health);
        }
    }
}
