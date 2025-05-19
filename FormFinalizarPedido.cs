using System;
using System.Globalization;
using System.Windows.Forms;

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

            // Configuração inicial
            ConfigurarListViewResumo();
            CarregarItensCarrinho(itensCarrinho);
            ConfigurarBotoesPagamento();
            EsconderControlesTroco();

            // Exibe o total
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
                ListViewItem novoItem = new ListViewItem(item.Text); // Nome do produto
                novoItem.SubItems.Add(item.SubItems[2].Text); // Quantidade
                novoItem.SubItems.Add(item.SubItems[3].Text); // Subtotal
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
            txtValorRecebido.Focus();
        }

        private void SelecionarFormaPagamento(Button botaoSelecionado, string forma)
        {

            btnCredito.BackColor = SystemColors.Control;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        
    }
}