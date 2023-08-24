using SkiaSharp;

namespace penazziRiccardo.src.map
{
    public class MapElement : IMapElement
    {
        private readonly SKBitmap _img;

        public MapElement(SKBitmap img)
        {
            _img = img;
        }

        /// <inheritdoc />
        public SKBitmap GetImg() => _img;

    }
}
