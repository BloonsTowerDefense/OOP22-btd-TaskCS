using SkiaSharp;

namespace penazziRiccardo.src.map
{
    /// <summary>
    /// This class implements the <see cref="IMapElement"/> interface.
    /// It represents an element of the map.
    /// </summary>
    public class MapElement : IMapElement
    {
        private readonly SKBitmap _img;

        /// <summary>
        /// Standard constructor.
        /// </summary>
        /// <param name="img">Image to be saved and then displayed.</param>
        public MapElement(SKBitmap img)
        {
            _img = img;
        }

        /// <inheritdoc />
        public SKBitmap GetImg() => _img;

    }
}
