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
                if (!string.IsNullOrEmpty(txtSimpleText.Text))
                {
                    string result = string.Empty;
                    foreach (char ch in txtSimpleText.Text)
                        result += Encrypt(ch).ToString();

                    txtCipherText.Text = result;
                }
                else
                {
                    MessageBox.Show("Please Enter the Simple Text to Encrypt!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCipherText.Text))
                {
                    string result = string.Empty;
                    foreach (char ch in txtCipherText.Text)
                        result += Decrypt(ch).ToString();

                    txtSimpleText.Text = result;
                }
                else
                {
                    MessageBox.Show("Please Enter the Cipher Text to Decrypt!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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