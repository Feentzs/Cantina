namespace Cantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            listViewProdutos = new ListView();
            pictureBox3 = new PictureBox();
            listViewCarrinho = new ListView();
            labelTotal = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnFinalizar = new Button();
            label1 = new Label();
            btnAdicionar = new Button();
            btnDiminuir = new Button();
            btnAumentar = new Button();
            lblQuantidade = new Label();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bolt_Finance_New__3_;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 101);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Sem_título1;
            pictureBox2.Location = new Point(13, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(454, 559);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // listViewProdutos
            // 
            listViewProdutos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewProdutos.Location = new Point(73, 195);
            listViewProdutos.Name = "listViewProdutos";
            listViewProdutos.Size = new Size(321, 280);
            listViewProdutos.TabIndex = 15;
            listViewProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Sem_título1;
            pictureBox3.Location = new Point(487, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(454, 559);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // listViewCarrinho
            // 
            listViewCarrinho.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewCarrinho.Location = new Point(531, 195);
            listViewCarrinho.Name = "listViewCarrinho";
            listViewCarrinho.Size = new Size(381, 292);
            listViewCarrinho.TabIndex = 17;
            listViewCarrinho.UseCompatibleStateImageBehavior = false;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.White;
            labelTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = Color.Black;
            labelTotal.Location = new Point(806, 490);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(106, 37);
            labelTotal.TabIndex = 18;
            labelTotal.Text = "R$0,00";
            labelTotal.Click += labelTotal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(531, 475);
            label3.Name = "label3";
            label3.Size = new Size(387, 15);
            label3.TabIndex = 19;
            label3.Text = "-----------------------------------------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(531, 151);
            label2.Name = "label2";
            label2.Size = new Size(126, 31);
            label2.TabIndex = 20;
            label2.Text = "Carrinho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(542, 490);
            label4.Name = "label4";
            label4.Size = new Size(89, 37);
            label4.TabIndex = 21;
            label4.Text = "Total:";
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.White;
            btnFinalizar.BackgroundImage = (Image)resources.GetObject("btnFinalizar.BackgroundImage");
            btnFinalizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnFinalizar.FlatAppearance.BorderColor = Color.White;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFinalizar.FlatAppearance.MouseOverBackColor = Color.White;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Location = new Point(542, 550);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(370, 63);
            btnFinalizar.TabIndex = 22;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click_1;
            btnFinalizar.MouseEnter += btnFinalizar_MouseEnter;
            btnFinalizar.MouseLeave += btnFinalizar_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 151);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 23;
            label1.Text = "Produtos";
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
            btnAdicionar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(244, 486);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(207, 63);
            btnAdicionar.TabIndex = 24;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click_1;
            btnAdicionar.MouseEnter += btnAdicionar_MouseEnter;
            btnAdicionar.MouseLeave += btnAdicionar_MouseLeave;
            // 
            // btnDiminuir
            // 
            btnDiminuir.BackColor = Color.White;
            btnDiminuir.BackgroundImageLayout = ImageLayout.Stretch;
            btnDiminuir.FlatAppearance.BorderColor = Color.Black;
            btnDiminuir.FlatAppearance.MouseDownBackColor = Color.Black;
            btnDiminuir.FlatAppearance.MouseOverBackColor = Color.Black;
            btnDiminuir.FlatStyle = FlatStyle.Flat;
            btnDiminuir.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiminuir.ForeColor = Color.Black;
            btnDiminuir.Image = (Image)resources.GetObject("btnDiminuir.Image");
            btnDiminuir.Location = new Point(68, 500);
            btnDiminuir.Name = "btnDiminuir";
            btnDiminuir.RightToLeft = RightToLeft.No;
            btnDiminuir.Size = new Size(28, 30);
            btnDiminuir.TabIndex = 25;
            btnDiminuir.UseVisualStyleBackColor = false;
            btnDiminuir.Click += btnDiminuir_Click_1;
            btnDiminuir.MouseEnter += btnDiminuir_MouseEnter;
            btnDiminuir.MouseLeave += btnDiminuir_MouseLeave;
            // 
            // btnAumentar
            // 
            btnAumentar.BackColor = Color.White;
            btnAumentar.FlatAppearance.BorderColor = Color.Black;
            btnAumentar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnAumentar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAumentar.FlatStyle = FlatStyle.Flat;
            btnAumentar.ForeColor = SystemColors.ControlText;
            btnAumentar.Image = (Image)resources.GetObject("btnAumentar.Image");
            btnAumentar.Location = new Point(169, 500);
            btnAumentar.Name = "btnAumentar";
            btnAumentar.Size = new Size(28, 30);
            btnAumentar.TabIndex = 26;
            btnAumentar.UseVisualStyleBackColor = false;
            btnAumentar.Click += btnAumentar_Click_1;
            btnAumentar.MouseEnter += btnAumentar_MouseEnter;
            btnAumentar.MouseLeave += btnAumentar_MouseLeave;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.White;
            lblQuantidade.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(124, 505);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(20, 25);
            lblQuantidade.TabIndex = 27;
            lblQuantidade.Text = "1";
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.White;
            btnRemover.BackgroundImage = Properties.Resources.Sem_título__2_;
            btnRemover.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemover.FlatAppearance.BorderColor = Color.White;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatAppearance.MouseDownBackColor = Color.White;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.White;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(244, 568);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(207, 63);
            btnRemover.TabIndex = 28;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click_1;
            btnRemover.MouseEnter += btnRemover_MouseEnter;
            btnRemover.MouseLeave += btnRemover_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(995, 692);
            Controls.Add(btnRemover);
            Controls.Add(lblQuantidade);
            Controls.Add(btnAumentar);
            Controls.Add(btnDiminuir);
            Controls.Add(btnAdicionar);
            Controls.Add(label1);
            Controls.Add(btnFinalizar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(labelTotal);
            Controls.Add(listViewCarrinho);
            Controls.Add(pictureBox3);
            Controls.Add(listViewProdutos);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCantina";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListView listViewProdutos;
        private PictureBox pictureBox3;
        private ListView listViewCarrinho;
        private Label labelTotal;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnFinalizar;
        private Label label1;
        private Button btnAdicionar;
        private Button btnDiminuir;
        private Button btnAumentar;
        private Label lblQuantidade;
        private Button btnRemover;
    }
}
