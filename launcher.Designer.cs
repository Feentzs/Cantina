namespace Cantina
{
    partial class launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(launcher));
            btnAdicionar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.White;
            btnAdicionar.BackgroundImage = (Image)resources.GetObject("btnAdicionar.BackgroundImage");
            btnAdicionar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicionar.FlatAppearance.BorderColor = Color.White;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.White;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.White;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(481, 165);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(239, 59);
            btnAdicionar.TabIndex = 25;
            btnAdicionar.Text = " Vendas";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            btnAdicionar.MouseEnter += btnAdicionar_MouseEnter;
            btnAdicionar.MouseLeave += btnAdicionar_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Bolt_Finance_New__3_;
            pictureBox1.Location = new Point(2, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 101);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 42);
            label1.Name = "label1";
            label1.Size = new Size(105, 33);
            label1.TabIndex = 27;
            label1.Text = "| Teste";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(481, 230);
            button1.Name = "button1";
            button1.Size = new Size(239, 59);
            button1.TabIndex = 28;
            button1.Text = "Chamada";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Semtitulo;
            pictureBox2.Location = new Point(444, -47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(315, 582);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(481, 295);
            button2.Name = "button2";
            button2.Size = new Size(239, 59);
            button2.TabIndex = 30;
            button2.Text = "Cozinha";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Agrandir Narrow Bold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 99);
            label2.Name = "label2";
            label2.Size = new Size(233, 26);
            label2.TabIndex = 31;
            label2.Text = "Selecione a Tela Desejada:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Adobe_Express___file;
            pictureBox3.Location = new Point(44, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(328, 336);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(481, 360);
            button3.Name = "button3";
            button3.Size = new Size(239, 59);
            button3.TabIndex = 33;
            button3.Text = "Balcão";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // launcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "launcher";
            Text = "launcher";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label2;
        private PictureBox pictureBox3;
        private Button button3;
    }
}