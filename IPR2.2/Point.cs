namespace IPR2._2
{
    class Point
    {
        public Point(long x, long y)
        {
            this.X = x;
            this.Y = y;
        }
        public long X { get; set; }
        public long Y { get; set; }

        public bool IsOnCurve(EllipticCurve curve)
        {
            return curve.mod(Y * Y - X * X * X - curve.A * X - curve.B, curve.P) == 0;
        }

        public override string ToString()
        {
            return $"y^2 = x^3 + {this.X}x + {this.Y}";
        }
    }
}
