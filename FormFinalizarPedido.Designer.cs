namespace Cantina
{
    partial class FormFinalizarPedido
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
            lblNome = new Label();
            txtNomeCliente = new TextBox();
            lblValorRecebido = new Label();
            txtValorRecebido = new TextBox();
            lblValorTroco = new Label();
            btnConfirmar = new Button();
            btnDinheiro = new Button();
            btnDebito = new Button();
            btnCredito = new Button();
            btnPix = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            insiravalor = new PictureBox();
            trocoimg = new PictureBox();
            lblTroco = new Label();
            listViewResumo = new ListView();
            lblTotal = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)insiravalor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trocoimg).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(27, 123);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(138, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do Cliente:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = Color.White;
            txtNomeCliente.BorderStyle = BorderStyle.None;
            txtNomeCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(29, 158);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "Digite o nome do cliente...";
            txtNomeCliente.Size = new Size(217, 18);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorRecebido.Location = new Point(19, 421);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(125, 21);
            lblValorRecebido.TabIndex = 3;
            lblValorRecebido.Text = "Valor Recebido:";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.BorderStyle = BorderStyle.None;
            txtValorRecebido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorRecebido.Location = new Point(150, 424);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PlaceholderText = "Insira o Valor...";
            txtValorRecebido.Size = new Size(139, 18);
            txtValorRecebido.TabIndex = 4;
            txtValorRecebido.TextChanged += txtValorRecebido_TextChanged;
            // 
            // lblValorTroco
            // 
            lblValorTroco.AutoSize = true;
            lblValorTroco.BackColor = Color.White;
            lblValorTroco.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTroco.Location = new Point(321, 500);
            lblValorTroco.Name = "lblValorTroco";
            lblValorTroco.Size = new Size(113, 37);
            lblValorTroco.TabIndex = 5;
            lblValorTroco.Text = " R$0,00";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.White;
            btnConfirmar.BackgroundImage = Properties.Resources.Semtitulo2;
            btnConfirmar.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirmar.FlatAppearance.BorderColor = Color.White;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseDownBackColor = Color.White;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.White;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(518, 482);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(358, 59);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar Pedido";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click_1;
            btnConfirmar.MouseEnter += btnConfirmar_MouseEnter;
            btnConfirmar.MouseLeave += btnConfirmar_MouseLeave;
            // 
            // btnDinheiro
            // 
            btnDinheiro.BackColor = Color.White;
            btnDinheiro.FlatAppearance.BorderSize = 0;
            btnDinheiro.FlatStyle = FlatStyle.Flat;
            btnDinheiro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDinheiro.Location = new Point(19, 339);
            btnDinheiro.Name = "btnDinheiro";
            btnDinheiro.Size = new Size(135, 49);
            btnDinheiro.TabIndex = 8;
            btnDinheiro.Text = "Dinheiro";
            btnDinheiro.UseVisualStyleBackColor = false;
            btnDinheiro.Click += btnDinheiro_Click;
            // 
            // btnDebito
            // 
            btnDebito.BackColor = Color.White;
            btnDebito.FlatAppearance.BorderSize = 0;
            btnDebito.FlatStyle = FlatStyle.Flat;
            btnDebito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDebito.Location = new Point(162, 264);
            btnDebito.Name = "btnDebito";
            btnDebito.Size = new Size(133, 52);
            btnDebito.TabIndex = 9;
            btnDebito.Text = "Cartão Débito";
            btnDebito.UseVisualStyleBackColor = false;
            btnDebito.Click += btnDebito_Click_1;
            // 
            // btnCredito
            // 
            btnCredito.BackColor = Color.White;
            btnCredito.FlatAppearance.BorderSize = 0;
            btnCredito.FlatStyle = FlatStyle.Flat;
            btnCredito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCredito.Location = new Point(19, 264);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(137, 52);
            btnCredito.TabIndex = 10;
            btnCredito.Text = "Cartão Crédito";
            btnCredito.UseVisualStyleBackColor = false;
            btnCredito.Click += btnCredito_Click_1;
            // 
            // btnPix
            // 
            btnPix.BackColor = Color.White;
            btnPix.FlatAppearance.BorderSize = 0;
            btnPix.FlatStyle = FlatStyle.Flat;
            btnPix.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPix.Location = new Point(162, 339);
            btnPix.Name = "btnPix";
            btnPix.Size = new Size(136, 49);
            btnPix.TabIndex = 11;
            btnPix.Text = "Pix";
            btnPix.UseVisualStyleBackColor = false;
            btnPix.Click += btnPix_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(473, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 597);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Bolt_Finance_New__3_;
            pictureBox2.Location = new Point(0, -19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 101);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 30);
            label1.Name = "label1";
            label1.Size = new Size(171, 37);
            label1.TabIndex = 14;
            label1.Text = "| Pagamento";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Semtitulo;
            pictureBox3.Location = new Point(12, 138);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(301, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 228);
            label2.Name = "label2";
            label2.Size = new Size(170, 21);
            label2.TabIndex = 16;
            label2.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(495, 30);
            label3.Name = "label3";
            label3.Size = new Size(245, 37);
            label3.TabIndex = 17;
            label3.Text = "Resumo do Pedido";
            // 
            // insiravalor
            // 
            insiravalor.Image = Properties.Resources.Semtitulo;
            insiravalor.Location = new Point(142, 405);
            insiravalor.Name = "insiravalor";
            insiravalor.Size = new Size(164, 55);
            insiravalor.SizeMode = PictureBoxSizeMode.StretchImage;
            insiravalor.TabIndex = 18;
            insiravalor.TabStop = false;
            // 
            // trocoimg
            // 
            trocoimg.Image = Properties.Resources.Semtitulo;
            trocoimg.Location = new Point(0, 466);
            trocoimg.Name = "trocoimg";
            trocoimg.Size = new Size(467, 102);
            trocoimg.SizeMode = PictureBoxSizeMode.StretchImage;
            trocoimg.TabIndex = 19;
            trocoimg.TabStop = false;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.White;
            lblTroco.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTroco.Location = new Point(29, 500);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(96, 37);
            lblTroco.TabIndex = 20;
            lblTroco.Text = "Troco:";
            // 
            // listViewResumo
            // 
            listViewResumo.BorderStyle = BorderStyle.None;
            listViewResumo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewResumo.Location = new Point(495, 84);
            listViewResumo.Name = "listViewResumo";
            listViewResumo.Size = new Size(381, 304);
            listViewResumo.TabIndex = 21;
            listViewResumo.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(770, 424);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(106, 37);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "R$0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(495, 424);
            label4.Name = "label4";
            label4.Size = new Size(89, 37);
            label4.TabIndex = 23;
            label4.Text = "Total:";
            // 
            // FormFinalizarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(900, 587);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(lblTotal);
            Controls.Add(listViewResumo);
            Controls.Add(lblTroco);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDebito);
            Controls.Add(btnDinheiro);
            Controls.Add(lblNome);
            Controls.Add(txtNomeCliente);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(btnPix);
            Controls.Add(btnCredito);
            Controls.Add(btnConfirmar);
            Controls.Add(lblValorTroco);
            Controls.Add(txtValorRecebido);
            Controls.Add(lblValorRecebido);
            Controls.Add(pictureBox1);
            Controls.Add(insiravalor);
            Controls.Add(trocoimg);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFinalizarPedido";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Finalizar Pedido";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)insiravalor).EndInit();
            ((System.ComponentModel.ISupportInitialize)trocoimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNomeCliente;
        private Label lblValorRecebido;
        private TextBox txtValorRecebido;
        private Label lblValorTroco;
        private Button btnConfirmar;
        private Button btnDinheiro;
        private Button btnDebito;
        private Button btnCredito;
        private Button btnPix;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private PictureBox insiravalor;
        private PictureBox trocoimg;
        private Label lblTroco;
        private ListView listViewResumo;
        private Label lblTotal;
        private Label label4;
    }
}