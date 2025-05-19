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
            btnCredito = new Button();
            btnPix = new Button();
            btnDebito = new Button();
            btnDinheiro = new Button();
            btnConfirmar = new Button();
            lblTotal = new Label();
            lblTrocoTexto = new Label();
            lblTrocoValor = new Label();
            label4 = new Label();
            label5 = new Label();
            txtValorRecebido = new TextBox();
            txtNomeCliente = new TextBox();
            listViewResumo = new ListView();
            SuspendLayout();
            // 
            // btnCredito
            // 
            btnCredito.Location = new Point(30, 199);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(75, 23);
            btnCredito.TabIndex = 0;
            btnCredito.Text = "Cartdito";
            btnCredito.UseVisualStyleBackColor = true;
            btnCredito.Click += btnCredito_Click_1;
            // 
            // btnPix
            // 
            btnPix.Location = new Point(121, 199);
            btnPix.Name = "btnPix";
            btnPix.Size = new Size(75, 23);
            btnPix.TabIndex = 1;
            btnPix.Text = "pix";
            btnPix.UseVisualStyleBackColor = true;
            btnPix.Click += btnPix_Click_1;
            // 
            // btnDebito
            // 
            btnDebito.Location = new Point(30, 260);
            btnDebito.Name = "btnDebito";
            btnDebito.Size = new Size(75, 23);
            btnDebito.TabIndex = 2;
            btnDebito.Text = "debito";
            btnDebito.UseVisualStyleBackColor = true;
            btnDebito.Click += btnDebito_Click_1;
            // 
            // btnDinheiro
            // 
            btnDinheiro.Location = new Point(138, 260);
            btnDinheiro.Name = "btnDinheiro";
            btnDinheiro.Size = new Size(75, 23);
            btnDinheiro.TabIndex = 3;
            btnDinheiro.Text = "dinheiro";
            btnDinheiro.UseVisualStyleBackColor = true;
            btnDinheiro.Click += btnDinheiro_Click_1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(590, 315);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "button5";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(722, 260);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label1";
            // 
            // lblTrocoTexto
            // 
            lblTrocoTexto.AutoSize = true;
            lblTrocoTexto.Location = new Point(12, 343);
            lblTrocoTexto.Name = "lblTrocoTexto";
            lblTrocoTexto.Size = new Size(38, 15);
            lblTrocoTexto.TabIndex = 6;
            lblTrocoTexto.Text = "label2";
            lblTrocoTexto.Click += label2_Click;
            // 
            // lblTrocoValor
            // 
            lblTrocoValor.AutoSize = true;
            lblTrocoValor.Location = new Point(326, 343);
            lblTrocoValor.Name = "lblTrocoValor";
            lblTrocoValor.Size = new Size(38, 15);
            lblTrocoValor.TabIndex = 7;
            lblTrocoValor.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 343);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 225);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Location = new Point(78, 316);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.Size = new Size(100, 23);
            txtValorRecebido.TabIndex = 10;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(96, 32);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(100, 23);
            txtNomeCliente.TabIndex = 11;
            // 
            // listViewResumo
            // 
            listViewResumo.Location = new Point(533, 55);
            listViewResumo.Name = "listViewResumo";
            listViewResumo.Size = new Size(166, 167);
            listViewResumo.TabIndex = 12;
            listViewResumo.UseCompatibleStateImageBehavior = false;
            // 
            // FormFinalizarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewResumo);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtValorRecebido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblTrocoValor);
            Controls.Add(lblTrocoTexto);
            Controls.Add(lblTotal);
            Controls.Add(btnConfirmar);
            Controls.Add(btnDinheiro);
            Controls.Add(btnDebito);
            Controls.Add(btnPix);
            Controls.Add(btnCredito);
            Name = "FormFinalizarPedido";
            Text = "FormFinalizarPedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCredito;
        private Button btnPix;
        private Button btnDebito;
        private Button btnDinheiro;
        private Button btnConfirmar;
        private Label lblTotal;
        private Label lblTrocoTexto;
        private Label lblTrocoValor;
        private Label label4;
        private Label label5;
        private TextBox txtValorRecebido;
        private TextBox txtNomeCliente;
        private ListView listViewResumo;
    }
}