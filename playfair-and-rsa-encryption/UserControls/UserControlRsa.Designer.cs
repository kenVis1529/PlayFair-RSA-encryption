namespace playfair_and_rsa_encryption.UserControls
{
    partial class UserControlRsa
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
            btn_gen_prime_numbers = new Button();
            tb_d = new TextBox();
            tb_phi = new TextBox();
            tb_n = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_decrypt = new Button();
            btn_encrypt = new Button();
            tb_e = new TextBox();
            tb_q = new TextBox();
            tb_p = new TextBox();
            tb_output = new RichTextBox();
            tb_input = new RichTextBox();
            label5 = new Label();
            lb_plaintext = new Label();
            lb_e = new Label();
            lb_q = new Label();
            label6 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_gen_prime_numbers
            // 
            btn_gen_prime_numbers.BackColor = Color.FromArgb(0, 48, 73);
            btn_gen_prime_numbers.ForeColor = Color.Transparent;
            btn_gen_prime_numbers.Location = new Point(754, 56);
            btn_gen_prime_numbers.Name = "btn_gen_prime_numbers";
            btn_gen_prime_numbers.Size = new Size(249, 74);
            btn_gen_prime_numbers.TabIndex = 56;
            btn_gen_prime_numbers.Text = "Generate prime numbers";
            btn_gen_prime_numbers.UseVisualStyleBackColor = false;
            btn_gen_prime_numbers.Click += btn_gen_prime_numbers_Click;
            // 
            // tb_d
            // 
            tb_d.Location = new Point(199, 278);
            tb_d.Name = "tb_d";
            tb_d.ReadOnly = true;
            tb_d.Size = new Size(513, 27);
            tb_d.TabIndex = 55;
            // 
            // tb_phi
            // 
            tb_phi.Location = new Point(199, 191);
            tb_phi.Name = "tb_phi";
            tb_phi.ReadOnly = true;
            tb_phi.Size = new Size(513, 27);
            tb_phi.TabIndex = 54;
            // 
            // tb_n
            // 
            tb_n.Location = new Point(199, 148);
            tb_n.Name = "tb_n";
            tb_n.ReadOnly = true;
            tb_n.Size = new Size(513, 27);
            tb_n.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(47, 281);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 52;
            label4.Text = "Private key d";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 194);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 51;
            label3.Text = "phi(N)=(p-1)(q-1)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 151);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 50;
            label2.Text = "RSA modulus N";
            // 
            // btn_decrypt
            // 
            btn_decrypt.BackColor = Color.FromArgb(0, 48, 73);
            btn_decrypt.ForeColor = Color.Transparent;
            btn_decrypt.Location = new Point(188, 526);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(135, 47);
            btn_decrypt.TabIndex = 49;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = false;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // btn_encrypt
            // 
            btn_encrypt.BackColor = Color.FromArgb(0, 48, 73);
            btn_encrypt.ForeColor = Color.Transparent;
            btn_encrypt.Location = new Point(47, 526);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(135, 47);
            btn_encrypt.TabIndex = 48;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = false;
            btn_encrypt.Click += btn_encrypt_Click;
            // 
            // tb_e
            // 
            tb_e.Location = new Point(199, 233);
            tb_e.Name = "tb_e";
            tb_e.Size = new Size(513, 27);
            tb_e.TabIndex = 47;
            // 
            // tb_q
            // 
            tb_q.Location = new Point(199, 103);
            tb_q.Name = "tb_q";
            tb_q.Size = new Size(513, 27);
            tb_q.TabIndex = 46;
            tb_q.TextChanged += tb_p_TextChanged;
            // 
            // tb_p
            // 
            tb_p.Location = new Point(199, 60);
            tb_p.Name = "tb_p";
            tb_p.Size = new Size(513, 27);
            tb_p.TabIndex = 45;
            tb_p.TextChanged += tb_p_TextChanged;
            // 
            // tb_output
            // 
            tb_output.Location = new Point(47, 445);
            tb_output.Name = "tb_output";
            tb_output.Size = new Size(956, 53);
            tb_output.TabIndex = 44;
            tb_output.Text = "";
            // 
            // tb_input
            // 
            tb_input.Location = new Point(47, 354);
            tb_input.Name = "tb_input";
            tb_input.Size = new Size(956, 53);
            tb_input.TabIndex = 43;
            tb_input.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(47, 422);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 42;
            label5.Text = "Output";
            // 
            // lb_plaintext
            // 
            lb_plaintext.AutoSize = true;
            lb_plaintext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_plaintext.Location = new Point(47, 331);
            lb_plaintext.Name = "lb_plaintext";
            lb_plaintext.Size = new Size(79, 20);
            lb_plaintext.TabIndex = 41;
            lb_plaintext.Text = "Input text";
            // 
            // lb_e
            // 
            lb_e.AutoSize = true;
            lb_e.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_e.Location = new Point(47, 236);
            lb_e.Name = "lb_e";
            lb_e.Size = new Size(91, 20);
            lb_e.TabIndex = 40;
            lb_e.Text = "Public key e";
            // 
            // lb_q
            // 
            lb_q.AutoSize = true;
            lb_q.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_q.Location = new Point(47, 103);
            lb_q.Name = "lb_q";
            lb_q.Size = new Size(122, 20);
            lb_q.TabIndex = 39;
            lb_q.Text = "Prime number q";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(47, 63);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 38;
            label6.Text = "Prime number p";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(412, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 41);
            label1.TabIndex = 58;
            label1.Text = "RSA Encryption";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserControlRsa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btn_gen_prime_numbers);
            Controls.Add(tb_d);
            Controls.Add(tb_phi);
            Controls.Add(tb_n);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_decrypt);
            Controls.Add(btn_encrypt);
            Controls.Add(tb_e);
            Controls.Add(tb_q);
            Controls.Add(tb_p);
            Controls.Add(tb_output);
            Controls.Add(tb_input);
            Controls.Add(label5);
            Controls.Add(lb_plaintext);
            Controls.Add(lb_e);
            Controls.Add(lb_q);
            Controls.Add(label6);
            Name = "UserControlRsa";
            Size = new Size(1060, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_gen_prime_numbers;
        private TextBox tb_d;
        private TextBox tb_phi;
        private TextBox tb_n;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_decrypt;
        private Button btn_encrypt;
        private TextBox tb_e;
        private TextBox tb_q;
        private TextBox tb_p;
        private RichTextBox tb_output;
        private RichTextBox tb_input;
        private Label label5;
        private Label lb_plaintext;
        private Label lb_e;
        private Label lb_q;
        private Label label6;
        private Label label1;
    }
}
