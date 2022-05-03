namespace IPR2._2
{
    class ECDSA
    {
        public EllipticCurve Curve { get; set; }
        public long Q { get; set; } = 37;
        public long X { get; set; } = 1;
        public Point G { get; set; } = new Point(11, 33);
        public Point PK { get; set; }

        public ECDSA(EllipticCurve curve)
        {
            Curve = curve;
            PK = Curve.Multiplication(G, X);
        }

        public ECDSA(EllipticCurve curve, long q, long x, Point g)
        {
            Curve = curve;
            Q = q;
            X = x;
            G = g;
            PK = Curve.Multiplication(G, X);
        }

        private Random rnd = new Random();
        public Point Signature(long h)
        {
            int ek = rnd.Next((int)Q);
            Point R = Curve.Multiplication(G, ek);
            long r = Curve.mod(R.X, Q);//!!!
            long tmp = Curve.modInverse(ek, Q) * (h + X * r);
            long s = Curve.mod(tmp, Q);
            return new Point(r, s);
        }

        public bool SignatureVerification(long h, Point signature)
        {
            long r = signature.X;
            long s = signature.Y;
            long w = Curve.modInverse(s, Q);
            long u1 = Curve.mod(w * h, Q);
            long u2 = Curve.mod(w * r, Q);
            Point u1p = Curve.Multiplication(G, u1);
            Point u2q = Curve.Multiplication(PK, u2);
            Point Sum = Curve.Addition(u1p, u2q);
            return Curve.mod(Sum.X, Q) == Curve.mod(r, Q);
        }
    }
}
