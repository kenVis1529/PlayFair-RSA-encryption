namespace playfair_and_rsa_encryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnPlayfair = new Button();
            panel5 = new Panel();
            btnRsa = new Button();
            panelBody = new Panel();
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
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 48, 73);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(151, 489);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 91);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 0;
            label1.Text = "Nhóm 21";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPlayfair);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 41);
            panel1.TabIndex = 1;
            // 
            // btnPlayfair
            // 
            btnPlayfair.FlatStyle = FlatStyle.Flat;
            btnPlayfair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayfair.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlayfair.Location = new Point(-5, -6);
            btnPlayfair.Name = "btnPlayfair";
            btnPlayfair.Padding = new Padding(20, 0, 0, 0);
            btnPlayfair.Size = new Size(159, 51);
            btnPlayfair.TabIndex = 2;
            btnPlayfair.Text = "PlayFair";
            btnPlayfair.TextAlign = ContentAlignment.MiddleLeft;
            btnPlayfair.UseVisualStyleBackColor = true;
            btnPlayfair.Click += btnPlayfair_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRsa);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(3, 147);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 41);
            panel5.TabIndex = 4;
            // 
            // btnRsa
            // 
            btnRsa.FlatStyle = FlatStyle.Flat;
            btnRsa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRsa.ImageAlign = ContentAlignment.MiddleLeft;
            btnRsa.Location = new Point(-5, -6);
            btnRsa.Name = "btnRsa";
            btnRsa.Padding = new Padding(20, 0, 0, 0);
            btnRsa.Size = new Size(159, 51);
            btnRsa.TabIndex = 2;
            btnRsa.Text = "RSA";
            btnRsa.TextAlign = ContentAlignment.MiddleLeft;
            btnRsa.UseVisualStyleBackColor = true;
            btnRsa.Click += btnRsa_Click;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(tb_d);
            panelBody.Controls.Add(tb_phi);
            panelBody.Controls.Add(tb_n);
            panelBody.Controls.Add(label4);
            panelBody.Controls.Add(label3);
            panelBody.Controls.Add(label2);
            panelBody.Controls.Add(btn_decrypt);
            panelBody.Controls.Add(btn_encrypt);
            panelBody.Controls.Add(tb_e);
            panelBody.Controls.Add(tb_q);
            panelBody.Controls.Add(tb_p);
            panelBody.Controls.Add(tb_output);
            panelBody.Controls.Add(tb_input);
            panelBody.Controls.Add(label5);
            panelBody.Controls.Add(lb_plaintext);
            panelBody.Controls.Add(lb_e);
            panelBody.Controls.Add(lb_q);
            panelBody.Controls.Add(label6);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(151, 0);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1036, 489);
            panelBody.TabIndex = 1;
            panelBody.Paint += panelBody_Paint;
            // 
            // tb_d
            // 
            tb_d.Location = new Point(836, 94);
            tb_d.Name = "tb_d";
            tb_d.ReadOnly = true;
            tb_d.Size = new Size(156, 27);
            tb_d.TabIndex = 35;
            // 
            // tb_phi
            // 
            tb_phi.Location = new Point(509, 94);
            tb_phi.Name = "tb_phi";
            tb_phi.ReadOnly = true;
            tb_phi.Size = new Size(156, 27);
            tb_phi.TabIndex = 34;
            // 
            // tb_n
            // 
            tb_n.Location = new Point(157, 94);
            tb_n.Name = "tb_n";
            tb_n.ReadOnly = true;
            tb_n.Size = new Size(156, 27);
            tb_n.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(737, 97);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 32;
            label4.Text = "Private key d";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 97);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 31;
            label3.Text = "phi(N)=(p-1)(q-1)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 97);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 30;
            label2.Text = "RSA modulus N";
            // 
            // btn_decrypt
            // 
            btn_decrypt.Location = new Point(177, 380);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(135, 47);
            btn_decrypt.TabIndex = 29;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            // 
            // btn_encrypt
            // 
            btn_encrypt.Location = new Point(36, 380);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(135, 47);
            btn_encrypt.TabIndex = 28;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            // 
            // tb_e
            // 
            tb_e.Location = new Point(836, 46);
            tb_e.Name = "tb_e";
            tb_e.Size = new Size(156, 27);
            tb_e.TabIndex = 27;
            // 
            // tb_q
            // 
            tb_q.Location = new Point(509, 46);
            tb_q.Name = "tb_q";
            tb_q.Size = new Size(156, 27);
            tb_q.TabIndex = 26;
            // 
            // tb_p
            // 
            tb_p.Location = new Point(157, 46);
            tb_p.Name = "tb_p";
            tb_p.Size = new Size(156, 27);
            tb_p.TabIndex = 25;
            // 
            // tb_output
            // 
            tb_output.Location = new Point(36, 295);
            tb_output.Name = "tb_output";
            tb_output.Size = new Size(956, 53);
            tb_output.TabIndex = 24;
            tb_output.Text = "";
            // 
            // tb_input
            // 
            tb_input.Location = new Point(36, 204);
            tb_input.Name = "tb_input";
            tb_input.Size = new Size(956, 53);
            tb_input.TabIndex = 23;
            tb_input.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 272);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 22;
            label5.Text = "Output";
            // 
            // lb_plaintext
            // 
            lb_plaintext.AutoSize = true;
            lb_plaintext.Location = new Point(36, 181);
            lb_plaintext.Name = "lb_plaintext";
            lb_plaintext.Size = new Size(72, 20);
            lb_plaintext.TabIndex = 21;
            lb_plaintext.Text = "Input text";
            // 
            // lb_e
            // 
            lb_e.AutoSize = true;
            lb_e.Location = new Point(737, 49);
            lb_e.Name = "lb_e";
            lb_e.Size = new Size(87, 20);
            lb_e.TabIndex = 20;
            lb_e.Text = "Public key e";
            // 
            // lb_q
            // 
            lb_q.AutoSize = true;
            lb_q.Location = new Point(376, 49);
            lb_q.Name = "lb_q";
            lb_q.Size = new Size(115, 20);
            lb_q.TabIndex = 19;
            lb_q.Text = "Prime number q";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 49);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 18;
            label6.Text = "Prime number p";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 489);
            Controls.Add(panelBody);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnPlayfair;
        private Panel panel2;
        private Panel panel5;
        private Button btnRsa;
        private Label label1;
        private Panel panelBody;
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
    }
}
