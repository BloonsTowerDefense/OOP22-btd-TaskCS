using System.Drawing;
using System.Net.Mime;
using SkiaSharp;

namespace gjinajStiven
{
    public interface ITower
    {
        bool Upgradable(int playerMoney);

        void Update();

        int GetPrice();

        int GetUpgradePrice();

        Position GetHittingRange();

        SKBitmap GetTowerSprite();

        ITowerSpriteManager GetTowerSpriteManager();

        void SetPosition(double x, double y);
    }
}