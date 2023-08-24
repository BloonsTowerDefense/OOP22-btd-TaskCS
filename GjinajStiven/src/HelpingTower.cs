using System;
using System.Collections.Generic;
using System.Drawing;
using SkiaSharp;

namespace gjinajStiven
{
    public class HelpingTower : ITower
    {
        private const int FunctionFactor = 5;
        private const int RangeFactor = 10;
        private const int PriceFactor = 50;

        private readonly string _towerName;
        private readonly string _function;
        private readonly int _price;
        private int _functionFactor;
        private Position _position;
        private Position _hittingRange;
        private readonly ITowerSpriteManager _towerSpriteManager;

        public HelpingTower(string towerName, string function, int price, Position position)
        {
            _towerSpriteManager = new TowerSpriteManagerImpl(towerName);
            _towerName = towerName;
            _price = price;
            _function = function;
            _functionFactor = 10;
            _position = position;
            _hittingRange = new Position(_functionFactor, _functionFactor);
        }

        public bool Upgradable(int playerMoney)
        {
            return playerMoney - _price >= 0;
        }

        public void Update()
        {
            _towerSpriteManager.Upgrade(_towerName);
            _hittingRange = new Position(_hittingRange.GetX() + RangeFactor, _hittingRange.GetY() + RangeFactor);
            _functionFactor += FunctionFactor;
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetUpgradePrice()
        {
            return _price + PriceFactor;
        }

        public Position GetHittingRange()
        {
            return _hittingRange;
        }

        public int GetFunctionFactor()
        {
            return _functionFactor;
        }

        public Position? GetPosition()
        {
            return _position;
        }

        public string GetName()
        {
            return _towerName;
        }

        public string GetFunction()
        {
            return _function;
        }

        public void SetPosition(double x, double y)
        {
            _position = new Position(x, y);
        }

        public SKBitmap GetTowerSprite()
        {
            return _towerSpriteManager.GetTowerSpriteList()[0];
        }

        public ITowerSpriteManager GetTowerSpriteManager()
        {
            return _towerSpriteManager;
        }
    }
}
