namespace QwertySubstitutionCipher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtSimpleText = new TextBox();
            label2 = new Label();
            txtCipherText = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnClear = new Button();
            btnClose = new Button();
            titleLabel = new Label();
            subtitleLabel = new Label();
            SuspendLayout();

            // 
            // Form Background
            // 
            this.BackColor = Color.FromArgb(10, 10, 10);

            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Courier New", 20F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(0, 255, 70);
            titleLabel.Location = new Point(30, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Text = "> QWERTY CIPHER //";

            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Courier New", 8F);
            subtitleLabel.ForeColor = Color.FromArgb(0, 180, 50);
            subtitleLabel.Location = new Point(33, 58);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Text = "[ SUBSTITUTION ENCRYPTION TOOL v1.0 ]";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 255, 70);
            label1.Location = new Point(33, 90);
            label1.Name = "label1";
            label1.Text = "// PLAIN TEXT INPUT:";

            // 
            // txtSimpleText
            // 
            txtSimpleText.BackColor = Color.FromArgb(15, 25, 15);
            txtSimpleText.ForeColor = Color.FromArgb(0, 255, 70);
            txtSimpleText.Font = new Font("Courier New", 10F);
            txtSimpleText.BorderStyle = BorderStyle.FixedSingle;
            txtSimpleText.Location = new Point(33, 112);
            txtSimpleText.Multiline = true;
            txtSimpleText.Name = "txtSimpleText";
            txtSimpleText.ScrollBars = ScrollBars.Vertical;
            txtSimpleText.Size = new Size(730, 100);
            txtSimpleText.TabIndex = 1;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 255, 70);
            label2.Location = new Point(33, 228);
            label2.Name = "label2";
            label2.Text = "// CIPHER TEXT OUTPUT:";

            // 
            // txtCipherText
            // 
            txtCipherText.BackColor = Color.FromArgb(15, 25, 15);
            txtCipherText.ForeColor = Color.FromArgb(0, 255, 70);
            txtCipherText.Font = new Font("Courier New", 10F);
            txtCipherText.BorderStyle = BorderStyle.FixedSingle;
            txtCipherText.Location = new Point(33, 250);
            txtCipherText.Multiline = true;
            txtCipherText.Name = "txtCipherText";
            txtCipherText.ScrollBars = ScrollBars.Vertical;
            txtCipherText.Size = new Size(730, 100);
            txtCipherText.TabIndex = 3;

            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.FromArgb(0, 100, 30);
            btnEncrypt.ForeColor = Color.FromArgb(0, 255, 70);
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 70);
            btnEncrypt.Font = new Font("Courier New", 9F, FontStyle.Bold);
            btnEncrypt.Location = new Point(33, 375);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(110, 35);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "[ ENCRYPT ]";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;

            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.FromArgb(0, 60, 20);
            btnDecrypt.ForeColor = Color.FromArgb(0, 255, 70);
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 70);
            btnDecrypt.Font = new Font("Courier New", 9F, FontStyle.Bold);
            btnDecrypt.Location = new Point(155, 375);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(110, 35);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "[ DECRYPT ]";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;

            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(40, 30, 0);
            btnClear.ForeColor = Color.FromArgb(255, 200, 0);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(255, 200, 0);
            btnClear.Font = new Font("Courier New", 9F, FontStyle.Bold);
            btnClear.Location = new Point(277, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 35);
            btnClear.TabIndex = 6;
            btnClear.Text = "[ CLEAR ]";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(60, 10, 10);
            btnClose.ForeColor = Color.FromArgb(255, 60, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60);
            btnClose.Font = new Font("Courier New", 9F, FontStyle.Bold);
            btnClose.Location = new Point(399, 375);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 35);
            btnClose.TabIndex = 7;
            btnClose.Text = "[ EXIT ]";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleLabel);
            Controls.Add(subtitleLabel);
            Controls.Add(label1);
            Controls.Add(txtSimpleText);
            Controls.Add(label2);
            Controls.Add(txtCipherText);
            Controls.Add(btnEncrypt);
            Controls.Add(btnDecrypt);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Name = "Form1";
            Text = "QwertySubstitutionCipher";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label titleLabel;
        private Label subtitleLabel;
        private TextBox txtSimpleText;
        private TextBox txtCipherText;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnClear;
        private Button btnClose;
    }
}