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
        private int contadorPiscar = 0;
        private string ultimoCliente = "";
        public telachamada()
        {
            InitializeComponent();
            AtualizarClienteAtual();
            AtualizarEmPreparoComLabels();
        }
        private void AtualizarClienteAtual()
        {
            string caminho = Path.Combine(Application.StartupPath, "Arquivos", "cliente_atual.txt");
            string nome = File.ReadAllText(caminho).Trim();
            if (File.Exists(caminho))
            {
                
                lblClienteAtual.Text = string.IsNullOrEmpty(nome) ? "Aguardando..." : nome;
            }
            else
            {
                lblClienteAtual.Text = "Aguardando...";
            }
            
            if (nome != ultimoCliente) 
            {
                ultimoCliente = nome;
                lblClienteAtual.Text = nome;
                IniciarPiscar(); 
            }
        }

        private void IniciarPiscar()
        {
            contadorPiscar = 0;

            if (timerPiscar == null)
            {
                
                
                timerPiscar.Tick += timerPiscar_Tick;
            }

            timerPiscar.Start();
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

                
                if (partes.Length >= 4)
                {
                    string nome = partes[0];
                    string status = partes[3].Trim().ToLower();

                    if (status == "entregue")
                        continue; 

                    Label lbl = new Label();
                    lbl.Text = nome;
                    lbl.BackColor = Color.FromArgb(30, 30, 30);
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

        private void timerPiscar_Tick(object sender, EventArgs e)
        {
            lblClienteAtual.Visible = !lblClienteAtual.Visible;
            contadorPiscar++;

          
            if (contadorPiscar >= 6)
            {
                timerPiscar.Stop();
                lblClienteAtual.Visible = true; 
            }
        }
    }
}
