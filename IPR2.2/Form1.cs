using System.Numerics;
using System.Security.Cryptography;

namespace IPR2._2
{
    public partial class Form1 : Form
    {


        bool IsPrime(BigInteger n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (BigInteger i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        byte[] data;
        byte[] hash;
        EllipticCurve curve;
        ECDSA ecdsa;
        SHA1 hasher = SHA1.Create();

        BigInteger A;
        BigInteger B;
        BigInteger R;
        BigInteger S;
        BigInteger M;
        BigInteger K;
        BigInteger P;
        BigInteger hashNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openfileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName))
            {
                fileLabel.Text = openFileDialog.FileName;
                FileStream fs = File.OpenRead(openFileDialog.FileName);
                data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                outputBox.Text = System.Text.Encoding.Default.GetString(data);
                fs.Close();
            }
        }

        private void signatureButton_Click(object sender, EventArgs e)
        {
            try
            {

                SetupECDSAFromInput();
                Point signature = ecdsa.GetSignature(hashNumber);
                inputR.Text = signature.X.ToString();
                inputS.Text = signature.Y.ToString();
                byte[] newMessage = data.Concat(signature.X.ToByteArray()).Concat(signature.Y.ToByteArray()).ToArray();
                outputBox.AppendText("\nNew message:\n");
                outputBox.AppendText(System.Text.Encoding.Default.GetString(newMessage));
            }
            catch (Exception ex)
            {
                outputBox.Text = ex.Message;
            }
            



        }

        private void SetupECDSAFromInput()
        {
            if (data == null) throw new Exception("No opened file");
            hash = hasher.ComputeHash(data);
            hashNumber = BitConverter.ToInt64(hash, 0);
            outputBox.Text = "Hash value:\n" + hashNumber.ToString();
            A = Int64.Parse(inputA.Text);
            B = Int64.Parse(inputB.Text);
            P = Int64.Parse(inputP.Text);
            curve = new EllipticCurve(A, B,P);
            outputBox.AppendText("\nGroup order is " + curve.GroupOrder());
            M = Int64.Parse(inputM.Text);
            K = Int64.Parse(inputK.Text);

            if (curve.GroupOrder() % M != 0) { throw new ArgumentException($"Group order {curve.GroupOrder()} should be divided by M"); }
            if (M < 1 || M >= curve.P) { throw new ArgumentException("M should be between one and P (field order)"); }
            if (!IsPrime(M)) throw new ArgumentException("M is not prime");
            if (K < 1 || K > (M - 1)) throw new ArgumentException("K should be between 1 and M-1");
            Point generator = curve.FindGenerator((int)M);
            outputBox.AppendText($"\nGenerator point is {generator.ToString()}\n");
            ecdsa = new ECDSA(curve, M, K, generator);
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetupECDSAFromInput();
                R = Int64.Parse(inputR.Text);
                S = Int64.Parse(inputS.Text);
                bool success = ecdsa.VerifySignature(hashNumber, new Point(R, S));

                if (success)
                {
                    outputBox.AppendText("\n Signature is valid\n");
                }
                else
                {
                    outputBox.AppendText("\n Signature is NOT valid\n");
                }
            }
            catch (Exception ex)
            {
                outputBox.Text = ex.Message;
                
            }
        }
    }
}