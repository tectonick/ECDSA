using System.Numerics;

namespace IPR2._2
{
    class EllipticCurve
    {
        public BigInteger P = 43;
        public BigInteger A { get; set; } = 1;
        public BigInteger B { get; set; } = 5;

        public override string ToString()
        {
            return $"y^2 = x^3 + {this.A}x + {this.B}";
        }

        public EllipticCurve()
        {

        }

        public EllipticCurve(BigInteger a, BigInteger b)
        {
            A = a;
            B = b;  
        }
        public BigInteger mod(BigInteger a, BigInteger m)
        {
            while (a < 0)
            {
                a += m;
            }
            BigInteger result = a % m;
            return result;
        }

        public BigInteger modInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0, x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += m0;

            return x;
        }

        public Point Addition(Point point1, Point point2)
        {
            BigInteger s;
            BigInteger x;
            BigInteger y;

            if (point1.X == point2.X && point1.Y == point2.Y)
            {
                s = mod((3 * point1.X * point1.X + A) * modInverse(2 * point1.Y, P), P);
            }
            else if (point1.X == 0 && point1.Y == 0)
            {
                return point2;
            }
            else if (point2.X == 0 && point2.Y == 0)
            {
                return point2;
            }
            else if (point1.X == point2.X && mod(P - point1.Y, P) == point2.Y)
            {
                return new Point(0, 0);
            }
            else
            {
                s = mod((point1.Y - point2.Y) * modInverse(mod(point1.X - point2.X, P), P), P);
            }

            x = mod(s * s - point1.X - point2.X, P);
            y = mod(s * (point1.X - x) - point1.Y, P);
            return new Point(x, y);
        }

        public Point Multiplication(Point point, BigInteger k)
        {
            Point result = new Point(point.X, point.Y);
            for (int i = 0; i < k - 1; i++)
            {
                result = Addition(point, result);
            }
            return result;
        }
    }
}
