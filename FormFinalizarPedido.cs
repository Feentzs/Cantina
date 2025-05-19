using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Cantina
{
    public partial class FormFinalizarPedido : Form
    {
        private decimal totalPedido;
        private string formaPagamento = "";

        // Construtor que recebe os parâmetros obrigatórios
        

        
       public FormFinalizarPedido(decimal total, ListView.ListViewItemCollection itens)
        {
            try
            {
                InitializeComponent(); // Isso é ESSENCIAL

                totalPedido = total;
                lblTotal.Text = total.ToString("C", new CultureInfo("pt-BR"));

                // Carrega os itens
                foreach (ListViewItem item in itens)
                {
                    listViewResumo.Items.Add((ListViewItem)item.Clone());
                }

                // Configuração inicial
                EsconderTroco();
                ResetarBotoesPagamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar formulário: {ex.Message}");
                this.Close();
            }
        }

        private void CarregarItens(ListView.ListViewItemCollection itens)
        {
            foreach (ListViewItem item in itens)
            {
                listViewResumo.Items.Add((ListViewItem)item.Clone());
            }
        }

        // Método modificado para receber o botão como parâmetro
        private void SelecionarPagamento(string tipo, Button botaoSelecionado)
        {
            formaPagamento = tipo;
            ResetarBotoesPagamento();
            botaoSelecionado.BackColor = Color.LightGreen;
        }

        private void ResetarBotoesPagamento()
        {
            btnCredito.BackColor = SystemColors.Control;
            btnDebito.BackColor = SystemColors.Control;
            btnDinheiro.BackColor = SystemColors.Control;
            btnPix.BackColor = SystemColors.Control;
        }

        // Métodos dos botões atualizados para passar o botão correto
        private void btnCredito_Click_1(object sender, EventArgs e)
        {
            SelecionarPagamento("CRÉDITO", btnCredito);
            EsconderTroco();
        }

        private void btnDebito_Click_1(object sender, EventArgs e)
        {
            SelecionarPagamento("DÉBITO", btnDebito);
            EsconderTroco();
        }

        private void btnDinheiro_Click_1(object sender, EventArgs e)
        {
            SelecionarPagamento("DINHEIRO", btnDinheiro);
            MostrarTroco();
            txtValorRecebido.Focus();
        }

        private void btnPix_Click_1(object sender, EventArgs e)
        {
            SelecionarPagamento("PIX", btnPix);
            EsconderTroco();
        }

        private void MostrarTroco()
        {
            txtValorRecebido.Visible = lblTrocoTexto.Visible = lblTrocoValor.Visible = true;
            lblTrocoValor.Text = "R$0,00";
        }

        private void EsconderTroco()
        {
            txtValorRecebido.Visible = lblTrocoTexto.Visible = lblTrocoValor.Visible = false;
            txtValorRecebido.Text = "";
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorRecebido.Text, out decimal valorRecebido))
            {
                decimal troco = valorRecebido - totalPedido;
                lblTrocoValor.Text = troco.ToString("C", new CultureInfo("pt-BR"));
            }
            else
            {
                lblTrocoValor.Text = "R$0,00";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                MessageBox.Show($"Pedido confirmado!\nCliente: {txtNomeCliente.Text}\nTotal: {lblTotal.Text}\nPagamento: {formaPagamento}");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarDados()
        {
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Informe o nome do cliente!");
                return false;
            }

            if (string.IsNullOrEmpty(formaPagamento))
            {
                MessageBox.Show("Selecione a forma de pagamento!");
                return false;
            }

            if (formaPagamento == "DINHEIRO" &&
               (!decimal.TryParse(txtValorRecebido.Text, out decimal valor) || valor < totalPedido))
            {
                MessageBox.Show("Valor recebido inválido ou insuficiente!");
                return false;
            }

            return true;
      
    }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}