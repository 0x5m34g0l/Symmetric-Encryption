using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Symmetric_Encryption
{
    public partial class Form1 : Form
    {

        private const int _KEY = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Decrypt()
        {
            string Text1 = txtDecryptedText.Text;
            string Text2 = "";
            for (int i = 0; i < Text1.Length; i++)
            {
                Text2 += Convert.ToChar((int)Text1[i] - _KEY);
            }

            txtOriginalText2.Text = Text2;
        }

        private void Encrypt()
        {
            string Text1 = txtOriginalText1.Text;
            string Text2 = "";
            for (int i = 0; i < Text1.Length; i++)
            {
                Text2 += Convert.ToChar((int)Text1[i] + _KEY);
            }

            txtEncryptedText.Text = Text2;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Encrypt();
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            txtOriginalText1.Clear();
            txtEncryptedText.Clear();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.ShowHelp = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "Save Encrypted Data";

            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtEncryptedText.Text);
                MessageBox.Show(saveFileDialog1.FileName + " Saved Successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt();
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtDecryptedText.Clear();
            txtOriginalText2.Clear();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.ShowHelp = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "Save Decrypted Data";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtOriginalText2.Text);
                MessageBox.Show(saveFileDialog1.FileName + " Saved Successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
