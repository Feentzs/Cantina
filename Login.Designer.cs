namespace Cantina
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.primary_lightning_top_98238e89;
            pictureBox1.Location = new Point(-57, -73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1512, 452);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.primary_lightning_bottom_05b25dc0;
            pictureBox2.Location = new Point(-120, 284);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1512, 452);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 25, 12);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(317, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 358);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(223, -29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(160, 160);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(243, 102);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 1;
            label1.Text = "Bem-Vindo";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(230, 255, 0);
            textBox1.Location = new Point(112, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 30);
            textBox1.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(1264, 729);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox textBox1;
    }
}