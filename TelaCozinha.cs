using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{

    public partial class TelaCozinha : Form
    {
        public TelaCozinha()
        {
            InitializeComponent();
            CarregarPedidos();
        }
        private Panel pedidoSelecionado = null;
        private string dadosPedidoSelecionado = "";

        private void CarregarPedidos()
        {
            flowLayoutPanelPedidos.Controls.Clear();

            string caminho = Path.Combine(Application.StartupPath, "Arquivos", "em_preparo.txt");
            if (!File.Exists(caminho)) return;

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(';');
                if (partes.Length < 3) continue;

                string nome = partes[0];
                string horario = partes[1];
                string[] itens = partes[2].Split('|');

                Panel card = new Panel();
                card.Size = new Size(250, 130);
                card.Margin = new Padding(10);
                card.BackColor = Color.White;
                card.BorderStyle = BorderStyle.FixedSingle;

                Label lblNome = new Label();
                lblNome.Text = nome;
                lblNome.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblNome.Location = new Point(10, 10);
                lblNome.AutoSize = true;

                Label lblHora = new Label();
                lblHora.Text = horario;
                lblHora.Location = new Point(10, 30);
                lblHora.AutoSize = true;

                Label lblItens = new Label();
                lblItens.Text = string.Join("\n", itens);
                lblItens.Location = new Point(10, 50);
                lblItens.Size = new Size(230, 60);

                card.Controls.Add(lblNome);
                card.Controls.Add(lblHora);
                card.Controls.Add(lblItens);

                AplicarEventoClick(card, linha, card);

                flowLayoutPanelPedidos.Controls.Add(card);
            }
            bool isPrimeiro = true;

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(';');
                if (partes.Length < 3) continue;

                string nome = partes[0];
                string horario = partes[1];
                string[] itens = partes[2].Split('|');

                Panel card = new Panel();
                card.Size = new Size(250, 130);
                card.Margin = new Padding(10);
                card.BackColor = Color.White;
                card.BorderStyle = BorderStyle.FixedSingle;

                Label lblNome = new Label();
                lblNome.Text = nome;
                lblNome.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblNome.Location = new Point(10, 10);
                lblNome.AutoSize = true;

                Label lblHora = new Label();
                lblHora.Text = horario;
                lblHora.Location = new Point(10, 30);
                lblHora.AutoSize = true;

                Label lblItens = new Label();
                lblItens.Text = string.Join("\n", itens);
                lblItens.Location = new Point(10, 50);
                lblItens.Size = new Size(230, 60);

                card.Controls.Add(lblNome);
                card.Controls.Add(lblHora);
                card.Controls.Add(lblItens);

                // 🔥 Só adiciona essa label se for o primeiro card
                if (isPrimeiro)
                {
                    Label lblPrioridade = new Label();
                    lblPrioridade.Text = "PRIORIDADE";
                    lblPrioridade.BackColor = Color.Gold;
                    lblPrioridade.ForeColor = Color.Black;
                    lblPrioridade.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    lblPrioridade.AutoSize = true;
                    lblPrioridade.Padding = new Padding(4, 2, 4, 2);
                    lblPrioridade.Location = new Point(150, 10); // ajusta conforme o layout
                    card.Controls.Add(lblPrioridade);
                }

                AplicarEventoClick(card, linha, card);
                flowLayoutPanelPedidos.Controls.Add(card);

                isPrimeiro = false;
            }


        }
        private void AplicarEventoClick(Control controle, string linhaOriginal, Panel panel)
        {
            controle.Click += (s, ev) =>
            {
                if (pedidoSelecionado != null)
                    pedidoSelecionado.BackColor = Color.White;

                pedidoSelecionado = panel;
                pedidoSelecionado.BackColor = Color.LightYellow;
                dadosPedidoSelecionado = linhaOriginal;
            };

            foreach (Control filho in controle.Controls)
            {
                AplicarEventoClick(filho, linhaOriginal, panel);
            }
        }
        private void flowLayoutPanelPedidos_MouseClick(object sender, MouseEventArgs e)
        {
            if (pedidoSelecionado != null)
            {
                pedidoSelecionado.BackColor = Color.White;
                pedidoSelecionado = null;
                dadosPedidoSelecionado = "";
            }
        }
        private void btnChamar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dadosPedidoSelecionado))
            {
                MessageBox.Show("Selecione um pedido primeiro.");
                return;
            }

            string[] partes = dadosPedidoSelecionado.Split(';');
            if (partes.Length >= 1)
            {
                string nome = partes[0];
                string caminho = Path.Combine(Application.StartupPath, "Arquivos", "cliente_atual.txt");
                File.WriteAllText(caminho, nome);

                RemoverPedidoSelecionado();
                MessageBox.Show($"Cliente {nome} foi chamado!");
            }
        }
        private void btnProblema_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dadosPedidoSelecionado))
            {
                MessageBox.Show("Selecione um pedido primeiro.");
                return;
            }

            RemoverPedidoSelecionado();
            MessageBox.Show("Pedido removido da fila.");
        }
        private void RemoverPedidoSelecionado()
        {
            string caminho = Path.Combine(Application.StartupPath, "Arquivos", "em_preparo.txt");
            var linhas = File.ReadAllLines(caminho).ToList();

            linhas.Remove(dadosPedidoSelecionado);
            File.WriteAllLines(caminho, linhas);

            dadosPedidoSelecionado = "";
            pedidoSelecionado = null;

            CarregarPedidos();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarregarPedidos();
        }
    }
}
