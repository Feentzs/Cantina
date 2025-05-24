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
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form1 Vendas = new Form1();
            Vendas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telachamada Chamada = new telachamada();
            Chamada.Show();
        }

        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            btnAdicionar.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            btnAdicionar.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCozinha Cozinha = new TelaCozinha();
            Cozinha.Show();
        }
    }
}
