using SkiaSharp;

namespace gjinajStiven
{
    public class Bullet
    {
        private const double PositionFactor = 0.3;

        private readonly SKBitmap _sprite;
        private Position _startingPosition;
        private Position _targetPosition;
        private double _elapsedTime = 1;

        public Bullet(Position startingPosition, SKBitmap sprite)
        {
            _startingPosition = startingPosition;
            _sprite = sprite;
            _targetPosition = startingPosition;
        }

        public void SetTargetPosition(Position position)
        {
            _targetPosition = position;
        }

        public Position GetBulletPosition()
        {
            return _startingPosition;
        }

        public void UpdatePosition(double deltaTime, SKCanvas canvas)
        {
            var startX = _startingPosition.GetX();
            var startY = _startingPosition.GetY();
            var endX = _targetPosition.GetX();
            var endY = _targetPosition.GetY();

            var t = Math.Min(1, _elapsedTime / deltaTime);

            var currentX = startX + (endX - startX) * t;
            var currentY = startY + (endY - startY) * t;

            var trailCount = 4;

            using (var paint = new SKPaint())
            {
                for (var i = 0; i < trailCount; i++)
                {
                    var trailX = currentX - i * (endX - startX) * PositionFactor;
                    var trailY = currentY - i * (endY - startY) * PositionFactor;
                    canvas.DrawBitmap(_sprite, (float)trailX, (float)trailY, paint);
                }

                canvas.DrawBitmap(_sprite, (float)currentX, (float)currentY, paint);
                _startingPosition = new Position(currentX, currentY);
            }

            _elapsedTime += deltaTime;
        }
    }
}
