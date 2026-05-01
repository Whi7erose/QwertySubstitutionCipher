using System;
using System.IO; // Required for file operations
using System.Windows.Forms;

namespace QwertySubstitutionCipher
{
    public partial class Form1 : Form
    {
        private const string PlainUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string CipherUpper = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private const string PlainNums = "0123456789";
        private const string CipherNums = "5678901234";

        public Form1()
        {
            InitializeComponent();
        }

        private char Encrypt(char ch)
        {
            int idx = PlainUpper.IndexOf(char.ToUpper(ch));
            if (idx >= 0) return char.IsUpper(ch) ? CipherUpper[idx] : char.ToLower(CipherUpper[idx]);

            idx = PlainNums.IndexOf(ch);
            if (idx >= 0) return CipherNums[idx];

            return ch;
        }

        private char Decrypt(char ch)
        {
            int idx = CipherUpper.IndexOf(char.ToUpper(ch));
            if (idx >= 0) return char.IsUpper(ch) ? PlainUpper[idx] : char.ToLower(PlainUpper[idx]);

            idx = CipherNums.IndexOf(ch);
            if (idx >= 0) return PlainNums[idx];

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

        // --- NEW FEATURE: LOAD FILE ---
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a Text File to Load";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read all text from the selected file and put it in the top box
                        txtSimpleText.Text = File.ReadAllText(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // --- NEW FEATURE: SAVE FILE ---
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCipherText.Text))
            {
                MessageBox.Show("There is no output text to save!", "Empty Output", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Output As";
                saveFileDialog.DefaultExt = "txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Write the contents of the bottom box to the selected file path
                        File.WriteAllText(saveFileDialog.FileName, txtCipherText.Text);
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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