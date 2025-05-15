using System;
using System.Configuration;
using System.Drawing.Imaging;
using System.Globalization;
using System.Security.Policy;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Form1 : Form
    {
        private int _quantidade = 1;
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Produto", 150);
            listView1.Columns.Add("Preço", 80);

            // Configura a ListView do carrinho (antiga listBox2)
            listViewCarrinho.View = View.Details;
            listViewCarrinho.Columns.Add("Produto", 150);
            listViewCarrinho.Columns.Add("Preço", 80);
            listViewCarrinho.Columns.Add("Qtd", 50);
            listViewCarrinho.Columns.Add("Subtotal", 80);

            // Adiciona produtos à listView1 (disponíveis)
            AdicionarProdutosDisponiveis();
        }

        private void AdicionarProdutosDisponiveis()
        {
            // Limpa a lista primeiro
            listView1.Items.Clear();

            // Adiciona produtos (exemplo)
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
                listView1.Items.Add(item);
            }
        }


        
        private void btnAumentar_Click_1(object sender, EventArgs e)
        {
            quantidade++;
            lblQuantidade.Text = quantidade.ToString();
        }

        private void btnDiminuir_Click_1(object sender, EventArgs e)
        {
            if (quantidade > 1)
            {
                quantidade--;
                lblQuantidade.Text = quantidade.ToString();
            }





        private void AddItemToListView(string produto, decimal preco)
        {
            var item = new ListViewItem(produto);
            item.SubItems.Add(preco.ToString("C"));
            item.SubItems.Add("1"); // Quantidade inicial
            item.SubItems.Add(""); // Espaço para botões

            listView1.Items.Add(item);
        }
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            quantidade++;
            lblQuantidade.Text = quantidade.ToString();
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            if (quantidade > 1)
            {
                quantidade--;
                lblQuantidade.Text = quantidade.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecione um produto para adicionar.");
                    return;
                }

                // Declara as variáveis uma única vez no início do método
                string nomeProduto;
                decimal precoUnitario;
                int quantidade;

                // Pega o item selecionado
                var itemSelecionado = listView1.SelectedItems[0];

                // Atribui os valores
                nomeProduto = itemSelecionado.Text;
                precoUnitario = decimal.Parse(itemSelecionado.SubItems[1].Text.Replace("R$", "").Replace(",", "."),
                                  CultureInfo.InvariantCulture);
                quantidade = int.Parse(itemSelecionado.SubItems[2].Text);

                // Verifica se já existe no carrinho (usando um nome diferente para a variável)
                ListViewItem itemExistente = null;
                foreach (ListViewItem item in listViewCarrinho.Items)
                {
                    if (item.Text == nomeProduto)
                    {
                        itemExistente = item;
                        break;
                    }
                }

                if (itemExistente != null)
                {
                    // Atualiza quantidade existente (usando as variáveis já declaradas)
                    int novaQuantidade = int.Parse(itemExistente.SubItems[2].Text) + quantidade;
                    itemExistente.SubItems[2].Text = novaQuantidade.ToString();
                    itemExistente.SubItems[3].Text = (novaQuantidade * precoUnitario).ToString("C", new CultureInfo("pt-BR"));
                }
                else
                {
                    // Adiciona novo item (usando as variáveis já declaradas)
                    var novoItem = new ListViewItem(nomeProduto);
                    novoItem.SubItems.Add(precoUnitario.ToString("C", new CultureInfo("pt-BR")));
                    novoItem.SubItems.Add(quantidade.ToString());
                    novoItem.SubItems.Add((quantidade * precoUnitario).ToString("C", new CultureInfo("pt-BR")));
                    listViewCarrinho.Items.Add(novoItem);
                }

                // Reseta a quantidade para 1 após adicionar
                itemSelecionado.SubItems[2].Text = "1";


                UpdateTotal();
            }

            ListViewItem selecionado = listView1.SelectedItems[0];
            string nome = selecionado.Text;
            string precoText = selecionado.SubItems[1].Text.Replace("R$", "").Trim();
            decimal preco = decimal.Parse(precoText, NumberStyles.Currency, new CultureInfo("pt-BR"));

            // Verifica se já existe no carrinho
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
                // Atualiza quantidade
                int qtd = int.Parse(existente.SubItems[2].Text) + 1;
                existente.SubItems[2].Text = qtd.ToString();
                existente.SubItems[3].Text = (qtd * preco).ToString("C", new CultureInfo("pt-BR"));
            }
            else
            {
                // Adiciona novo item
                var novoItem = new ListViewItem(nome);
                novoItem.SubItems.Add(preco.ToString("C", new CultureInfo("pt-BR")));
                novoItem.SubItems.Add("1"); // Quantidade
                novoItem.SubItems.Add(preco.ToString("C", new CultureInfo("pt-BR"))); // Subtotal
                listViewCarrinho.Items.Add(novoItem);
            }
            _quantidade = 1;
            lblQuantidade.Text = "1";

            UpdateTotal();
        }

        // Método auxiliar para encontrar item no carrinho
        private ListViewItem FindItemInCart(string produtoNome)
        {
            foreach (ListViewItem item in listViewCarrinho.Items)
            {
                if (item.Text == produtoNome)
                {
                    return item;
                }
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewCarrinho.SelectedItems.Count == -1)
            {
                MessageBox.Show("Selecione um produto no carrinho para excluir.");
                return;
            }
            //listViewCarrinho.Items..Remove();


        }

        private void UpdateTotal()
        {
            decimal total = 0m;

            foreach (ListViewItem item in listViewCarrinho.Items)
            {
                string precoText = item.SubItems[1].Text.Replace("R$", "").Trim();
                decimal preco = decimal.Parse(precoText, NumberStyles.Currency, new CultureInfo("pt-BR"));
                int quantidade = int.Parse(item.SubItems[2].Text);

                total += preco * quantidade;
            }

            label3.Text = $"Total: R${total.ToString("N2", new CultureInfo("pt-BR"))}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("Primeiro Adicione um produto!");
            }
            else
            {
                MessageBox.Show($"Valor {label3.Text}");
                listBox2.Items.Clear();
                UpdateTotal();
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = listView1.HitTest(e.Location);

            if (hit.Item != null && hit.SubItem != null)
            {
                // Verifica se clicou na coluna de botões (última coluna)
                if (hit.SubItem == hit.Item.SubItems[3])
                {
                    int quantidade = int.Parse(hit.Item.SubItems[2].Text);

                    // Determina se clicou no + ou no -
                    if (e.X > hit.SubItem.Bounds.Left + (hit.SubItem.Bounds.Width / 2))
                    {
                        // Botão +
                        quantidade++;
                    }
                    else
                    {
                        // Botão -
                        quantidade = Math.Max(1, quantidade - 1);
                    }

                    hit.Item.SubItems[2].Text = quantidade.ToString();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        
        }
    }

}
