using SkiaSharp;

namespace gjinajStiven
{
    public class ShootingTower : ITower
    {
        private const int UpgradeFactor = 2;
        private const int RangeFactor = 5;
        private const int PriceFactor = 50;

        private readonly string _towerName;
        private int _power;
        private readonly int _price;
        private Position _position;
        private Position _hittingRange;
        private readonly ITowerSpriteManager _towerSpriteManager;

        public ShootingTower(string towerName, int power, int price, Position position)
        {
            _towerSpriteManager = new TowerSpriteManagerImpl(towerName);
            _towerName = towerName;
            _power = power;
            _price = price;
            _position = position;
            _hittingRange = new Position(RangeFactor, RangeFactor);
        }

        public bool Upgradable(int playerMoney)
        {
            return playerMoney - _price >= 0;
        }

        public void Update()
        {
            _towerSpriteManager.Upgrade(_towerName);
            _power += UpgradeFactor;
            _hittingRange = new Position(_hittingRange.GetX() + RangeFactor, _hittingRange.GetY() + RangeFactor);
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetUpgradePrice()
        {
            return _price + PriceFactor;
        }

        public SKBitmap GetTowerSprite()
        {
            return _towerSpriteManager.GetTowerSpriteList()[0];
        }

        public Position? GetPosition()
        {
            return _position;
        }

        public string GetName()
        {
            return _towerName;
        }

        public void SetPosition(double x, double y)
        {
            _position = new Position(x, y);
        }

        public void SetHittingRange(double x, double y)
        {
            _hittingRange = new Position(x, y);
        }

        public void SetPower(int power)
        {
            _power = power;
        }

        public Position GetHittingRange()
        {
            return _hittingRange;
        }

        public int GetPower()
        {
            return _power;
        }

        public ITowerSpriteManager GetTowerSpriteManager()
        {
            return _towerSpriteManager;
        }
    }
}
