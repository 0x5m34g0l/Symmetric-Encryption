namespace Symmetric_Encryption
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encryptPanel = new System.Windows.Forms.Panel();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOriginalText1 = new System.Windows.Forms.TextBox();
            this.decryptPanel = new System.Windows.Forms.Panel();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtOriginalText2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.encryptPanel.SuspendLayout();
            this.decryptPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptPanel
            // 
            this.encryptPanel.BackColor = System.Drawing.Color.LightGray;
            this.encryptPanel.Controls.Add(this.btnSave1);
            this.encryptPanel.Controls.Add(this.txtEncryptedText);
            this.encryptPanel.Controls.Add(this.label4);
            this.encryptPanel.Controls.Add(this.btnReset1);
            this.encryptPanel.Controls.Add(this.btnEncrypt);
            this.encryptPanel.Controls.Add(this.label3);
            this.encryptPanel.Controls.Add(this.txtOriginalText1);
            this.encryptPanel.Location = new System.Drawing.Point(12, 129);
            this.encryptPanel.Name = "encryptPanel";
            this.encryptPanel.Size = new System.Drawing.Size(402, 648);
            this.encryptPanel.TabIndex = 0;
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSave1.FlatAppearance.BorderSize = 2;
            this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.Location = new System.Drawing.Point(130, 577);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(134, 39);
            this.btnSave1.TabIndex = 8;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedText.Location = new System.Drawing.Point(12, 380);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.ReadOnly = true;
            this.txtEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncryptedText.Size = new System.Drawing.Size(373, 176);
            this.txtEncryptedText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Text After Encryption:";
            // 
            // btnReset1
            // 
            this.btnReset1.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReset1.FlatAppearance.BorderSize = 2;
            this.btnReset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset1.Location = new System.Drawing.Point(251, 261);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(134, 39);
            this.btnReset1.TabIndex = 5;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = false;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEncrypt.FlatAppearance.BorderSize = 2;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(12, 261);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(134, 39);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encryption";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Original Text:";
            // 
            // txtOriginalText1
            // 
            this.txtOriginalText1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalText1.Location = new System.Drawing.Point(12, 63);
            this.txtOriginalText1.Multiline = true;
            this.txtOriginalText1.Name = "txtOriginalText1";
            this.txtOriginalText1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginalText1.Size = new System.Drawing.Size(373, 176);
            this.txtOriginalText1.TabIndex = 0;
            // 
            // decryptPanel
            // 
            this.decryptPanel.BackColor = System.Drawing.Color.LightGray;
            this.decryptPanel.Controls.Add(this.btnSave2);
            this.decryptPanel.Controls.Add(this.txtOriginalText2);
            this.decryptPanel.Controls.Add(this.label6);
            this.decryptPanel.Controls.Add(this.btnReset2);
            this.decryptPanel.Controls.Add(this.btnDecrypt);
            this.decryptPanel.Controls.Add(this.txtDecryptedText);
            this.decryptPanel.Controls.Add(this.label5);
            this.decryptPanel.Location = new System.Drawing.Point(434, 129);
            this.decryptPanel.Name = "decryptPanel";
            this.decryptPanel.Size = new System.Drawing.Size(402, 648);
            this.decryptPanel.TabIndex = 1;
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSave2.FlatAppearance.BorderSize = 2;
            this.btnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.Location = new System.Drawing.Point(146, 577);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(134, 39);
            this.btnSave2.TabIndex = 9;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // txtOriginalText2
            // 
            this.txtOriginalText2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalText2.Location = new System.Drawing.Point(26, 380);
            this.txtOriginalText2.Multiline = true;
            this.txtOriginalText2.Name = "txtOriginalText2";
            this.txtOriginalText2.ReadOnly = true;
            this.txtOriginalText2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginalText2.Size = new System.Drawing.Size(373, 176);
            this.txtOriginalText2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Original Text:";
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReset2.FlatAppearance.BorderSize = 2;
            this.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Location = new System.Drawing.Point(258, 261);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(134, 39);
            this.btnReset2.TabIndex = 11;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDecrypt.FlatAppearance.BorderSize = 2;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(19, 261);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(134, 39);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decryption";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptedText.Location = new System.Drawing.Point(19, 63);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecryptedText.Size = new System.Drawing.Size(373, 176);
            this.txtDecryptedText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Decrypted Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(122, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(559, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Decryption";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(848, 820);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptPanel);
            this.Controls.Add(this.encryptPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Symmetric Encryption";
            this.encryptPanel.ResumeLayout(false);
            this.encryptPanel.PerformLayout();
            this.decryptPanel.ResumeLayout(false);
            this.decryptPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel encryptPanel;
        private System.Windows.Forms.Panel decryptPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginalText1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOriginalText2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

