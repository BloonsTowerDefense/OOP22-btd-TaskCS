using System;

namespace MartignaniDaniele.utils
{
    public class Position
    {
        private double x, y;

        public Position(double x, double y)
        {
            Set(x, y);
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public void Set(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetPosition(Position pos)
        {
            Set(pos.GetX(), pos.GetY());
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}