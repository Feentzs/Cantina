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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balcao));
            flowLayoutPanelPedidos = new FlowLayoutPanel();
            panelDetalhes = new Panel();
            lblStatus = new Label();
            btnFecharDetalhes = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxProdutos = new ListBox();
            lblHorario = new Label();
            lblNomeCliente = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblPedidosEmPreparo = new Label();
            lblPedidosEntregues = new Label();
            lblPedidosProntos = new Label();
            lblTotalPedidos = new Label();
            label5 = new Label();
            btnFiltro = new Button();
            contextMenuFiltro = new ContextMenuStrip(components);
            todosToolStripMenuItem = new ToolStripMenuItem();
            emPreparoToolStripMenuItem = new ToolStripMenuItem();
            prontoToolStripMenuItem = new ToolStripMenuItem();
            entregueToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelDetalhes.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            contextMenuFiltro.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelPedidos
            // 
            flowLayoutPanelPedidos.AutoScroll = true;
            flowLayoutPanelPedidos.Location = new Point(12, 190);
            flowLayoutPanelPedidos.Name = "flowLayoutPanelPedidos";
            flowLayoutPanelPedidos.Size = new Size(622, 510);
            flowLayoutPanelPedidos.TabIndex = 0;
            // 
            // panelDetalhes
            // 
            panelDetalhes.AutoSize = true;
            panelDetalhes.BackColor = Color.White;
            panelDetalhes.Controls.Add(lblStatus);
            panelDetalhes.Controls.Add(btnFecharDetalhes);
            panelDetalhes.Controls.Add(label4);
            panelDetalhes.Controls.Add(label3);
            panelDetalhes.Controls.Add(label2);
            panelDetalhes.Controls.Add(label1);
            panelDetalhes.Controls.Add(listBoxProdutos);
            panelDetalhes.Controls.Add(lblHorario);
            panelDetalhes.Controls.Add(lblNomeCliente);
            panelDetalhes.Location = new Point(635, 0);
            panelDetalhes.Name = "panelDetalhes";
            panelDetalhes.Size = new Size(306, 707);
            panelDetalhes.TabIndex = 1;
            panelDetalhes.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.FromArgb(230, 255, 0);
            lblStatus.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Location = new Point(24, 79);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 19);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // btnFecharDetalhes
            // 
            btnFecharDetalhes.BackColor = Color.White;
            btnFecharDetalhes.BackgroundImage = (Image)resources.GetObject("btnFecharDetalhes.BackgroundImage");
            btnFecharDetalhes.BackgroundImageLayout = ImageLayout.Stretch;
            btnFecharDetalhes.FlatAppearance.BorderColor = Color.White;
            btnFecharDetalhes.FlatAppearance.BorderSize = 0;
            btnFecharDetalhes.FlatAppearance.MouseDownBackColor = Color.White;
            btnFecharDetalhes.FlatAppearance.MouseOverBackColor = Color.White;
            btnFecharDetalhes.FlatStyle = FlatStyle.Flat;
            btnFecharDetalhes.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFecharDetalhes.ForeColor = Color.White;
            btnFecharDetalhes.Location = new Point(57, 452);
            btnFecharDetalhes.Name = "btnFecharDetalhes";
            btnFecharDetalhes.Size = new Size(182, 46);
            btnFecharDetalhes.TabIndex = 26;
            btnFecharDetalhes.Text = "Fechar";
            btnFecharDetalhes.UseVisualStyleBackColor = false;
            btnFecharDetalhes.Click += btnFecharDetalhes_Click_1;
            btnFecharDetalhes.MouseEnter += btnFecharDetalhes_MouseEnter;
            btnFecharDetalhes.MouseLeave += btnFecharDetalhes_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agrandir Narrow Bold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 220);
            label4.Name = "label4";
            label4.Size = new Size(99, 26);
            label4.TabIndex = 8;
            label4.Text = "Produtos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agrandir Narrow Bold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 170);
            label3.Name = "label3";
            label3.Size = new Size(86, 26);
            label3.TabIndex = 7;
            label3.Text = "Horário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Narrow Bold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 119);
            label2.Name = "label2";
            label2.Size = new Size(160, 26);
            label2.TabIndex = 6;
            label2.Text = "Nome do Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 44);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 5;
            label1.Text = "Detalhes do Pedido";
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.BorderStyle = BorderStyle.None;
            listBoxProdutos.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.ItemHeight = 20;
            listBoxProdutos.Location = new Point(36, 249);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.SelectionMode = SelectionMode.None;
            listBoxProdutos.Size = new Size(240, 180);
            listBoxProdutos.TabIndex = 2;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorario.Location = new Point(34, 194);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(71, 20);
            lblHorario.TabIndex = 1;
            lblHorario.Text = "Horário:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCliente.Location = new Point(34, 146);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(68, 20);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "Cliente:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 241, 238);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblPedidosEmPreparo);
            panel1.Controls.Add(lblPedidosEntregues);
            panel1.Controls.Add(lblPedidosProntos);
            panel1.Controls.Add(lblTotalPedidos);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(640, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 701);
            panel1.TabIndex = 27;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(38, 155);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 533);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(303, 168);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // lblPedidosEmPreparo
            // 
            lblPedidosEmPreparo.AutoSize = true;
            lblPedidosEmPreparo.BackColor = Color.FromArgb(17, 25, 12);
            lblPedidosEmPreparo.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidosEmPreparo.ForeColor = SystemColors.ControlLightLight;
            lblPedidosEmPreparo.Location = new Point(36, 302);
            lblPedidosEmPreparo.Name = "lblPedidosEmPreparo";
            lblPedidosEmPreparo.Size = new Size(57, 23);
            lblPedidosEmPreparo.TabIndex = 4;
            lblPedidosEmPreparo.Text = "Total";
            // 
            // lblPedidosEntregues
            // 
            lblPedidosEntregues.AutoSize = true;
            lblPedidosEntregues.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidosEntregues.Location = new Point(36, 364);
            lblPedidosEntregues.Name = "lblPedidosEntregues";
            lblPedidosEntregues.Size = new Size(190, 23);
            lblPedidosEntregues.TabIndex = 3;
            lblPedidosEntregues.Text = "Pedidos Entregues:";
            // 
            // lblPedidosProntos
            // 
            lblPedidosProntos.AutoSize = true;
            lblPedidosProntos.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidosProntos.Location = new Point(36, 333);
            lblPedidosProntos.Name = "lblPedidosProntos";
            lblPedidosProntos.Size = new Size(168, 23);
            lblPedidosProntos.TabIndex = 2;
            lblPedidosProntos.Text = "Pedidos Prontos:";
            // 
            // lblTotalPedidos
            // 
            lblTotalPedidos.AutoSize = true;
            lblTotalPedidos.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPedidos.Location = new Point(36, 394);
            lblTotalPedidos.Name = "lblTotalPedidos";
            lblTotalPedidos.Size = new Size(222, 25);
            lblTotalPedidos.TabIndex = 1;
            lblTotalPedidos.Text = "Pedidos em preparo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agrandir Narrow Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 241);
            label5.Name = "label5";
            label5.Size = new Size(134, 43);
            label5.TabIndex = 0;
            label5.Text = "Pedidos";
            // 
            // btnFiltro
            // 
            btnFiltro.BackColor = Color.White;
            btnFiltro.BackgroundImage = Properties.Resources.Semtitulo;
            btnFiltro.BackgroundImageLayout = ImageLayout.Stretch;
            btnFiltro.FlatAppearance.BorderSize = 0;
            btnFiltro.FlatAppearance.MouseDownBackColor = Color.White;
            btnFiltro.FlatAppearance.MouseOverBackColor = Color.White;
            btnFiltro.FlatStyle = FlatStyle.Flat;
            btnFiltro.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltro.Image = (Image)resources.GetObject("btnFiltro.Image");
            btnFiltro.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltro.Location = new Point(25, 156);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(112, 34);
            btnFiltro.TabIndex = 2;
            btnFiltro.Text = "Filtro";
            btnFiltro.UseVisualStyleBackColor = false;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // contextMenuFiltro
            // 
            contextMenuFiltro.BackColor = Color.White;
            contextMenuFiltro.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuFiltro.Items.AddRange(new ToolStripItem[] { todosToolStripMenuItem, emPreparoToolStripMenuItem, prontoToolStripMenuItem, entregueToolStripMenuItem });
            contextMenuFiltro.LayoutStyle = ToolStripLayoutStyle.Table;
            contextMenuFiltro.Name = "contextMenuFiltro";
            contextMenuFiltro.Size = new Size(147, 92);
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(146, 22);
            todosToolStripMenuItem.Text = "Todos";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // emPreparoToolStripMenuItem
            // 
            emPreparoToolStripMenuItem.Name = "emPreparoToolStripMenuItem";
            emPreparoToolStripMenuItem.Size = new Size(146, 22);
            emPreparoToolStripMenuItem.Text = "Em preparo";
            emPreparoToolStripMenuItem.Click += emPreparoToolStripMenuItem_Click;
            // 
            // prontoToolStripMenuItem
            // 
            prontoToolStripMenuItem.Name = "prontoToolStripMenuItem";
            prontoToolStripMenuItem.Size = new Size(146, 22);
            prontoToolStripMenuItem.Text = "Pronto";
            prontoToolStripMenuItem.Click += prontoToolStripMenuItem_Click;
            // 
            // entregueToolStripMenuItem
            // 
            entregueToolStripMenuItem.Name = "entregueToolStripMenuItem";
            entregueToolStripMenuItem.Size = new Size(146, 22);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Bolt_Finance_New__3_;
            pictureBox1.Location = new Point(-7, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 101);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(939, 699);
            Controls.Add(panelDetalhes);
            Controls.Add(pictureBox1);
            Controls.Add(toolStripContainer1);
            Controls.Add(btnFiltro);
            Controls.Add(flowLayoutPanelPedidos);
            Controls.Add(panel1);
            Name = "balcao";
            Text = "balcao";
            Load += balcao_Load;
            panelDetalhes.ResumeLayout(false);
            panelDetalhes.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            contextMenuFiltro.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelPedidos;
        private Panel panelDetalhes;
        private ListBox listBoxProdutos;
        private Label lblHorario;
        private Label lblNomeCliente;
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
        private Button btnFecharDetalhes;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label lblPedidosEntregues;
        private Label lblPedidosProntos;
        private Label lblTotalPedidos;
        private Label label5;
        private Label lblPedidosEmPreparo;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}