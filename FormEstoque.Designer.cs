namespace Cantina
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            txtProduto = new TextBox();
            txtPreco = new TextBox();
            btnRemover = new Button();
            Estoque = new Panel();
            btnEditar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            txtBuscar = new TextBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            btnSalvar = new Button();
            btnNovoProduto = new Button();
            flowLayoutPanelEstoque = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(827, 85);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(100, 23);
            txtProduto.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(840, 136);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 2;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(852, 187);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // Estoque
            // 
            Estoque.Controls.Add(btnEditar);
            Estoque.Controls.Add(label5);
            Estoque.Controls.Add(label4);
            Estoque.Controls.Add(label3);
            Estoque.Controls.Add(label2);
            Estoque.Controls.Add(pictureBox5);
            Estoque.Controls.Add(txtBuscar);
            Estoque.Controls.Add(pictureBox4);
            Estoque.Controls.Add(label1);
            Estoque.Controls.Add(btnSalvar);
            Estoque.Controls.Add(btnNovoProduto);
            Estoque.Controls.Add(flowLayoutPanelEstoque);
            Estoque.Controls.Add(txtProduto);
            Estoque.Controls.Add(txtPreco);
            Estoque.Controls.Add(btnRemover);
            Estoque.Location = new Point(242, 1);
            Estoque.Name = "Estoque";
            Estoque.Size = new Size(975, 829);
            Estoque.TabIndex = 7;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditar.FlatAppearance.BorderColor = Color.White;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(541, 151);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(239, 59);
            btnEditar.TabIndex = 40;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(461, 202);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 39;
            label5.Text = "Qtd";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(361, 202);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 38;
            label4.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(241, 202);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 37;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 202);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 36;
            label2.Text = "Nome";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(65, 149);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 35;
            pictureBox5.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(103, 154);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.Sem_título__1_;
            pictureBox4.Location = new Point(50, 144);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(381, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Agrandir Narrow Bold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(205, 64);
            label1.TabIndex = 28;
            label1.Text = "Estoque";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalvar.FlatAppearance.BorderColor = Color.White;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.White;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.White;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(514, 11);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(239, 59);
            btnSalvar.TabIndex = 27;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.BackColor = Color.White;
            btnNovoProduto.BackgroundImage = (Image)resources.GetObject("btnNovoProduto.BackgroundImage");
            btnNovoProduto.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovoProduto.FlatAppearance.BorderColor = Color.White;
            btnNovoProduto.FlatAppearance.BorderSize = 0;
            btnNovoProduto.FlatAppearance.MouseDownBackColor = Color.White;
            btnNovoProduto.FlatAppearance.MouseOverBackColor = Color.White;
            btnNovoProduto.FlatStyle = FlatStyle.Flat;
            btnNovoProduto.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoProduto.ForeColor = Color.White;
            btnNovoProduto.Location = new Point(514, 76);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Size = new Size(239, 59);
            btnNovoProduto.TabIndex = 25;
            btnNovoProduto.Text = "Adicionar";
            btnNovoProduto.UseVisualStyleBackColor = false;
            btnNovoProduto.Click += btnNovoProduto_Click_1;
            // 
            // flowLayoutPanelEstoque
            // 
            flowLayoutPanelEstoque.AutoScroll = true;
            flowLayoutPanelEstoque.Location = new Point(36, 225);
            flowLayoutPanelEstoque.Name = "flowLayoutPanelEstoque";
            flowLayoutPanelEstoque.Size = new Size(936, 456);
            flowLayoutPanelEstoque.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Bolt_Finance_New__3_;
            pictureBox1.Location = new Point(-8, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 101);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1215, 749);
            Controls.Add(pictureBox1);
            Controls.Add(Estoque);
            Name = "FormEstoque";
            Text = "FormEstoque";
            Estoque.ResumeLayout(false);
            Estoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtProduto;
        private TextBox txtPreco;
        private Button btnRemover;
        private Panel Estoque;
        private FlowLayoutPanel flowLayoutPanelEstoque;
        private TextBox txtBuscar;
        private Button btnNovoProduto;
        private Button btnSalvar;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEditar;
    }
}