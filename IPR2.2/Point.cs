using System.Numerics;

namespace IPR2._2
{
    class Point
    {
        public const bool IDENTITY=true;
        public Point(BigInteger x, BigInteger y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point(bool isIdentity)
        {
            Identity = isIdentity;
        }
        public bool Identity { get; private set; }

        public bool IsIdentity()
        {
            return Identity;
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
