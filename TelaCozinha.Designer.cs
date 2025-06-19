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
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblFinalizados = new Label();
            lblEmPreparo = new Label();
            lblMaisPedido = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelPedidos
            // 
            flowLayoutPanelPedidos.AutoScroll = true;
            flowLayoutPanelPedidos.Location = new Point(12, 154);
            flowLayoutPanelPedidos.Name = "flowLayoutPanelPedidos";
            flowLayoutPanelPedidos.Size = new Size(886, 443);
            flowLayoutPanelPedidos.TabIndex = 28;
            flowLayoutPanelPedidos.MouseClick += flowLayoutPanelPedidos_MouseClick;
            // 
            // btnChamar
            // 
            btnChamar.BackColor = Color.FromArgb(243, 241, 238);
            btnChamar.BackgroundImage = Properties.Resources.vai;
            btnChamar.BackgroundImageLayout = ImageLayout.Stretch;
            btnChamar.FlatAppearance.BorderColor = Color.White;
            btnChamar.FlatAppearance.BorderSize = 0;
            btnChamar.FlatAppearance.MouseDownBackColor = Color.White;
            btnChamar.FlatAppearance.MouseOverBackColor = Color.White;
            btnChamar.FlatStyle = FlatStyle.Flat;
            btnChamar.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamar.ForeColor = Color.Black;
            btnChamar.Location = new Point(458, 629);
            btnChamar.Name = "btnChamar";
            btnChamar.Size = new Size(239, 59);
            btnChamar.TabIndex = 29;
            btnChamar.Text = "Chamar";
            btnChamar.UseVisualStyleBackColor = false;
            btnChamar.Click += btnChamar_Click;
            // 
            // btnProblema
            // 
            btnProblema.BackColor = Color.FromArgb(243, 241, 238);
            btnProblema.BackgroundImage = (Image)resources.GetObject("btnProblema.BackgroundImage");
            btnProblema.BackgroundImageLayout = ImageLayout.Stretch;
            btnProblema.FlatAppearance.BorderColor = Color.White;
            btnProblema.FlatAppearance.BorderSize = 0;
            btnProblema.FlatAppearance.MouseDownBackColor = Color.White;
            btnProblema.FlatAppearance.MouseOverBackColor = Color.White;
            btnProblema.FlatStyle = FlatStyle.Flat;
            btnProblema.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProblema.ForeColor = Color.FromArgb(202, 196, 183);
            btnProblema.Location = new Point(184, 614);
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
            pictureBox2.Size = new Size(217, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Sem_título__1_1;
            pictureBox3.Location = new Point(922, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(98, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow Bold", 24F, FontStyle.Bold);
            label1.Location = new Point(922, 234);
            label1.Name = "label1";
            label1.Size = new Size(135, 43);
            label1.TabIndex = 34;
            label1.Text = "Cozinha";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(901, -7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(303, 168);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(904, 546);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(300, 171);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 36;
            pictureBox5.TabStop = false;
            // 
            // lblFinalizados
            // 
            lblFinalizados.AutoSize = true;
            lblFinalizados.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalizados.Location = new Point(922, 328);
            lblFinalizados.Name = "lblFinalizados";
            lblFinalizados.Size = new Size(168, 23);
            lblFinalizados.TabIndex = 37;
            lblFinalizados.Text = "Pedidos Prontos:";
            // 
            // lblEmPreparo
            // 
            lblEmPreparo.AutoSize = true;
            lblEmPreparo.BackColor = Color.FromArgb(17, 25, 12);
            lblEmPreparo.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmPreparo.ForeColor = SystemColors.ControlLightLight;
            lblEmPreparo.Location = new Point(922, 291);
            lblEmPreparo.Name = "lblEmPreparo";
            lblEmPreparo.Size = new Size(57, 23);
            lblEmPreparo.TabIndex = 38;
            lblEmPreparo.Text = "Total";
            // 
            // lblMaisPedido
            // 
            lblMaisPedido.AutoSize = true;
            lblMaisPedido.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaisPedido.Location = new Point(922, 363);
            lblMaisPedido.Name = "lblMaisPedido";
            lblMaisPedido.Size = new Size(168, 23);
            lblMaisPedido.TabIndex = 39;
            lblMaisPedido.Text = "Pedidos Prontos:";
            // 
            // TelaCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1203, 711);
            Controls.Add(lblMaisPedido);
            Controls.Add(lblEmPreparo);
            Controls.Add(lblFinalizados);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnProblema);
            Controls.Add(btnChamar);
            Controls.Add(flowLayoutPanelPedidos);
            Controls.Add(pictureBox4);
            Name = "TelaCozinha";
            Text = "TelaCozinha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelPedidos;
        private Button btnChamar;
        private Button btnProblema;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblFinalizados;
        private Label lblEmPreparo;
        private Label lblMaisPedido;
    }
}