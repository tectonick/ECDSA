using System.Numerics;
using System.Security.Cryptography;

namespace IPR2._2
{
    public partial class Form1 : Form
    {

        byte[] data;
        EllipticCurve curve;
        ECDSA ecdsa;
        SHA1 hasher = SHA1.Create();
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
            byte[] hash = hasher.ComputeHash(data);
            BigInteger hashNumber = BitConverter.ToInt64(hash, 0);
            outputBox.Text = "Hash value:\n"+hashNumber.ToString();


            BigInteger A=Int64.Parse(inputA.Text);
            BigInteger B = Int64.Parse(inputB.Text);
            curve = new EllipticCurve(A,B);
            BigInteger M = Int64.Parse(inputM.Text);
            BigInteger K = Int64.Parse(inputK.Text);
            ecdsa = new ECDSA(curve, M,K);
            Point signature = ecdsa.GetSignature(hashNumber);
            inputR.Text= signature.X.ToString();
            inputS.Text = signature.Y.ToString();

        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            BigInteger R = Int64.Parse(inputR.Text);
            BigInteger S = Int64.Parse(inputS.Text);
            BigInteger A = Int64.Parse(inputA.Text);
            BigInteger B = Int64.Parse(inputB.Text);
            curve = new EllipticCurve(A, B);
            BigInteger M = Int64.Parse(inputM.Text);
            BigInteger K = Int64.Parse(inputK.Text);
            ecdsa = new ECDSA(curve, M, K);

            byte[] hash = hasher.ComputeHash(data);
            BigInteger hashNumber = BitConverter.ToInt64(hash, 0);
            outputBox.Text = "Hash value:\n" + hashNumber.ToString();
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
    }
}