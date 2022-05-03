using System.Numerics;

namespace IPR2._2
{
    class Point
    {
        public Point(BigInteger x, BigInteger y)
        {
            this.X = x;
            this.Y = y;
        }
        public BigInteger X { get; set; }
        public BigInteger Y { get; set; }

        public bool IsOnCurve(EllipticCurve curve)
        {
            return curve.mod(Y * Y - X * X * X - curve.A * X - curve.B, curve.P) == 0;
        }

        public override string ToString()
        {
            return $"[{this.X},{this.Y}]";
        }
    }
}
