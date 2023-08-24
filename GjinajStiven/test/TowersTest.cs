
namespace gjinajStiven.test
{
    [TestClass]
    public class ShootingTowerTests
    {
        [TestMethod]
        public void Upgradable_TrueIfEnoughMoney()
        {
            var tower = new ShootingTower("blackAdam", 10, 100, new Position(0, 0));
            const int playerMoney = 150;

            var upgradable = tower.Upgradable(playerMoney);

            Assert.IsTrue(upgradable);
        }

        [TestMethod]
        public void Upgradable_FalseIfEnoughMoney()
        {
            var tower = new ShootingTower("blackAdam", 10, 100, new Position(0, 0));
            const int playerMoney = 80;
            
            var upgradable = tower.Upgradable(playerMoney);
            
            Assert.IsFalse(upgradable);
        }

        [TestMethod]
        public void Update_IncreasePowerAndHittingRange()
        {
            var tower = new ShootingTower("blackAdam", 10, 100, new Position(0, 0));
            var initialPower = tower.GetPower();
            var initialRange = tower.GetHittingRange();

            tower.Update();

            Assert.AreEqual(initialPower + 2, tower.GetPower());
            Assert.AreEqual(initialRange.GetX() + 5, tower.GetHittingRange().GetX());
            Assert.AreEqual(initialRange.GetY() + 5, tower.GetHittingRange().GetY());
        }

        [TestMethod]
        public void GetTowerSprite_ShouldReturnTowerSprite()
        {
            var tower = new ShootingTower("blackAdam", 10, 100, new Position(0, 0));

            var sprite = tower.GetTowerSprite();
            
            Assert.IsNotNull(sprite);
        }

        [TestMethod]
        public void GetPosition_ReturnTowerPosition()
        {
            var tower = new ShootingTower("blackAdam", 10, 100, new Position(5, 10));

            var position = tower.GetPosition();

            Assert.IsNotNull(position.GetX());
            Assert.IsNotNull(position.GetY());
            Assert.AreEqual(5, position.GetX());
            Assert.AreEqual(10, position.GetY());
        }

        [TestMethod]
        public void SetPosition_UpdateTowerPosition()
        {
            var tower = new ShootingTower("blackAdam", 10, 100, new Position(0, 0));

            tower.SetPosition(15, 20);

            var position = tower.GetPosition();
            Assert.IsNotNull(position.GetX());
            Assert.IsNotNull(position.GetY());
            Assert.AreEqual(15, position.GetX());
            Assert.AreEqual(20, position.GetY());
        }

        [TestMethod]
        public void SetHittingRange_UpdateHittingRange()
        {
            var tower = new ShootingTower("blackAdam", 10, 100, new Position(0, 0));

            tower.SetHittingRange(25, 30);
            
            var hittingRange = tower.GetHittingRange();
            Assert.AreEqual(25, hittingRange.GetX());
            Assert.AreEqual(30, hittingRange.GetY());
        }

        [TestMethod]
        public void SetPower_UpdateTowerPower()
        {
            var tower = new ShootingTower("blackAdam", 10, 100, new Position(0, 0));

            tower.SetPower(15);

            Assert.AreEqual(15, tower.GetPower());
        }

        [TestMethod]
        public void GetTowerSpriteManager_ShouldReturnTowerSpriteManager()
        {
            var tower = new ShootingTower("blackAdam", 10, 100, new Position(0, 0));

            var spriteManager = tower.GetTowerSpriteManager();

            Assert.IsNotNull(spriteManager);
        }
    }
}
