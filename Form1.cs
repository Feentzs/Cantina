using System;
using System.Globalization;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Form1 : Form
    {
        private int _quantidade = 1;

        public Form1()
        {
            InitializeComponent();
            ConfigureListViews();
            CarregarProdutosDisponiveis();
        }

        private void ConfigureListViews()
        {

            listViewProdutos.View = View.Details;
            listViewProdutos.FullRowSelect = true;
            listViewProdutos.Columns.Add("Produto", 150);
            listViewProdutos.Columns.Add("Preço", 80);

            // Configuração da ListView do carrinho
            listViewCarrinho.View = View.Details;
            listViewCarrinho.FullRowSelect = true;
            listViewCarrinho.Columns.Add("Produto", 150);
            listViewCarrinho.Columns.Add("Preço Unit.", 80);
            listViewCarrinho.Columns.Add("Qtd", 50);
            listViewCarrinho.Columns.Add("Subtotal", 80);
        }

        private void CarregarProdutosDisponiveis()
        {
            listViewProdutos.Items.Clear();

            string[] produtos = {
                "Pão de Queijo - R$3,50",
                "Coxinha - R$5,00",
                "Pastel de Carne - R$6,00",
                "Pastel de Queijo - R$5,50",
                "Suco Natural (300ml) - R$4,00",
                "Refrigerante Lata - R$4,50",
                "Hamburger Simples - R$8,00",
                "Hamburger com Queijo - R$9,00",
                "X-Tudo - R$12,00",
                "Água Mineral (500ml) - R$2,50"
            };

            foreach (string produto in produtos)
            {
                string[] partes = produto.Split(new[] { " - R$" }, StringSplitOptions.None);
                string nome = partes[0];
                string preco = "R$" + partes[1];

                var item = new ListViewItem(nome);
                item.SubItems.Add(preco);
                listViewProdutos.Items.Add(item);
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            _quantidade++;
            lblQuantidade.Text = _quantidade.ToString();
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            if (_quantidade > 1)
            {
                _quantidade--;
                lblQuantidade.Text = _quantidade.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto para adicionar.");
                return;
            }

            ListViewItem selecionado = listViewProdutos.SelectedItems[0];
            string nome = selecionado.Text;
            string precoText = selecionado.SubItems[1].Text.Replace("R$", "").Trim();
            decimal preco = decimal.Parse(precoText, NumberStyles.Currency, new CultureInfo("pt-BR"));


            ListViewItem existente = null;
            foreach (ListViewItem item in listViewCarrinho.Items)
            {
                if (item.Text == nome)
                {
                    existente = item;
                    break;
                }
            }

            if (existente != null)
            {

                int qtd = int.Parse(existente.SubItems[2].Text) + _quantidade;
                existente.SubItems[2].Text = qtd.ToString();
                existente.SubItems[3].Text = (qtd * preco).ToString("C", new CultureInfo("pt-BR"));
            }
            else
            {

                var novoItem = new ListViewItem(nome);
                novoItem.SubItems.Add(preco.ToString("C", new CultureInfo("pt-BR")));
                novoItem.SubItems.Add(_quantidade.ToString());
                novoItem.SubItems.Add((_quantidade * preco).ToString("C", new CultureInfo("pt-BR")));
                listViewCarrinho.Items.Add(novoItem);
            }


            _quantidade = 1;
            lblQuantidade.Text = "1";
            UpdateTotal();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listViewCarrinho.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto no carrinho para remover.");
                return;
            }

            var itemSelecionado = listViewCarrinho.SelectedItems[0];
            listViewCarrinho.Items.Remove(itemSelecionado);
            UpdateTotal();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (listViewCarrinho.Items.Count == 0)
            {
                MessageBox.Show("Adicione produtos ao carrinho primeiro!");
                return;
            }

            MessageBox.Show($"Pedido finalizado!\nTotal: {labelTotal.Text}");
            listViewCarrinho.Items.Clear();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0m;

            foreach (ListViewItem item in listViewCarrinho.Items)
            {
                string subtotalText = item.SubItems[3].Text.Replace("R$", "").Trim();
                total += decimal.Parse(subtotalText, NumberStyles.Currency, new CultureInfo("pt-BR"));
            }

            labelTotal.Text = $"Total: R${total.ToString("N2", new CultureInfo("pt-BR"))}";
        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}