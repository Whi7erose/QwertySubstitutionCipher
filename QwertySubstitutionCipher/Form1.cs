using System;
using System.Windows.Forms;

namespace QwertySubstitutionCipher
{
    public partial class Form1 : Form
    {
        // Mapping strings - index position links plain to cipher
        private const string PlainUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string CipherUpper = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private const string PlainNums = "0123456789";
        private const string CipherNums = "5678901234";

        public Form1()
        {
            InitializeComponent();
        }

        // Encrypt a single character
        private char Encrypt(char ch)
        {
            int idx;

            // Check uppercase letters
            idx = PlainUpper.IndexOf(char.ToUpper(ch));
            if (idx >= 0)
                return char.IsUpper(ch)
                    ? CipherUpper[idx]
                    : char.ToLower(CipherUpper[idx]);

            // Check numbers
            idx = PlainNums.IndexOf(ch);
            if (idx >= 0)
                return CipherNums[idx];

            // Keep everything else unchanged (spaces, punctuation)
            return ch;
        }

        // Decrypt a single character
        private char Decrypt(char ch)
        {
            int idx;

            // Check uppercase letters
            idx = CipherUpper.IndexOf(char.ToUpper(ch));
            if (idx >= 0)
                return char.IsUpper(ch)
                    ? PlainUpper[idx]
                    : char.ToLower(PlainUpper[idx]);

            // Check numbers
            idx = CipherNums.IndexOf(ch);
            if (idx >= 0)
                return PlainNums[idx];

            // Keep everything else unchanged
            return ch;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Encrypt takes text from the TOP box and puts it in the BOTTOM box
                if (!string.IsNullOrEmpty(txtSimpleText.Text))
                {
                    string result = string.Empty;
                    foreach (char ch in txtSimpleText.Text)
                        result += Encrypt(ch).ToString();

                    txtCipherText.Text = result;
                }
                else
                {
                    MessageBox.Show("Please enter the text you want to encrypt in the top box!", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Decrypt ALSO takes text from the TOP box and puts it in the BOTTOM box
                if (!string.IsNullOrEmpty(txtSimpleText.Text))
                {
                    string result = string.Empty;
                    foreach (char ch in txtSimpleText.Text)
                        result += Decrypt(ch).ToString();

                    txtCipherText.Text = result;
                }
                else
                {
                    MessageBox.Show("Please enter the text you want to decrypt in the top box!", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSimpleText.Clear();
            txtCipherText.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}