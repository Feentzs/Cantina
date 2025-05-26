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

            bool isPrimeiro = true;

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(';');
                if (partes.Length < 3) continue;

                string nome = partes[0];
                string horario = partes[1];
                string[] itens = partes[2].Split('|');

                RoundedPanel card = new RoundedPanel();
                card.Size = new Size(210, 130);
                card.Margin = new Padding(10);
                card.BackColor = ColorTranslator.FromHtml("#1A1F15");

                Label lblNome = new Label();
                lblNome.Text = nome;
                lblNome.Font = new Font("Inter", 12, FontStyle.Bold);
                lblNome.ForeColor = ColorTranslator.FromHtml("#F3F1EE");
                lblNome.Location = new Point(10, 20);
                lblNome.AutoSize = true;

                Label lblHora = new Label();
                lblHora.Text = horario;
                lblHora.Font = new Font("Inter", 10, FontStyle.Regular);
                lblHora.ForeColor = ColorTranslator.FromHtml("#CAC4B7");
                lblHora.Location = new Point(10, 40);
                lblHora.AutoSize = true;

                Label lblItens = new Label();
                lblItens.Text = string.Join("\n", itens);
                lblItens.Font = new Font("Inter", 12, FontStyle.Regular);
                lblItens.ForeColor = ColorTranslator.FromHtml("#CAC4B7");
                lblItens.Location = new Point(10, 60);
                lblItens.Size = new Size(230, 60);

                card.Controls.Add(lblNome);
                card.Controls.Add(lblHora);
                card.Controls.Add(lblItens);

                
                if (isPrimeiro)
                {
                    Label lblPrioridade = new Label();
                    lblPrioridade.Text = "PRIORIDADE";
                    lblPrioridade.BackColor = ColorTranslator.FromHtml("#E1FF00"); ;
                    lblPrioridade.ForeColor = Color.Black;
                    lblPrioridade.Font = new Font("Inter", 12, FontStyle.Bold);
                    lblPrioridade.AutoSize = true;
                    lblPrioridade.Padding = new Padding(100, 3, 800, 7);
                    lblPrioridade.Location = new Point(-50, 0);
                    lblNome.Location = new Point(10, 40);
                    lblHora.Location = new Point(10, 60);
                    lblItens.Location = new Point(10, 80);
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
