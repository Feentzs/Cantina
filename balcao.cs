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
            AtualizarContadores();

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
                Font = new Font("Inter", 11, FontStyle.Bold),
                Location = new Point(20, 10),
                AutoSize = true
            };

            Label lblHora = new Label
            {
                Text = $"{horario}",
                Font = new Font("Inter", 9),
                Location = new Point(20, 35),
                AutoSize = true
            };

            Label lblStatus = new Label
            {
                Text = $"{status}",
                Font = new Font("Inter", 11, FontStyle.Bold),
                Location = new Point(430, 0),
                ForeColor = Color.Black,
                BackColor = Color.FromArgb(230, 255, 0),
                AutoSize = true
            };

            Button btnDetalhes = new Button
            {
                Text = "Detalhes",
                Location = new Point(20, 80),
                Font = new Font("Inter", 11, FontStyle.Bold),
                BackgroundImage = Properties.Resources.Semtitulo2,
                BackgroundImageLayout = ImageLayout.Stretch,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(130, 40),
                BackColor = Color.White,
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
                Text = "Chamar",
                Location = new Point(360, 80),
                Font = new Font("Inter", 11, FontStyle.Bold),
                BackgroundImage = Properties.Resources.vai,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(130, 40),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Black
            };
            btnChamar.FlatAppearance.BorderSize = 0;
            btnChamar.FlatAppearance.MouseOverBackColor = Color.White;
            btnChamar.FlatAppearance.MouseDownBackColor = Color.White;
            btnDetalhes.FlatAppearance.MouseOverBackColor = Color.White;
            btnDetalhes.FlatAppearance.MouseDownBackColor = Color.White;
           
            
            
        btnChamar.Click += (s, e) =>
            {
                MessageBox.Show($"Chamando: {nome}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string caminho = Path.Combine(Application.StartupPath, "Arquivos", "cliente_atual.txt");
                File.WriteAllText(caminho, nome);

                string segundocaminho = "./Arquivos/em_preparo.txt";
                if (!File.Exists(caminho)) return;

                var linhas = File.ReadAllLines(segundocaminho).ToList();

                for (int i = 0; i < linhas.Count; i++)
                {
                    string[] cliente = linhas[i].Split(';');
                    string nome = cliente[0];
                    if (cliente.Length == 4 && cliente[0] == nome && cliente[3] == "Pronto")
                    {
                        cliente[3] = "Entregue";
                        linhas[i] = string.Join(";", cliente);
                        break;
                    }
                }

                File.WriteAllLines(segundocaminho, linhas);

            }
                ;

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
            statusFiltroSelecionado = "Em Preparo";
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

        private void btnFecharDetalhes_Click_1(object sender, EventArgs e)
        {
            panelDetalhes.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void btnFecharDetalhes_MouseEnter(object sender, EventArgs e)
        {
            btnFecharDetalhes.ForeColor = ColorTranslator.FromHtml("#CAC4B7");
        } 

        private void btnFecharDetalhes_MouseLeave(object sender, EventArgs e)
        {
            btnFecharDetalhes.ForeColor = Color.White;
        }

        private void btnDetalhes_MouseLeave(object sender, EventArgs e)
        {
           
        }
        private void AtualizarContadores()
        {
            int total = 0;
            int prontos = 0;
            int entregues = 0;
            int emPreparo = 0;

            foreach (var linha in File.ReadAllLines("./Arquivos/em_preparo.txt"))
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(';');
                if (partes.Length < 4) continue;

                string status = partes[3].Trim().ToLower();

                total++;

                if (status == "pronto")
                    prontos++;
                else if (status == "entregue")
                    entregues++;
                else if (status == "em preparo")
                    emPreparo++;
            }

            lblTotalPedidos.Text = $"Total: {total}";
            lblPedidosEmPreparo.Text = $"• Em preparo: {emPreparo}";
            lblPedidosProntos.Text = $"• Prontos: {prontos}";
            lblPedidosEntregues.Text = $"• Entregues: {entregues}";
        }

    }
}
