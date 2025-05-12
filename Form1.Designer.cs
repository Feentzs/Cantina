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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Pão de Queijo - R$3,50", "Coxinha - R$5,00", "Pastel de Carne - R$6,00", "Pastel de Queijo - R$5,50", "Suco Natural (300ml) - R$4,00", "Refrigerante Lata - R$4,50", "Hambúger Simples - R$8,00", "Hambúger com Queijo - R$9,00", "X-Tudo - R$12,00", "Água Mineral (500ml) - R$2,50" });
            listBox1.Location = new Point(61, 195);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(379, 304);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(501, 314);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(841, 558);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCantina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
