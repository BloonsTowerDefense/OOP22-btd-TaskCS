using System.Reflection;
using SkiaSharp;

namespace gjinajStiven;
    public class TowerSpriteManagerImpl : ITowerSpriteManager
    {
        private readonly List<SKBitmap> _spriteList = new();
        private Dictionary<string, string?> _towerResourceMap;

        public TowerSpriteManagerImpl(string towerName)
        {
            _towerResourceMap = new Dictionary<string, string?>();
            TowerResourceMap();
            SetTowerSprites(towerName, 0);
        }

        private void TowerResourceMap()
        {
            _towerResourceMap = new Dictionary<string, string?>
            {
                { "blackAdam", "gjinajStiven.towersSprite.blackAdam." },
                { "deadColossus", "gjinajStiven.towersSprite.deadColossus." },
                { "voldelife", "gjinajStiven.towersSprite.voldelife." },
                { "powerEnhancer", "gjinajStiven.towersSprite.powerEnhancer." },
                { "rangeEnhancer", "gjinajStiven.towersSprite.rangeEnhancer." }
            };
        }

        private void SetTowerSprites(string towerName, int upgradeNumber)
        {
            _spriteList.Clear();
            if (!_towerResourceMap.TryGetValue(towerName, out var towerPath)) return;
            for (var i = 0; i < 2; i++)
            {
                try
                {
                    var stream = Assembly.GetExecutingAssembly()
                        .GetManifestResourceStream($"{towerPath}Upgrade{upgradeNumber}.sprite{i}.png");
                    var sprite = SKBitmap.Decode(stream);
                    _spriteList.Add(sprite);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        public List<SKBitmap> GetUpgradeSprites(string towerName, int upgradeNumber)
        {
            List<SKBitmap> sprites = new();
            if (!_towerResourceMap.TryGetValue(towerName, out var towerPath)) return sprites;
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    var stream = Assembly.GetExecutingAssembly()
                        .GetManifestResourceStream($"{towerPath}Upgrade{upgradeNumber}/sprite{i}.png");
                    var sprite = SKBitmap.Decode(stream);
                    _spriteList.Add(sprite);                    }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            return sprites;
        }

        public void Upgrade(string towerName)
        {
            SetTowerSprites(towerName, 1);
        }

        public List<SKBitmap> GetTowerSpriteList()
        {
            return _spriteList;
        }
    }