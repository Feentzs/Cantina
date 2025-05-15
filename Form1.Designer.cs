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
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            listViewCarrinho = new ListView();
            btnDiminuir = new Button();
            btnAumentar = new Button();
            lblQuantidade = new Label();
            SuspendLayout();
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(39, 47);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(274, 94);
            listBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(319, 38);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Adicionar>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(319, 78);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "<Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(387, 142);
            button3.Name = "button3";
            button3.Size = new Size(116, 23);
            button3.TabIndex = 4;
            button3.Text = "Fechar Pedido";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            label1.Click += label1_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(511, 493);
            label3.Name = "label3";
            label3.Size = new Size(174, 37);
            label3.TabIndex = 7;
            label3.Text = "Total: R$0,00";
            label3.Click += label3_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(61, 214);
            listView1.Name = "listView1";
            listView1.Size = new Size(322, 316);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            btnDiminuir.Click += btnDiminuir_Click_1;
            // 
            // btnAumentar
            // 
            btnAumentar.Location = new Point(681, 39);
            btnAumentar.Name = "btnAumentar";
            btnAumentar.Size = new Size(75, 23);
            btnAumentar.TabIndex = 11;
            btnAumentar.Text = "+";
            btnAumentar.UseVisualStyleBackColor = true;
            btnAumentar.Click += btnAumentar_Click_1;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(841, 558);
            Controls.Add(lblQuantidade);
            Controls.Add(btnAumentar);
            Controls.Add(btnDiminuir);
            Controls.Add(listViewCarrinho);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCantina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView1;
        private ListView listViewCarrinho;
        private Button btnDiminuir;
        private Button btnAumentar;
        private Label lblQuantidade;
    }
}
