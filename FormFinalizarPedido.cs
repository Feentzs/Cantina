using System;
using System.Globalization;
using System.Windows.Forms;

namespace Cantina
{
    public partial class FormFinalizarPedido : Form
    {
        private decimal totalPedido;
        private string formaPagamento = "";
        private ListView.ListViewItemCollection itensCarrinho;

        public FormFinalizarPedido(decimal total, ListView.ListViewItemCollection itens)
        {
            InitializeComponent();

            // Verificação de segurança
            if (itens == null)
            {
                MessageBox.Show("Erro: Nenhum item no carrinho!");
                this.Close();
                return;
            }

            this.totalPedido = total;
            this.itensCarrinho = itens;

            // Configuração inicial
            lblTotal.Text = total.ToString("C", new CultureInfo("pt-BR"));
            CarregarItensCarrinho();
            EsconderControlesTroco();
            ConfigurarBotoesPagamento();
        }

        private void CarregarItensCarrinho()
        {
            listViewResumo.Items.Clear();
            foreach (ListViewItem item in itensCarrinho)
            {
                var novoItem = new ListViewItem(item.Text);
                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    novoItem.SubItems.Add(item.SubItems[i].Text);
                }
                listViewResumo.Items.Add(novoItem);
            }
        }

        private void ConfigurarBotoesPagamento()
        {
            // Define cores e estilos iniciais
            btnCredito.BackColor = SystemColors.Control;
            btnDebito.BackColor = SystemColors.Control;
            btnDinheiro.BackColor = SystemColors.Control;
            btnPix.BackColor = SystemColors.Control;
        }

        private void EsconderControlesTroco()
        {
            lblValorRecebido.Visible = false;
            txtValorRecebido.Visible = false;
            lblValorTroco.Visible = false;
            lblValorTroco.Visible = false;
            txtValorRecebido.Text = "";
            lblValorTroco.Text = "R$0,00";
        }

        private void MostrarControlesTroco()
        {
            lblValorRecebido.Visible = true;
            txtValorRecebido.Visible = true;
            lblValorTroco.Visible = true;
            lblValorTroco.Visible = true;
            txtValorRecebido.Focus();
        }

        private void SelecionarFormaPagamento(Button botaoSelecionado, string forma)
        {
            // Resetar todos os botões
            btnCredito.BackColor = SystemColors.Control;
            btnDebito.BackColor = SystemColors.Control;
            btnDinheiro.BackColor = SystemColors.Control;
            btnPix.BackColor = SystemColors.Control;

            // Destacar o botão selecionado
            botaoSelecionado.BackColor = Color.LightGreen;
            formaPagamento = forma;
        }

        private void CalcularTroco()
        {
            if (decimal.TryParse(txtValorRecebido.Text, out decimal valorRecebido))
            {
                decimal troco = valorRecebido - totalPedido;
                lblValorTroco.Text = troco.ToString("C", new CultureInfo("pt-BR"));
            }
            else
            {
                lblValorTroco.Text = "R$0,00";
            }
        }

        // Eventos dos botões
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

        private void btnDinheiro_Click_1(object sender, EventArgs e)
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarDados()
        {
            // Validação do nome do cliente
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Informe o nome do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCliente.Focus();
                return false;
            }

            // Validação da forma de pagamento
            if (string.IsNullOrEmpty(formaPagamento))
            {
                MessageBox.Show("Selecione a forma de pagamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação específica para dinheiro
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
    }
}