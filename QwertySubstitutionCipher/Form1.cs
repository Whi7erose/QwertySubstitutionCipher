using System;
using System.Windows.Forms;

namespace QwertySubstitutionCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSimpleText.Clear();
            txtCipherText.Clear();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSimpleText.Text))
                {
                    string b = txtSimpleText.Text;
                    string secondtxt = string.Empty;
                    foreach (char txt in b)
                    {
                        char c;
                        if (txt == 'A') { c = 'Q'; }
                        else if (txt == 'a') { c = 'q'; }
                        else if (txt == 'B') { c = 'W'; }
                        else if (txt == 'b') { c = 'w'; }
                        else if (txt == 'C') { c = 'E'; }
                        else if (txt == 'c') { c = 'e'; }
                        else if (txt == 'D') { c = 'R'; }
                        else if (txt == 'd') { c = 'r'; }
                        else if (txt == 'E') { c = 'T'; }
                        else if (txt == 'e') { c = 't'; }
                        else if (txt == 'F') { c = 'Y'; }
                        else if (txt == 'f') { c = 'y'; }
                        else if (txt == 'G') { c = 'U'; }
                        else if (txt == 'g') { c = 'u'; }
                        else if (txt == 'H') { c = 'I'; }
                        else if (txt == 'h') { c = 'i'; }
                        else if (txt == 'I') { c = 'O'; }
                        else if (txt == 'i') { c = 'o'; }
                        else if (txt == 'J') { c = 'P'; }
                        else if (txt == 'j') { c = 'p'; }
                        else if (txt == 'K') { c = 'A'; }
                        else if (txt == 'k') { c = 'a'; }
                        else if (txt == 'L') { c = 'S'; }
                        else if (txt == 'l') { c = 's'; }
                        else if (txt == 'M') { c = 'D'; }
                        else if (txt == 'm') { c = 'd'; }
                        else if (txt == 'N') { c = 'F'; }
                        else if (txt == 'n') { c = 'f'; }
                        else if (txt == 'O') { c = 'G'; }
                        else if (txt == 'o') { c = 'g'; }
                        else if (txt == 'P') { c = 'H'; }
                        else if (txt == 'p') { c = 'h'; }
                        else if (txt == 'Q') { c = 'J'; }
                        else if (txt == 'q') { c = 'j'; }
                        else if (txt == 'R') { c = 'K'; }
                        else if (txt == 'r') { c = 'k'; }
                        else if (txt == 'S') { c = 'L'; }
                        else if (txt == 's') { c = 'l'; }
                        else if (txt == 'T') { c = 'Z'; }
                        else if (txt == 't') { c = 'z'; }
                        else if (txt == 'U') { c = 'X'; }
                        else if (txt == 'u') { c = 'x'; }
                        else if (txt == 'V') { c = 'C'; }
                        else if (txt == 'v') { c = 'c'; }
                        else if (txt == 'W') { c = 'V'; }
                        else if (txt == 'w') { c = 'v'; }
                        else if (txt == 'X') { c = 'B'; }
                        else if (txt == 'x') { c = 'b'; }
                        else if (txt == 'Y') { c = 'N'; }
                        else if (txt == 'y') { c = 'n'; }
                        else if (txt == 'Z') { c = 'M'; }
                        else if (txt == 'z') { c = 'm'; }
                        else { c = txt; }
                        secondtxt += c.ToString();
                    }
                    txtCipherText.Text = secondtxt;
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
                    string b = txtCipherText.Text;
                    string secondtxt = string.Empty;
                    foreach (char txt in b)
                    {
                        char c;
                        if (txt == 'Q') { c = 'A'; }
                        else if (txt == 'q') { c = 'a'; }
                        else if (txt == 'W') { c = 'B'; }
                        else if (txt == 'w') { c = 'b'; }
                        else if (txt == 'E') { c = 'C'; }
                        else if (txt == 'e') { c = 'c'; }
                        else if (txt == 'R') { c = 'D'; }
                        else if (txt == 'r') { c = 'd'; }
                        else if (txt == 'T') { c = 'E'; }
                        else if (txt == 't') { c = 'e'; }
                        else if (txt == 'Y') { c = 'F'; }
                        else if (txt == 'y') { c = 'f'; }
                        else if (txt == 'U') { c = 'G'; }
                        else if (txt == 'u') { c = 'g'; }
                        else if (txt == 'I') { c = 'H'; }
                        else if (txt == 'i') { c = 'h'; }
                        else if (txt == 'O') { c = 'I'; }
                        else if (txt == 'o') { c = 'i'; }
                        else if (txt == 'P') { c = 'J'; }
                        else if (txt == 'p') { c = 'j'; }
                        else if (txt == 'A') { c = 'K'; }
                        else if (txt == 'a') { c = 'k'; }
                        else if (txt == 'S') { c = 'L'; }
                        else if (txt == 's') { c = 'l'; }
                        else if (txt == 'D') { c = 'M'; }
                        else if (txt == 'd') { c = 'm'; }
                        else if (txt == 'F') { c = 'N'; }
                        else if (txt == 'f') { c = 'n'; }
                        else if (txt == 'G') { c = 'O'; }
                        else if (txt == 'g') { c = 'o'; }
                        else if (txt == 'H') { c = 'P'; }
                        else if (txt == 'h') { c = 'p'; }
                        else if (txt == 'J') { c = 'Q'; }
                        else if (txt == 'j') { c = 'q'; }
                        else if (txt == 'K') { c = 'R'; }
                        else if (txt == 'k') { c = 'r'; }
                        else if (txt == 'L') { c = 'S'; }
                        else if (txt == 'l') { c = 's'; }
                        else if (txt == 'Z') { c = 'T'; }
                        else if (txt == 'z') { c = 't'; }
                        else if (txt == 'X') { c = 'U'; }
                        else if (txt == 'x') { c = 'u'; }
                        else if (txt == 'C') { c = 'V'; }
                        else if (txt == 'c') { c = 'v'; }
                        else if (txt == 'V') { c = 'W'; }
                        else if (txt == 'v') { c = 'w'; }
                        else if (txt == 'B') { c = 'X'; }
                        else if (txt == 'b') { c = 'x'; }
                        else if (txt == 'N') { c = 'Y'; }
                        else if (txt == 'n') { c = 'y'; }
                        else if (txt == 'M') { c = 'Z'; }
                        else if (txt == 'm') { c = 'z'; }
                        else { c = txt; }
                        secondtxt += c.ToString();
                    }
                    txtSimpleText.Text = secondtxt;
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
    }
}