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
            panelErro = new Panel();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            txtSenha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panelErro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel1.BackColor = Color.FromArgb(37, 38, 33);
            panel1.Controls.Add(panelErro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(434, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 400);
            panel1.TabIndex = 2;
            // 
            // panelErro
            // 
            panelErro.BackColor = Color.FromArgb(71, 31, 34);
            panelErro.BorderStyle = BorderStyle.FixedSingle;
            panelErro.Controls.Add(pictureBox4);
            panelErro.Controls.Add(label6);
            panelErro.Controls.Add(label5);
            panelErro.ForeColor = Color.FromArgb(166, 20, 47);
            panelErro.Location = new Point(35, 89);
            panelErro.Name = "panelErro";
            panelErro.Size = new Size(381, 77);
            panelErro.TabIndex = 8;
            panelErro.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(9, 45);
            label6.Name = "label6";
            label6.Size = new Size(367, 16);
            label6.TabIndex = 1;
            label6.Text = "O Usuário ou a senha estão incorretos. Tente novamente.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(50, 11);
            label5.Name = "label5";
            label5.Size = new Size(146, 23);
            label5.TabIndex = 0;
            label5.Text = "Falha no Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(161, 134);
            label4.Name = "label4";
            label4.Size = new Size(135, 16);
            label4.TabIndex = 7;
            label4.Text = "Entre com seu login:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.WhiteSmoke;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Inter Medium", 12F);
            btnLogin.Location = new Point(35, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(381, 45);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Continuar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Black;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.WhiteSmoke;
            txtSenha.Location = new Point(35, 282);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha...";
            txtSenha.Size = new Size(381, 30);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(35, 256);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(35, 178);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 3;
            label2.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Black;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.WhiteSmoke;
            txtUsuario.Location = new Point(35, 213);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário...";
            txtUsuario.Size = new Size(381, 30);
            txtUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(167, 98);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 1;
            label1.Text = "Bem-Vindo";
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(148, -29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(160, 160);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelErro.ResumeLayout(false);
            panelErro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtSenha;
        private Label label3;
        private Button btnLogin;
        private Label label4;
        private Panel panelErro;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox4;
    }
}