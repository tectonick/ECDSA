using System.Numerics;

namespace IPR2._2
{
    class ECDSA
    {
        public EllipticCurve Curve { get; set; }
        public BigInteger Q { get; set; } = 37;
        public BigInteger X { get; set; } = 1;
        public Point G { get; set; } = new Point(11, 33);
        public Point PK { get; set; }

        public BigInteger K { get; set; } = 1;

        public ECDSA(EllipticCurve curve)
        {
            Curve = curve;
            PK = Curve.Multiplication(G, X);
        }

        public ECDSA(EllipticCurve curve, BigInteger q, BigInteger k, Point g)
        {
            Curve = curve;
            Q = q;
            //X = x;
            G = g;
            K = k;
            PK = Curve.Multiplication(G, X);
        }

        public Point GetSignature(BigInteger hash)
        {
            Point R = Curve.Multiplication(G, K);
            BigInteger r = Curve.mod(R.X, Q);//!!!
            BigInteger tmp = Curve.modInverse(K, Q) * (hash + X * r);
            BigInteger s = Curve.mod(tmp, Q);
            return new Point(r, s);
        }

        public bool VerifySignature(BigInteger hash, Point signature)
        {
            BigInteger r = signature.X;
            BigInteger s = signature.Y;
            BigInteger w = Curve.modInverse(s, Q);
            BigInteger u1 = Curve.mod(w * hash, Q);
            BigInteger u2 = Curve.mod(w * r, Q);
            Point u1p = Curve.Multiplication(G, u1);
            Point u2q = Curve.Multiplication(PK, u2);
            Point Sum = Curve.Addition(u1p, u2q);
            return Curve.mod(Sum.X, Q) == Curve.mod(r, Q);
        }
    }
}
