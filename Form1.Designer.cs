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
            txtPesquisa = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Bolt_Finance_New__3_;
            pictureBox1.Location = new Point(27, 0);
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
            pictureBox2.Size = new Size(454, 626);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // listViewProdutos
            // 
            listViewProdutos.BorderStyle = BorderStyle.None;
            listViewProdutos.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewProdutos.Location = new Point(50, 251);
            listViewProdutos.Name = "listViewProdutos";
            listViewProdutos.Size = new Size(381, 285);
            listViewProdutos.TabIndex = 15;
            listViewProdutos.UseCompatibleStateImageBehavior = false;
            listViewProdutos.DrawItem += listViewProdutos_DrawItem;
            listViewProdutos.DrawSubItem += listViewProdutos_DrawSubItem;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Sem_título1;
            pictureBox3.Location = new Point(564, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(454, 626);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // listViewCarrinho
            // 
            listViewCarrinho.BorderStyle = BorderStyle.None;
            listViewCarrinho.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewCarrinho.Location = new Point(605, 211);
            listViewCarrinho.Name = "listViewCarrinho";
            listViewCarrinho.Size = new Size(381, 304);
            listViewCarrinho.TabIndex = 17;
            listViewCarrinho.UseCompatibleStateImageBehavior = false;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.White;
            labelTotal.Font = new Font("Inter", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = Color.Black;
            labelTotal.Location = new Point(858, 529);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(112, 33);
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
            label3.Location = new Point(605, 509);
            label3.Name = "label3";
            label3.Size = new Size(387, 15);
            label3.TabIndex = 19;
            label3.Text = "-----------------------------------------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(605, 151);
            label2.Name = "label2";
            label2.Size = new Size(126, 36);
            label2.TabIndex = 20;
            label2.Text = "Carrinho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Inter", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(605, 529);
            label4.Name = "label4";
            label4.Size = new Size(90, 33);
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
            btnFinalizar.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Location = new Point(605, 611);
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
            label1.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 151);
            label1.Name = "label1";
            label1.Size = new Size(130, 36);
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
            btnAdicionar.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(18, 651);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(239, 59);
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
            btnDiminuir.FlatAppearance.BorderColor = Color.White;
            btnDiminuir.FlatAppearance.BorderSize = 0;
            btnDiminuir.FlatAppearance.MouseDownBackColor = Color.White;
            btnDiminuir.FlatAppearance.MouseOverBackColor = Color.White;
            btnDiminuir.FlatStyle = FlatStyle.Flat;
            btnDiminuir.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiminuir.ForeColor = Color.Black;
            btnDiminuir.Image = Properties.Resources.menos;
            btnDiminuir.Location = new Point(48, 595);
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
            btnAumentar.FlatAppearance.BorderColor = Color.White;
            btnAumentar.FlatAppearance.BorderSize = 0;
            btnAumentar.FlatAppearance.MouseDownBackColor = Color.White;
            btnAumentar.FlatAppearance.MouseOverBackColor = Color.White;
            btnAumentar.FlatStyle = FlatStyle.Flat;
            btnAumentar.ForeColor = Color.White;
            btnAumentar.Image = Properties.Resources.mais;
            btnAumentar.Location = new Point(161, 594);
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
            lblQuantidade.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(110, 599);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(18, 23);
            lblQuantidade.TabIndex = 27;
            lblQuantidade.Text = "1";
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.White;
            btnRemover.BackgroundImage = (Image)resources.GetObject("btnRemover.BackgroundImage");
            btnRemover.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemover.FlatAppearance.BorderColor = Color.White;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatAppearance.MouseDownBackColor = Color.White;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.White;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(364, 638);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(82, 72);
            btnRemover.TabIndex = 28;
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click_1;
            btnRemover.MouseEnter += btnRemover_MouseEnter;
            btnRemover.MouseLeave += btnRemover_MouseLeave;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = Color.FromArgb(243, 241, 238);
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(104, 209);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar produto...";
            txtPesquisa.Size = new Size(306, 23);
            txtPesquisa.TabIndex = 29;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(50, 195);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(381, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = Properties.Resources.image__3_;
            pictureBox6.Location = new Point(18, 574);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(203, 71);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 553);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 33;
            label5.Text = "Quantidade";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(71, 204);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1030, 749);
            Controls.Add(pictureBox5);
            Controls.Add(label5);
            Controls.Add(btnRemover);
            Controls.Add(btnDiminuir);
            Controls.Add(btnAumentar);
            Controls.Add(lblQuantidade);
            Controls.Add(btnAdicionar);
            Controls.Add(pictureBox6);
            Controls.Add(txtPesquisa);
            Controls.Add(pictureBox4);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private TextBox txtPesquisa;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Label label5;
        private PictureBox pictureBox5;
    }
}
