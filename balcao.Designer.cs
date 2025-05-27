namespace Cantina
{
    partial class balcao
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
            flowLayoutPanelPedidos = new FlowLayoutPanel();
            panelDetalhes = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblStatus = new Label();
            btnFecharDetalhes = new Button();
            listBoxProdutos = new ListBox();
            lblHorario = new Label();
            lblNomeCliente = new Label();
            btnFiltro = new Button();
            contextMenuFiltro = new ContextMenuStrip(components);
            todosToolStripMenuItem = new ToolStripMenuItem();
            emPreparoToolStripMenuItem = new ToolStripMenuItem();
            prontoToolStripMenuItem = new ToolStripMenuItem();
            entregueToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            panelDetalhes.SuspendLayout();
            contextMenuFiltro.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelPedidos
            // 
            flowLayoutPanelPedidos.AutoScroll = true;
            flowLayoutPanelPedidos.Location = new Point(20, 100);
            flowLayoutPanelPedidos.Name = "flowLayoutPanelPedidos";
            flowLayoutPanelPedidos.Size = new Size(600, 620);
            flowLayoutPanelPedidos.TabIndex = 0;
            // 
            // panelDetalhes
            // 
            panelDetalhes.BackColor = Color.White;
            panelDetalhes.Controls.Add(label4);
            panelDetalhes.Controls.Add(label3);
            panelDetalhes.Controls.Add(label2);
            panelDetalhes.Controls.Add(label1);
            panelDetalhes.Controls.Add(lblStatus);
            panelDetalhes.Controls.Add(btnFecharDetalhes);
            panelDetalhes.Controls.Add(listBoxProdutos);
            panelDetalhes.Controls.Add(lblHorario);
            panelDetalhes.Controls.Add(lblNomeCliente);
            panelDetalhes.Location = new Point(640, 0);
            panelDetalhes.Name = "panelDetalhes";
            panelDetalhes.Size = new Size(300, 700);
            panelDetalhes.TabIndex = 1;
            panelDetalhes.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agrandir Narrow Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 192);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 8;
            label4.Text = "Produtos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agrandir Narrow Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 133);
            label3.Name = "label3";
            label3.Size = new Size(72, 22);
            label3.TabIndex = 7;
            label3.Text = "Horário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Narrow Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 77);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 6;
            label2.Text = "Nome do Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow Bold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(178, 26);
            label1.TabIndex = 5;
            label1.Text = "Detalhes do Pedido";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(249, 30);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "label1";
            // 
            // btnFecharDetalhes
            // 
            btnFecharDetalhes.Location = new Point(20, 450);
            btnFecharDetalhes.Name = "btnFecharDetalhes";
            btnFecharDetalhes.Size = new Size(100, 30);
            btnFecharDetalhes.TabIndex = 3;
            btnFecharDetalhes.Text = "Fechar";
            btnFecharDetalhes.UseVisualStyleBackColor = true;
            btnFecharDetalhes.Click += btnFecharDetalhes_Click;
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.BorderStyle = BorderStyle.None;
            listBoxProdutos.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.ItemHeight = 19;
            listBoxProdutos.Location = new Point(36, 217);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.SelectionMode = SelectionMode.None;
            listBoxProdutos.Size = new Size(240, 190);
            listBoxProdutos.TabIndex = 2;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorario.Location = new Point(34, 156);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(68, 19);
            lblHorario.TabIndex = 1;
            lblHorario.Text = "Horário:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCliente.Location = new Point(34, 102);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(65, 19);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "Cliente:";
            // 
            // btnFiltro
            // 
            btnFiltro.Location = new Point(238, 42);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(75, 23);
            btnFiltro.TabIndex = 2;
            btnFiltro.Text = "Filtro";
            btnFiltro.UseVisualStyleBackColor = true;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // contextMenuFiltro
            // 
            contextMenuFiltro.Items.AddRange(new ToolStripItem[] { todosToolStripMenuItem, emPreparoToolStripMenuItem, prontoToolStripMenuItem, entregueToolStripMenuItem });
            contextMenuFiltro.Name = "contextMenuFiltro";
            contextMenuFiltro.Size = new Size(136, 92);
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(135, 22);
            todosToolStripMenuItem.Text = "Todos";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // emPreparoToolStripMenuItem
            // 
            emPreparoToolStripMenuItem.Name = "emPreparoToolStripMenuItem";
            emPreparoToolStripMenuItem.Size = new Size(135, 22);
            emPreparoToolStripMenuItem.Text = "Em preparo";
            emPreparoToolStripMenuItem.Click += emPreparoToolStripMenuItem_Click;
            // 
            // prontoToolStripMenuItem
            // 
            prontoToolStripMenuItem.Name = "prontoToolStripMenuItem";
            prontoToolStripMenuItem.Size = new Size(135, 22);
            prontoToolStripMenuItem.Text = "Pronto";
            prontoToolStripMenuItem.Click += prontoToolStripMenuItem_Click;
            // 
            // entregueToolStripMenuItem
            // 
            entregueToolStripMenuItem.Name = "entregueToolStripMenuItem";
            entregueToolStripMenuItem.Size = new Size(135, 22);
            entregueToolStripMenuItem.Text = "Entregue";
            entregueToolStripMenuItem.Click += entregueToolStripMenuItem_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(58, 17);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            toolStripContainer1.Location = new Point(546, 9);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(58, 42);
            toolStripContainer1.TabIndex = 4;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(939, 683);
            Controls.Add(toolStripContainer1);
            Controls.Add(btnFiltro);
            Controls.Add(panelDetalhes);
            Controls.Add(flowLayoutPanelPedidos);
            Name = "balcao";
            Text = "balcao";
            Load += balcao_Load;
            panelDetalhes.ResumeLayout(false);
            panelDetalhes.PerformLayout();
            contextMenuFiltro.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelPedidos;
        private Panel panelDetalhes;
        private ListBox listBoxProdutos;
        private Label lblHorario;
        private Label lblNomeCliente;
        private Button btnFecharDetalhes;
        private Label lblStatus;
        private Button btnFiltro;
        private ContextMenuStrip contextMenuFiltro;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem emPreparoToolStripMenuItem;
        private ToolStripMenuItem prontoToolStripMenuItem;
        private ToolStripMenuItem entregueToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}