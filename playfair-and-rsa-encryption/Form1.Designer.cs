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
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
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
            flowLayoutPanel1.Size = new Size(151, 593);
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
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(151, 0);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1057, 593);
            panelBody.TabIndex = 1;
            panelBody.Paint += panelBody_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 593);
            Controls.Add(panelBody);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
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
    }
}
