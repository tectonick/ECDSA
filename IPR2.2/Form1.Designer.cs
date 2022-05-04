namespace IPR2._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button openfileButton;
            this.labelA = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.ellipticLabel = new System.Windows.Forms.Label();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.inputM = new System.Windows.Forms.TextBox();
            this.labelM = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.inputK = new System.Windows.Forms.TextBox();
            this.signatureButton = new System.Windows.Forms.Button();
            this.verifyButton = new System.Windows.Forms.Button();
            this.labelS = new System.Windows.Forms.Label();
            this.inputS = new System.Windows.Forms.TextBox();
            this.inputR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.signatureLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileLabel = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.inputP = new System.Windows.Forms.TextBox();
            openfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openfileButton
            // 
            openfileButton.Location = new System.Drawing.Point(393, 354);
            openfileButton.Name = "openfileButton";
            openfileButton.Size = new System.Drawing.Size(115, 23);
            openfileButton.TabIndex = 19;
            openfileButton.Text = "Open file";
            openfileButton.UseVisualStyleBackColor = true;
            openfileButton.Click += new System.EventHandler(this.openfileButton_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(17, 379);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(15, 15);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A";
            this.labelA.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(38, 376);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(115, 23);
            this.inputA.TabIndex = 1;
            this.inputA.Text = "1";
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(38, 408);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(115, 23);
            this.inputB.TabIndex = 2;
            this.inputB.Text = "5";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(18, 416);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 15);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B";
            // 
            // ellipticLabel
            // 
            this.ellipticLabel.AutoSize = true;
            this.ellipticLabel.Location = new System.Drawing.Point(18, 344);
            this.ellipticLabel.Name = "ellipticLabel";
            this.ellipticLabel.Size = new System.Drawing.Size(136, 15);
            this.ellipticLabel.TabIndex = 4;
            this.ellipticLabel.Text = "Elliptic curve parameters";
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.Location = new System.Drawing.Point(186, 344);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(123, 15);
            this.algorithmLabel.TabIndex = 5;
            this.algorithmLabel.Text = "Algorithm parameters";
            // 
            // inputM
            // 
            this.inputM.Location = new System.Drawing.Point(240, 376);
            this.inputM.Name = "inputM";
            this.inputM.Size = new System.Drawing.Size(115, 23);
            this.inputM.TabIndex = 6;
            this.inputM.Text = "37";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(173, 376);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(52, 15);
            this.labelM.TabIndex = 7;
            this.labelM.Text = "Prime M";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(173, 416);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(61, 15);
            this.labelK.TabIndex = 8;
            this.labelK.Text = "Random k";
            // 
            // inputK
            // 
            this.inputK.Location = new System.Drawing.Point(240, 408);
            this.inputK.Name = "inputK";
            this.inputK.Size = new System.Drawing.Size(115, 23);
            this.inputK.TabIndex = 9;
            this.inputK.Text = "3";
            // 
            // signatureButton
            // 
            this.signatureButton.Location = new System.Drawing.Point(393, 383);
            this.signatureButton.Name = "signatureButton";
            this.signatureButton.Size = new System.Drawing.Size(115, 23);
            this.signatureButton.TabIndex = 10;
            this.signatureButton.Text = "Signature";
            this.signatureButton.UseVisualStyleBackColor = true;
            this.signatureButton.Click += new System.EventHandler(this.signatureButton_Click);
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(393, 412);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(115, 23);
            this.verifyButton.TabIndex = 11;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(384, 97);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(13, 15);
            this.labelS.TabIndex = 15;
            this.labelS.Text = "S";
            // 
            // inputS
            // 
            this.inputS.Location = new System.Drawing.Point(404, 89);
            this.inputS.Name = "inputS";
            this.inputS.Size = new System.Drawing.Size(115, 23);
            this.inputS.TabIndex = 14;
            // 
            // inputR
            // 
            this.inputR.Location = new System.Drawing.Point(404, 57);
            this.inputR.Name = "inputR";
            this.inputR.Size = new System.Drawing.Size(115, 23);
            this.inputR.TabIndex = 13;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(383, 60);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(14, 15);
            this.labelR.TabIndex = 12;
            this.labelR.Text = "R";
            // 
            // signatureLabel
            // 
            this.signatureLabel.AutoSize = true;
            this.signatureLabel.Location = new System.Drawing.Point(393, 33);
            this.signatureLabel.Name = "signatureLabel";
            this.signatureLabel.Size = new System.Drawing.Size(57, 15);
            this.signatureLabel.TabIndex = 16;
            this.signatureLabel.Text = "Signature";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 57);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(358, 262);
            this.outputBox.TabIndex = 17;
            this.outputBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Results";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = ".";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(12, 33);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(42, 15);
            this.fileLabel.TabIndex = 20;
            this.fileLabel.Text = "No file";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(393, 278);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(81, 15);
            this.labelP.TabIndex = 22;
            this.labelP.Text = "Field order (P)";
            // 
            // inputP
            // 
            this.inputP.Location = new System.Drawing.Point(393, 296);
            this.inputP.Name = "inputP";
            this.inputP.Size = new System.Drawing.Size(115, 23);
            this.inputP.TabIndex = 21;
            this.inputP.Text = "43";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.inputP);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(openfileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.signatureLabel);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.inputS);
            this.Controls.Add(this.inputR);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.signatureButton);
            this.Controls.Add(this.inputK);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.inputM);
            this.Controls.Add(this.algorithmLabel);
            this.Controls.Add(this.ellipticLabel);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelA;
        private TextBox inputA;
        private TextBox inputB;
        private Label labelB;
        private Label ellipticLabel;
        private Label algorithmLabel;
        private TextBox inputM;
        private Label labelM;
        private Label labelK;
        private TextBox inputK;
        private Button signatureButton;
        private Button verifyButton;
        private Label labelS;
        private TextBox inputS;
        private TextBox inputR;
        private Label labelR;
        private Label signatureLabel;
        private RichTextBox outputBox;
        private Label label1;
        private OpenFileDialog openFileDialog;
        private Label fileLabel;
        private Label labelP;
        private TextBox inputP;
    }
}