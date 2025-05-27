using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Cantina
{
    public partial class balcao : Form
    {
        public balcao()
        {
            InitializeComponent();
            CarregarPedidos();
            SendToBack();
        }

        private string statusFiltroSelecionado = "Todos";

        private void CarregarPedidos()
        {
            flowLayoutPanelPedidos.Controls.Clear();

            string caminho = Path.Combine(Application.StartupPath, "Arquivos", "em_preparo.txt");
            if (!File.Exists(caminho)) return;

            var linhas = File.ReadAllLines(caminho);
            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(';');
                if (partes.Length < 4) continue;

                string nome = partes[0];
                string horario = partes[1];
                string[] produtos = partes[2].Split('|');
                string status = partes[3];

                // Filtro
                if (statusFiltroSelecionado != "Todos" && status != statusFiltroSelecionado)
                    continue;

                AdicionarCard(nome, horario, produtos, status);
            }
        }

        private void AdicionarCard(string nome, string horario, string[] produtos, string status)
        {
            Panel card = new Panel
            {
                Width = 520,
                Height = 130,
                BackColor = Color.White,
                Margin = new Padding(10),
                Tag = new Pedido { NomeCliente = nome, Horario = horario, Produtos = produtos, Status = status }
            };

            card.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 15;
                    Rectangle rect = new Rectangle(0, 0, card.Width, card.Height);
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    card.Region = new Region(path);
                }
            };

            Label lblCliente = new Label
            {
                Text = $"{nome}",
                //Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(20, 10),
                AutoSize = true
            };

            Label lblHora = new Label
            {
                Text = $"{horario}",
                //Font = new Font("Segoe UI", 9),
                Location = new Point(20, 35),
                AutoSize = true
            };

            Label lblStatus = new Label
            {
                Text = $"Status: {status}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                Location = new Point(20, 60),
                ForeColor = Color.DarkGreen,
                AutoSize = true
            };

            Button btnDetalhes = new Button
            {
                Text = "Ver Detalhes",
                Location = new Point(20, 90),
                Font = new Font("Inter", 11, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(130, 40),
                BackColor = Color.Black,
                ForeColor = Color.White
            };
            btnDetalhes.Click += BtnDetalhes_Click;

            card.Controls.Add(lblCliente);
            card.Controls.Add(lblHora);
            card.Controls.Add(lblStatus);
            card.Controls.Add(btnDetalhes);
            flowLayoutPanelPedidos.Controls.Add(card);

            Button btnChamar = new Button
            {
                Text = "Chamar Cliente",
                Location = new Point(150, 90),
                Size = new Size(130, 30),
                //BackColor = ColorTranslator.FromHtml("#E1FF00"),
                BackgroundImage = Properties.Resources.vai,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Black
            };
            btnChamar.Click += (s, e) =>
            {
                MessageBox.Show($"Chamando: {nome}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aqui você pode salvar em cliente_atual.txt também se quiser
            };

            card.Controls.Add(btnChamar);
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Panel card = btn.Parent as Panel;
            Pedido pedido = card.Tag as Pedido;

            lblNomeCliente.Text = $"{pedido.NomeCliente}";
            lblHorario.Text = $"{pedido.Horario}";
            lblStatus.Text = $"{pedido.Status}";
            listBoxProdutos.Items.Clear();
            listBoxProdutos.Items.AddRange(pedido.Produtos);
            

            panelDetalhes.Visible = true;
            panelDetalhes.BringToFront();
            
        }

        private void btnFecharDetalhes_Click(object sender, EventArgs e)
        {
            panelDetalhes.Visible = false;
            
        }

        public class Pedido
        {
            public string NomeCliente { get; set; }
            public string Horario { get; set; }
            public string[] Produtos { get; set; }
            public string Status { get; set; }
        }


        private void btnFiltro_Click(object sender, EventArgs e)
        {
            contextMenuFiltro.Show(btnFiltro, new Point(0, btnFiltro.Height));
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusFiltroSelecionado = "Todos";
            CarregarPedidos();
        }

        private void emPreparoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusFiltroSelecionado = "Em preparo";
            CarregarPedidos();
        }

        private void prontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusFiltroSelecionado = "Pronto";
            CarregarPedidos();
        }

        private void entregueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusFiltroSelecionado = "Entregue";
            CarregarPedidos();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void balcao_Load(object sender, EventArgs e)
        {
            
        }
    }
}
