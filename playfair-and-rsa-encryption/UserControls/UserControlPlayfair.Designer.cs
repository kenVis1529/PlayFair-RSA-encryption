namespace playfair_and_rsa_encryption.UserControls
{
    partial class UserControlPlayfair
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbKey = new Label();
            tbKey = new TextBox();
            lbPlainText = new Label();
            rtbPlain = new RichTextBox();
            groupBox1 = new GroupBox();
            rtbTable = new RichTextBox();
            lbEncrypted = new Label();
            rtbEncrypted = new RichTextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(384, 22);
            label1.Name = "label1";
            label1.Size = new Size(290, 41);
            label1.TabIndex = 0;
            label1.Text = "PlayFair Encryption";
            // 
            // lbKey
            // 
            lbKey.AutoSize = true;
            lbKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbKey.Location = new Point(27, 77);
            lbKey.Name = "lbKey";
            lbKey.Size = new Size(45, 28);
            lbKey.TabIndex = 1;
            lbKey.Text = "Key";
            // 
            // tbKey
            // 
            tbKey.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbKey.Location = new Point(27, 107);
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(432, 30);
            tbKey.TabIndex = 2;
            tbKey.Leave += tbKey_LostFocus;
            // 
            // lbPlainText
            // 
            lbPlainText.AutoSize = true;
            lbPlainText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPlainText.Location = new Point(27, 175);
            lbPlainText.Name = "lbPlainText";
            lbPlainText.Size = new Size(97, 28);
            lbPlainText.TabIndex = 3;
            lbPlainText.Text = "Plain text";
            // 
            // rtbPlain
            // 
            rtbPlain.Location = new Point(27, 206);
            rtbPlain.Name = "rtbPlain";
            rtbPlain.Size = new Size(432, 104);
            rtbPlain.TabIndex = 4;
            rtbPlain.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbTable);
            groupBox1.Location = new Point(616, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 269);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Key Matrix";
            // 
            // rtbTable
            // 
            rtbTable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbTable.Location = new Point(27, 28);
            rtbTable.Name = "rtbTable";
            rtbTable.ReadOnly = true;
            rtbTable.Size = new Size(347, 212);
            rtbTable.TabIndex = 10;
            rtbTable.Text = "";
            // 
            // lbEncrypted
            // 
            lbEncrypted.AutoSize = true;
            lbEncrypted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbEncrypted.Location = new Point(27, 323);
            lbEncrypted.Name = "lbEncrypted";
            lbEncrypted.Size = new Size(314, 28);
            lbEncrypted.TabIndex = 6;
            lbEncrypted.Text = "Encrypted Text or Decrypted Text";
            // 
            // rtbEncrypted
            // 
            rtbEncrypted.Location = new Point(27, 353);
            rtbEncrypted.Name = "rtbEncrypted";
            rtbEncrypted.ReadOnly = true;
            rtbEncrypted.Size = new Size(432, 104);
            rtbEncrypted.TabIndex = 7;
            rtbEncrypted.Text = "";
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.FromArgb(0, 48, 73);
            btnEncrypt.ForeColor = SystemColors.ButtonHighlight;
            btnEncrypt.Location = new Point(27, 488);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(120, 40);
            btnEncrypt.TabIndex = 8;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.FromArgb(0, 48, 73);
            btnDecrypt.ForeColor = SystemColors.ButtonHighlight;
            btnDecrypt.Location = new Point(184, 488);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(120, 40);
            btnDecrypt.TabIndex = 9;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 48, 73);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(339, 488);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // UserControlPlayfair
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClear);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(rtbEncrypted);
            Controls.Add(lbEncrypted);
            Controls.Add(groupBox1);
            Controls.Add(rtbPlain);
            Controls.Add(lbPlainText);
            Controls.Add(tbKey);
            Controls.Add(lbKey);
            Controls.Add(label1);
            Name = "UserControlPlayfair";
            Size = new Size(1060, 600);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbKey;
        private TextBox tbKey;
        private Label lbPlainText;
        private RichTextBox rtbPlain;
        private GroupBox groupBox1;
        private Label lbEncrypted;
        private RichTextBox rtbEncrypted;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private RichTextBox rtbTable;
        private Button btnClear;
    }
}
