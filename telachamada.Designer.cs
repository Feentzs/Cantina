namespace Cantina
{
    partial class telachamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telachamada));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblClienteAtual = new Label();
            pictureBox3 = new PictureBox();
            lblRelogio = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelFila = new FlowLayoutPanel();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow Bold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(243, 241, 238);
            label1.Location = new Point(88, 200);
            label1.Name = "label1";
            label1.Size = new Size(412, 86);
            label1.TabIndex = 1;
            label1.Text = "Cliente Atual";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(243, 241, 238);
            pictureBox2.Location = new Point(576, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 488);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Agrandir Narrow Bold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(243, 241, 238);
            label2.ImageKey = "(none)";
            label2.Location = new Point(636, 200);
            label2.Name = "label2";
            label2.Size = new Size(396, 86);
            label2.TabIndex = 3;
            label2.Text = "Em Preparo:";
            // 
            // lblClienteAtual
            // 
            lblClienteAtual.Anchor = AnchorStyles.Bottom;
            lblClienteAtual.AutoEllipsis = true;
            lblClienteAtual.Font = new Font("Agrandir Narrow Bold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClienteAtual.ForeColor = Color.FromArgb(230, 255, 0);
            lblClienteAtual.Location = new Point(12, 286);
            lblClienteAtual.Name = "lblClienteAtual";
            lblClienteAtual.Size = new Size(558, 209);
            lblClienteAtual.TabIndex = 4;
            lblClienteAtual.Text = "Exemplo Cliente Atual";
            lblClienteAtual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(911, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(543, 732);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lblRelogio
            // 
            lblRelogio.AutoSize = true;
            lblRelogio.BackColor = Color.Transparent;
            lblRelogio.Font = new Font("Agrandir Narrow Bold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRelogio.ForeColor = Color.FromArgb(243, 241, 238);
            lblRelogio.ImageKey = "(none)";
            lblRelogio.Location = new Point(1114, 64);
            lblRelogio.Name = "lblRelogio";
            lblRelogio.Size = new Size(131, 49);
            lblRelogio.TabIndex = 6;
            lblRelogio.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // panelFila
            // 
            panelFila.Location = new Point(636, 308);
            panelFila.Name = "panelFila";
            panelFila.Size = new Size(396, 395);
            panelFila.TabIndex = 7;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 3000;
            timer2.Tick += timer2_Tick;
            // 
            // telachamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(1361, 729);
            Controls.Add(panelFila);
            Controls.Add(lblRelogio);
            Controls.Add(lblClienteAtual);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Name = "telachamada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telabalcão";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label lblClienteAtual;
        private PictureBox pictureBox3;
        private Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel panelFila;
        private System.Windows.Forms.Timer timer2;
    }
}