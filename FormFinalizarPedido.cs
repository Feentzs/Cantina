using System;
using System.Globalization;
using System.Windows.Forms;
using System.IO;

namespace Cantina
{
    public partial class FormFinalizarPedido : Form
    {
        private decimal totalPedido;
        private string formaPagamento = "";

        public FormFinalizarPedido(ListView.ListViewItemCollection itensCarrinho, decimal total)
        {
            InitializeComponent();
            this.totalPedido = total;

            
            ConfigurarListViewResumo();
            CarregarItensCarrinho(itensCarrinho);
            ConfigurarBotoesPagamento();
            EsconderControlesTroco();

            
            lblTotal.Text = total.ToString("C", new CultureInfo("pt-BR"));
        }

        private void ConfigurarListViewResumo()
        {
            listViewResumo.View = View.Details;
            listViewResumo.Columns.Clear();
            listViewResumo.Columns.Add("Produto", 200);
            listViewResumo.Columns.Add("Qtd", 50);
            listViewResumo.Columns.Add("Subtotal", 100);
        }

        private void CarregarItensCarrinho(ListView.ListViewItemCollection itensCarrinho)
        {
            listViewResumo.Items.Clear();
            foreach (ListViewItem item in itensCarrinho)
            {
                ListViewItem novoItem = new ListViewItem(item.Text); 
                novoItem.SubItems.Add(item.SubItems[2].Text); 
                novoItem.SubItems.Add(item.SubItems[3].Text); 
                listViewResumo.Items.Add(novoItem);
            }
        }

        private void ConfigurarBotoesPagamento()
        {
            btnCredito.BackColor = SystemColors.Control;
            btnDebito.BackColor = SystemColors.Control;
            btnDinheiro.BackColor = SystemColors.Control;
            btnPix.BackColor = SystemColors.Control;
        }

        private void EsconderControlesTroco()
        {
            lblValorRecebido.Visible = false;
            btnCancelar.Visible = true;
            txtValorRecebido.Visible = false;
            lblTroco.Visible = false;
            lblValorTroco.Visible = false;
            txtValorRecebido.Text = "";
            lblValorTroco.Text = "R$0,00";
            trocoimg.Visible = false;
            insiravalor.Visible = false;
        }

        private void MostrarControlesTroco()
        {
            lblValorRecebido.Visible = true;
            txtValorRecebido.Visible = true;
            lblTroco.Visible = true;
            lblValorTroco.Visible = true;
            trocoimg.Visible = true;
            btnCancelar.Visible = false;
            insiravalor.Visible = true;
            txtValorRecebido.Focus();
        }

        private void SelecionarFormaPagamento(Button botaoSelecionado, string forma)
        {

            btnCredito.BackColor = Color.White;
            btnDebito.BackColor = SystemColors.Control;
            btnDinheiro.BackColor = SystemColors.Control;
            btnPix.BackColor = SystemColors.Control;


            botaoSelecionado.BackColor = ColorTranslator.FromHtml("#E1FF00");
            formaPagamento = forma;
        }

        private void CalcularTroco()
        {
            if (decimal.TryParse(txtValorRecebido.Text, out decimal valorRecebido))
            {
                decimal troco = valorRecebido - totalPedido;
                if (troco < 0) troco = 0;
                lblValorTroco.Text = troco.ToString("C", new CultureInfo("pt-BR"));
            }
            else
            {
                lblValorTroco.Text = "R$0,00";
            }
        }


        private void btnCredito_Click_1(object sender, EventArgs e)
        {
            SelecionarFormaPagamento(btnCredito, "CRÉDITO");
            EsconderControlesTroco();
        }

        private void btnDebito_Click_1(object sender, EventArgs e)
        {
            SelecionarFormaPagamento(btnDebito, "DÉBITO");
            EsconderControlesTroco();
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            SelecionarFormaPagamento(btnDinheiro, "DINHEIRO");
            MostrarControlesTroco();
        }

        private void btnPix_Click_1(object sender, EventArgs e)
        {
            SelecionarFormaPagamento(btnPix, "PIX");
            EsconderControlesTroco();
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            CalcularTroco();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            
            if (ValidarDados())
            {
                string pasta = Path.Combine(Application.StartupPath, "Arquivos");
                Directory.CreateDirectory(pasta); 

                

                string caminhoFila = Path.Combine(pasta, "em_preparo.txt");
                string nome = txtNomeCliente.Text.Trim();
                string horario = DateTime.Now.ToString("HH:mm");

                List<string> produtos = new List<string>();

                foreach (ListViewItem item in listViewResumo.Items)
                {
                    produtos.Add(item.SubItems[0].Text); 
                }

                string linhaPedido = $"{nome};{horario};{string.Join("|",produtos)};Em Preparo";
                File.AppendAllText(caminhoFila, linhaPedido + Environment.NewLine);

                string caminhoLog = Path.Combine(pasta, "pedidos_log.txt");
                string log = $"[{DateTime.Now}] Cliente: {txtNomeCliente.Text.Trim()} | Total: {lblTotal.Text} | Pagamento: {formaPagamento} |Produtos: {string.Join(" | ", produtos)}";
                File.AppendAllText(caminhoLog, log + Environment.NewLine);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarDados()
        {
            if (formaPagamento == "PIX")
            {
                TelaPix telinhaPix = new TelaPix();
                telinhaPix.ShowDialog();
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Informe o nome do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCliente.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(formaPagamento))
            {
                MessageBox.Show("Selecione a forma de pagamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (formaPagamento == "DINHEIRO")
            {
                if (!decimal.TryParse(txtValorRecebido.Text, out decimal valorRecebido))
                {
                    MessageBox.Show("Valor recebido inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValorRecebido.Focus();
                    return false;
                }

                if (valorRecebido < totalPedido)
                {
                    MessageBox.Show("Valor recebido é menor que o total do pedido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValorRecebido.Focus();
                    return false;
                }
            }


            return true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar o pedido?", "Cantina", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
           
        }

        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmar.ForeColor = ColorTranslator.FromHtml("#000000");
            btnConfirmar.Image = Properties.Resources.vai;
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmar.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            btnConfirmar.Image = Properties.Resources.Semtitulo2;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = ColorTranslator.FromHtml("#ff3000");
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }
    }
}