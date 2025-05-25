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
    public partial class telachamada : Form
    {
        public telachamada()
        {
            InitializeComponent();
            AtualizarClienteAtual();
            AtualizarEmPreparoComLabels();
        }
        private void AtualizarClienteAtual()
        {
            string caminho = Path.Combine(Application.StartupPath, "Arquivos", "cliente_atual.txt");

            if (File.Exists(caminho))
            {
                string nome = File.ReadAllText(caminho).Trim();
                lblClienteAtual.Text = string.IsNullOrEmpty(nome) ? "Aguardando..." : nome;
            }
            else
            {
                lblClienteAtual.Text = "Aguardando...";
            }
        }

        private void AtualizarEmPreparoComLabels()
        {
            string caminho = Path.Combine(Application.StartupPath, "Arquivos", "em_preparo.txt");
            panelFila.Controls.Clear();

            if (!File.Exists(caminho)) return;

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(';');
                if (partes.Length >= 1)
                {
                    string nome = partes[0];

                    Label lbl = new Label();
                    lbl.Text = nome;
                    lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                    lbl.ForeColor = Color.White;
                    lbl.BackColor = Color.FromArgb(30, 30, 30); // cinza escuro discreto
                    lbl.AutoSize = true;
                    lbl.Margin = new Padding(5);
                    lbl.Padding = new Padding(10, 5, 10, 5);

                    panelFila.Controls.Add(lbl);
                }
            }
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("HH:mm");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            AtualizarClienteAtual();
            AtualizarEmPreparoComLabels();
        }
    }
}
