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
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnFinalizar = new Button();
            label1 = new Label();
            label2 = new Label();
            labelTotal = new Label();
            listViewProdutos = new ListView();
            listViewCarrinho = new ListView();
            btnDiminuir = new Button();
            btnAumentar = new Button();
            lblQuantidade = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(319, 38);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar>";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(319, 78);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "<Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(387, 142);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(116, 23);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Fechar Pedido";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 144);
            label1.Name = "label1";
            label1.Size = new Size(135, 36);
            label1.TabIndex = 5;
            label1.Text = "Produtos ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(574, 142);
            label2.Name = "label2";
            label2.Size = new Size(126, 36);
            label2.TabIndex = 6;
            label2.Text = "Carrinho";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(511, 493);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(174, 37);
            labelTotal.TabIndex = 7;
            labelTotal.Text = "Total: R$0,00";
            // 
            // listViewProdutos
            // 
            listViewProdutos.Location = new Point(61, 214);
            listViewProdutos.Name = "listViewProdutos";
            listViewProdutos.Size = new Size(322, 316);
            listViewProdutos.TabIndex = 8;
            listViewProdutos.UseCompatibleStateImageBehavior = false;
            listViewProdutos.SelectedIndexChanged += listViewProdutos_SelectedIndexChanged;
            // 
            // listViewCarrinho
            // 
            listViewCarrinho.Location = new Point(511, 181);
            listViewCarrinho.Name = "listViewCarrinho";
            listViewCarrinho.Size = new Size(271, 270);
            listViewCarrinho.TabIndex = 9;
            listViewCarrinho.UseCompatibleStateImageBehavior = false;
            // 
            // btnDiminuir
            // 
            btnDiminuir.Location = new Point(487, 38);
            btnDiminuir.Name = "btnDiminuir";
            btnDiminuir.Size = new Size(75, 23);
            btnDiminuir.TabIndex = 10;
            btnDiminuir.Text = "-";
            btnDiminuir.UseVisualStyleBackColor = true;
            btnDiminuir.Click += btnDiminuir_Click;
            // 
            // btnAumentar
            // 
            btnAumentar.Location = new Point(681, 39);
            btnAumentar.Name = "btnAumentar";
            btnAumentar.Size = new Size(75, 23);
            btnAumentar.TabIndex = 11;
            btnAumentar.Text = "+";
            btnAumentar.UseVisualStyleBackColor = true;
            btnAumentar.Click += btnAumentar_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(599, 47);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(13, 15);
            lblQuantidade.TabIndex = 12;
            lblQuantidade.Text = "1";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(841, 558);
            Controls.Add(pictureBox1);
            Controls.Add(lblQuantidade);
            Controls.Add(btnAumentar);
            Controls.Add(btnDiminuir);
            Controls.Add(listViewCarrinho);
            Controls.Add(listViewProdutos);
            Controls.Add(labelTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFinalizar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCantina";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnFinalizar;
        private Label label1;
        private Label label2;
        private Label labelTotal;
        private ListView listViewProdutos;
        private ListView listViewCarrinho;
        private Button btnDiminuir;
        private Button btnAumentar;
        private Label lblQuantidade;
        private PictureBox pictureBox1;
    }
}
