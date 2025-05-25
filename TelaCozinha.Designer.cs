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
            flowLayoutPanelPedidos = new FlowLayoutPanel();
            btnChamar = new Button();
            btnProblema = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelPedidos
            // 
            flowLayoutPanelPedidos.AutoScroll = true;
            flowLayoutPanelPedidos.Location = new Point(12, 154);
            flowLayoutPanelPedidos.Name = "flowLayoutPanelPedidos";
            flowLayoutPanelPedidos.Size = new Size(930, 443);
            flowLayoutPanelPedidos.TabIndex = 28;
            flowLayoutPanelPedidos.MouseClick += flowLayoutPanelPedidos_MouseClick;
            // 
            // btnChamar
            // 
            btnChamar.BackColor = Color.FromArgb(17, 25, 12);
            btnChamar.BackgroundImage = Properties.Resources.vai;
            btnChamar.BackgroundImageLayout = ImageLayout.Stretch;
            btnChamar.FlatAppearance.BorderColor = Color.White;
            btnChamar.FlatAppearance.BorderSize = 0;
            btnChamar.FlatAppearance.MouseDownBackColor = Color.White;
            btnChamar.FlatAppearance.MouseOverBackColor = Color.White;
            btnChamar.FlatStyle = FlatStyle.Flat;
            btnChamar.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamar.ForeColor = Color.Black;
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
            btnProblema.BackColor = Color.FromArgb(17, 25, 12);
            btnProblema.BackgroundImage = (Image)resources.GetObject("btnProblema.BackgroundImage");
            btnProblema.BackgroundImageLayout = ImageLayout.Stretch;
            btnProblema.FlatAppearance.BorderColor = Color.White;
            btnProblema.FlatAppearance.BorderSize = 0;
            btnProblema.FlatAppearance.MouseDownBackColor = Color.White;
            btnProblema.FlatAppearance.MouseOverBackColor = Color.White;
            btnProblema.FlatStyle = FlatStyle.Flat;
            btnProblema.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProblema.ForeColor = Color.FromArgb(202, 196, 183);
            btnProblema.Location = new Point(458, 616);
            btnProblema.Name = "btnProblema";
            btnProblema.Size = new Size(239, 85);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Bolt_Finance_New__3_;
            pictureBox2.Location = new Point(1, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // TelaCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 122, 106);
            ClientSize = new Size(1203, 711);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnProblema);
            Controls.Add(btnChamar);
            Controls.Add(flowLayoutPanelPedidos);
            Name = "TelaCozinha";
            Text = "TelaCozinha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelPedidos;
        private Button btnChamar;
        private Button btnProblema;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}