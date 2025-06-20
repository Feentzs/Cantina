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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Dictionary<string, (string Senha, string Tela)> usuarios = new()
        {
          { "admin@bolt.com", ("admin123", "Estoque") },
          { "vendas@bolt.com", ("v123", "Vendas") },
          { "cozinha@bolt.com", ("c123", "Cozinha") },
          { "chamada@bolt.com", ("ch123", "Chamada") },
          { "balcao@bolt.com", ("b123", "Balcao") }
         };

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim().ToLower();
            string senha = txtSenha.Text.Trim();

            if (usuarios.ContainsKey(usuario) && usuarios[usuario].Senha == senha)
            {
                string tela = usuarios[usuario].Tela;

                
                panelErro.Visible = false;

          
                Form telaDestino = tela switch
                {
                    "Estoque" => new FormEstoque(),
                    "Vendas" => new Form1(),
                    "Cozinha" => new TelaCozinha(),
                    "Chamada" => new telachamada(),
                    "Balcao" => new balcao(),
                    _ => null
                };

                if (telaDestino != null)
                {
                    telaDestino.Show();
                    this.WindowState = FormWindowState.Minimized;
                }
            }
            else
            {
               
                panelErro.Visible = true;
            }
        }
    }
}
