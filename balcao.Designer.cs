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
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(182, 16);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "label1";
            // 
            // btnFecharDetalhes
            // 
            btnFecharDetalhes.Location = new Point(20, 320);
            btnFecharDetalhes.Name = "btnFecharDetalhes";
            btnFecharDetalhes.Size = new Size(100, 30);
            btnFecharDetalhes.TabIndex = 3;
            btnFecharDetalhes.Text = "Fechar";
            btnFecharDetalhes.UseVisualStyleBackColor = true;
            btnFecharDetalhes.Click += btnFecharDetalhes_Click;
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.ItemHeight = 15;
            listBoxProdutos.Location = new Point(20, 100);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.Size = new Size(240, 199);
            listBoxProdutos.TabIndex = 2;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(20, 60);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(50, 15);
            lblHorario.TabIndex = 1;
            lblHorario.Text = "Horário:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(20, 20);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(47, 15);
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
            ClientSize = new Size(961, 683);
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
    }
}