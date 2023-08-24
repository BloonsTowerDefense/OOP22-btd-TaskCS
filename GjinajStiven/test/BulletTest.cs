using System.Reflection;
using SkiaSharp;

namespace gjinajStiven;

[TestClass]
public class BulletTest
{
    [TestMethod]
    public void UpdatePosition_UpdatesPosition()
    {
        const string resourceName = "gjinajStiven.towersSprite.bullet.png";

        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            Assert.Fail("Failed to load the resource.");
        }


        using var dummySprite = SKBitmap.Decode(stream);
        var canvas = new SKCanvas(dummySprite);
        var bullet = new Bullet(new Position(0, 0), dummySprite);
        bullet.SetTargetPosition(new Position(100, 100));

                
        bullet.UpdatePosition(1, canvas);

                
        Assert.AreEqual(100, bullet.GetBulletPosition().GetX());
        Assert.AreEqual(100, bullet.GetBulletPosition().GetY());
    }


}