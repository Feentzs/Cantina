namespace Cantina
{
    partial class TelaCozinha
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCozinha));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            flowLayoutPanelPedidos = new FlowLayoutPanel();
            btnChamar = new Button();
            btnProblema = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(243, 241, 238);
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 740);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(64, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(243, 241, 238);
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = Properties.Resources.Bolt_Finance_New__3_;
            pictureBox3.Location = new Point(44, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 101);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // flowLayoutPanelPedidos
            // 
            flowLayoutPanelPedidos.AutoSize = true;
            flowLayoutPanelPedidos.Location = new Point(420, 144);
            flowLayoutPanelPedidos.Name = "flowLayoutPanelPedidos";
            flowLayoutPanelPedidos.Size = new Size(200, 100);
            flowLayoutPanelPedidos.TabIndex = 28;
            flowLayoutPanelPedidos.MouseClick += flowLayoutPanelPedidos_MouseClick;
            // 
            // btnChamar
            // 
            btnChamar.BackColor = Color.White;
            btnChamar.BackgroundImage = (Image)resources.GetObject("btnChamar.BackgroundImage");
            btnChamar.BackgroundImageLayout = ImageLayout.Stretch;
            btnChamar.FlatAppearance.BorderColor = Color.White;
            btnChamar.FlatAppearance.BorderSize = 0;
            btnChamar.FlatAppearance.MouseDownBackColor = Color.White;
            btnChamar.FlatAppearance.MouseOverBackColor = Color.White;
            btnChamar.FlatStyle = FlatStyle.Flat;
            btnChamar.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamar.ForeColor = Color.White;
            btnChamar.Location = new Point(741, 629);
            btnChamar.Name = "btnChamar";
            btnChamar.Size = new Size(239, 59);
            btnChamar.TabIndex = 29;
            btnChamar.Text = "Chamar";
            btnChamar.UseVisualStyleBackColor = false;
            btnChamar.Click += btnChamar_Click;
            // 
            // btnProblema
            // 
            btnProblema.BackColor = Color.White;
            btnProblema.BackgroundImage = Properties.Resources.Semtitulo2;
            btnProblema.BackgroundImageLayout = ImageLayout.Stretch;
            btnProblema.FlatAppearance.BorderColor = Color.White;
            btnProblema.FlatAppearance.BorderSize = 0;
            btnProblema.FlatAppearance.MouseDownBackColor = Color.White;
            btnProblema.FlatAppearance.MouseOverBackColor = Color.White;
            btnProblema.FlatStyle = FlatStyle.Flat;
            btnProblema.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProblema.ForeColor = Color.White;
            btnProblema.Location = new Point(465, 629);
            btnProblema.Name = "btnProblema";
            btnProblema.Size = new Size(239, 59);
            btnProblema.TabIndex = 30;
            btnProblema.Text = "Remover";
            btnProblema.UseVisualStyleBackColor = false;
            btnProblema.Click += btnProblema_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // TelaCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1009, 711);
            Controls.Add(btnProblema);
            Controls.Add(btnChamar);
            Controls.Add(flowLayoutPanelPedidos);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "TelaCozinha";
            Text = "TelaCozinha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowLayoutPanelPedidos;
        private Button btnChamar;
        private Button btnProblema;
        private System.Windows.Forms.Timer timer1;
    }
}