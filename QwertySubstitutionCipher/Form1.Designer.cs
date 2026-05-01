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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSimpleText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.txtSimpleText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QWERTY Encryption Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.titleLabel.Location = new System.Drawing.Point(30, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Text = "Encryption Dashboard";

            // subtitleLabel
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.subtitleLabel.Location = new System.Drawing.Point(36, 65);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Text = "QWERTY Substitution Cipher Tool v1.0";

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 110);
            this.label1.Name = "label1";
            this.label1.Text = "Input Text";

            // btnLoadFile
            this.btnLoadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadFile.FlatAppearance.BorderSize = 0;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadFile.ForeColor = System.Drawing.Color.White;
            this.btnLoadFile.Location = new System.Drawing.Point(618, 100);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(130, 30);
            this.btnLoadFile.TabIndex = 7;
            this.btnLoadFile.Text = "LOAD .TXT FILE";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);

            // txtSimpleText
            this.txtSimpleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(38)))));
            this.txtSimpleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSimpleText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSimpleText.ForeColor = System.Drawing.Color.White;
            this.txtSimpleText.Location = new System.Drawing.Point(38, 140);
            this.txtSimpleText.Multiline = true;
            this.txtSimpleText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSimpleText.Name = "txtSimpleText";
            this.txtSimpleText.Size = new System.Drawing.Size(710, 100);
            this.txtSimpleText.TabIndex = 1;

            // btnEncrypt
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(38, 255);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 45);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "ENCRYPT";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // btnDecrypt
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(180, 255);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(130, 45);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "DECRYPT";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(65)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(322, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 45);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 335);
            this.label2.Name = "label2";
            this.label2.Text = "Output Text";

            // btnSaveFile
            this.btnSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFile.FlatAppearance.BorderSize = 0;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.Location = new System.Drawing.Point(618, 325);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(130, 30);
            this.btnSaveFile.TabIndex = 8;
            this.btnSaveFile.Text = "SAVE OUTPUT";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);

            // txtCipherText
            this.txtCipherText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(38)))));
            this.txtCipherText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCipherText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCipherText.ForeColor = System.Drawing.Color.White;
            this.txtCipherText.Location = new System.Drawing.Point(38, 365);
            this.txtCipherText.Multiline = true;
            this.txtCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.ReadOnly = true;
            this.txtCipherText.Size = new System.Drawing.Size(710, 100);
            this.txtCipherText.TabIndex = 5;

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(618, 485);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "EXIT";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.TextBox txtSimpleText;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveFile;
    }
}