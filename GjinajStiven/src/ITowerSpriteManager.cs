using System.Collections.Generic;
using System.Drawing;
using SkiaSharp;

namespace gjinajStiven
{
    public interface ITowerSpriteManager
    {
        void Upgrade(string towerName);

        List<SKBitmap> GetTowerSpriteList();

        List<SKBitmap> GetUpgradeSprites(string towerName, int upgradeNumber);
    }
}