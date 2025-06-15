using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Cantina
{
    public partial class Form1 : Form
    {
        private int _quantidade = 1;
        public decimal TotalCarrinho { get; private set; }
        private List<string[]> produtosOriginais = new List<string[]>();
        private List<ProdutoInfo> produtosDisponiveis = new List<ProdutoInfo>();

        // Classe para armazenar informações do produto
        private class ProdutoInfo
        {
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
        }

        // Restante do seu código existente...
        private string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            var normalizedString = texto.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark && c != '-')
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public Form1()
        {
            InitializeComponent();
            ConfigureListViews();
            CarregarProdutosDisponiveis();
        }

        private void ListViewProdutos_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListViewProdutos_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            var produto = produtosDisponiveis.FirstOrDefault(p => p.Nome == e.Item.Text);
            if (produto != null && produto.Quantidade == 0)
            {
                // Texto riscado para produtos sem estoque
                e.Graphics.DrawString(e.SubItem.Text, e.Item.Font, Brushes.Gray, e.Bounds);

                // Linha sobre o texto
                SizeF textSize = e.Graphics.MeasureString(e.SubItem.Text, e.Item.Font);
                Point start = new Point(e.Bounds.Left, e.Bounds.Top + (int)(textSize.Height / 2));
                Point end = new Point(e.Bounds.Left + (int)textSize.Width, start.Y);
                e.Graphics.DrawLine(Pens.Gray, start, end);
            }
            else
            {
                e.DrawDefault = true;
            }
        }


        private void ConfigureListViews()
        {
            // Configuração da listViewProdutos
            listViewProdutos.View = View.Details;
            listViewProdutos.FullRowSelect = true;
            listViewProdutos.GridLines = true;  // Adiciona linhas de grade
            listViewProdutos.HeaderStyle = ColumnHeaderStyle.Nonclickable;  // Faz os cabeçalhos visíveis

            // Limpa e recria as colunas
            listViewProdutos.Columns.Clear();
            listViewProdutos.Columns.Add("Produto", 280);
            listViewProdutos.Columns.Add("Preço", 80);

            // Configuração do OwnerDraw (se estiver usando desenho personalizado)
            listViewProdutos.OwnerDraw = true;
            listViewProdutos.DrawItem += ListViewProdutos_DrawItem;
            listViewProdutos.DrawSubItem += ListViewProdutos_DrawSubItem;
            listViewProdutos.DrawColumnHeader += ListViewProdutos_DrawColumnHeader;

            // Configuração da listViewCarrinho (mantida como estava)
            listViewCarrinho.View = View.Details;
            listViewCarrinho.FullRowSelect = true;
            listViewCarrinho.Columns.Add("Produto", 150);
            listViewCarrinho.Columns.Add("Preço Unit.", 80);
            listViewCarrinho.Columns.Add("Qtd", 50);
            listViewCarrinho.Columns.Add("Subtotal", 80);
        }

        // Adicione este método para desenhar os cabeçalhos
        private void ListViewProdutos_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void CarregarProdutosDisponiveis()
        {
            listViewProdutos.Items.Clear();
            produtosDisponiveis.Clear();

            if (!File.Exists("./Arquivos/produtos.txt"))
            {
                MessageBox.Show("Arquivo de produtos não encontrado!");
                return;
            }

            string[] linhas = File.ReadAllLines("./Arquivos/produtos.txt");

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(new[] { " - " }, StringSplitOptions.None);
                if (partes.Length < 4) continue;

                string nome = partes[0].Trim();
                string categoria = partes[1].Trim();
                string precoTexto = partes[2].Replace("R$", "").Trim().Replace(",", ".");
                string qtdTexto = partes[3].Trim();

                if (decimal.TryParse(precoTexto, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal preco) &&
                    int.TryParse(qtdTexto, out int quantidade))
                {
                    produtosDisponiveis.Add(new ProdutoInfo
                    {
                        Nome = nome,
                        Categoria = categoria,
                        Preco = preco,
                        Quantidade = quantidade
                    });

                    var item = new ListViewItem(nome);
                    item.SubItems.Add($"R${preco.ToString("N2", new CultureInfo("pt-BR"))}");
                    item.ForeColor = quantidade == 0 ? Color.Gray : Color.Black;
                    item.Font = quantidade == 0 ? new Font(listViewProdutos.Font, FontStyle.Strikeout) : listViewProdutos.Font;
                    listViewProdutos.Items.Add(item);
                }
            }
        }





        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            if (listViewCarrinho.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto no carrinho para remover.");
                return;
            }

            var itemSelecionado = listViewCarrinho.SelectedItems[0];
            string nomeProduto = itemSelecionado.Text;
            int quantidadeAtual = int.Parse(itemSelecionado.SubItems[2].Text);
            int quantidadeRemover = _quantidade; 
            decimal precoUnitario = decimal.Parse(itemSelecionado.SubItems[1].Text.Replace("R$", "").Trim(),
                                                NumberStyles.Currency, new CultureInfo("pt-BR"));

            if (quantidadeRemover >= quantidadeAtual)
            {
                listViewCarrinho.Items.Remove(itemSelecionado);
            }
            else
            {
                quantidadeAtual -= quantidadeRemover;
                itemSelecionado.SubItems[2].Text = quantidadeAtual.ToString();
                itemSelecionado.SubItems[3].Text = (quantidadeAtual * precoUnitario).ToString("C", new CultureInfo("pt-BR"));
            }

            UpdateTotal();
            _quantidade = 1;
            lblQuantidade.Text = "1";
        }




        private void UpdateTotal()
        {
            decimal total = 0m;

            foreach (ListViewItem item in listViewCarrinho.Items)
            {
                string subtotalText = item.SubItems[3].Text.Replace("R$", "").Trim();
                total += decimal.Parse(subtotalText, NumberStyles.Currency, new CultureInfo("pt-BR"));
            }

            labelTotal.Text = $"R${total.ToString("N2", new CultureInfo("pt-BR"))}";
        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_MouseEnter(object sender, EventArgs e)
        {
            btnFinalizar.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void btnFinalizar_MouseLeave(object sender, EventArgs e)
        {
            btnFinalizar.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            decimal total = 0m;
            if (listViewCarrinho.Items.Count == 0)
            {
                MessageBox.Show("Carrinho Vazio!");
                return;
            }

            foreach (ListViewItem item in listViewCarrinho.Items)
            {
                string subtotalText = item.SubItems[3].Text.Replace("R$", "").Trim();
                total += decimal.Parse(subtotalText, NumberStyles.Currency, new CultureInfo("pt-BR"));
            }

            var formFinalizar = new FormFinalizarPedido(listViewCarrinho.Items, total);
            if (formFinalizar.ShowDialog() == DialogResult.OK)
            {
                // Atualiza a lista de produtos após finalizar pedido
                CarregarProdutosDisponiveis();
                listViewCarrinho.Items.Clear();
                UpdateTotal();
            }
        }


        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            btnAdicionar.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            btnAdicionar.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto para adicionar.");
                return;
            }

            ListViewItem selecionado = listViewProdutos.SelectedItems[0];
            string nome = selecionado.Text;

            // Verifica se o produto tem estoque
            var produto = produtosDisponiveis.FirstOrDefault(p => p.Nome == nome);
            if (produto == null) return;

            if (produto.Quantidade == 0)
            {
                MessageBox.Show("Este produto está sem estoque!");
                return;
            }

            if (_quantidade > produto.Quantidade)
            {
                MessageBox.Show($"Quantidade indisponível! Estoque atual: {produto.Quantidade}");
                return;
            }

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

                // Verifica se após adicionar ainda tem estoque
                if (qtd > produto.Quantidade)
                {
                    MessageBox.Show($"Quantidade indisponível! Estoque atual: {produto.Quantidade}");
                    return;
                }

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
            txtPesquisa.Clear();
        }

        private void btnDiminuir_MouseEnter(object sender, EventArgs e)
        {

            btnDiminuir.Image = Properties.Resources.menosselecionado;
            btnDiminuir.BackColor = Color.White;
        }


        private void btnDiminuir_MouseLeave(object sender, EventArgs e)
        {

            btnDiminuir.Image = Properties.Resources.menos;

        }

        private void btnAumentar_MouseEnter(object sender, EventArgs e)
        {
            btnAumentar.Image = Properties.Resources.maisselecionado;
            btnAumentar.BackColor = Color.White;

        }

        private void btnAumentar_MouseLeave(object sender, EventArgs e)
        {
            btnAumentar.Image = Properties.Resources.mais;
        }

        private void btnAumentar_Click_1(object sender, EventArgs e)
        {
            _quantidade++;
            lblQuantidade.Text = _quantidade.ToString();
        }

        private void btnDiminuir_Click_1(object sender, EventArgs e)
        {
            if (_quantidade > 1)
            {
                _quantidade--;
                lblQuantidade.Text = _quantidade.ToString();
            }
        }

        private void btnRemover_MouseEnter(object sender, EventArgs e)
        {
            btnRemover.BackgroundImage = Properties.Resources.excluir;
        }

        private void btnRemover_MouseLeave(object sender, EventArgs e)
        {
            btnRemover.BackgroundImage = Properties.Resources.lixo;
        }


        private void listViewProdutos_DrawItem(object sender, DrawListViewItemEventArgs e)
        {


        }

        private void listViewProdutos_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string termo = RemoverAcentos(txtPesquisa.Text.ToLower());

            listViewProdutos.Items.Clear();

            var resultados = produtosDisponiveis
                .Where(p => RemoverAcentos(p.Nome.ToLower()).Contains(termo))
                .ToList();

            foreach (var produto in resultados)
            {
                var item = new ListViewItem(produto.Nome);
                item.SubItems.Add($"R${produto.Preco.ToString("N2", new CultureInfo("pt-BR"))}");
                item.ForeColor = produto.Quantidade == 0 ? Color.Gray : Color.Black;
                item.Font = produto.Quantidade == 0 ? new Font(listViewProdutos.Font, FontStyle.Strikeout) : listViewProdutos.Font;
                listViewProdutos.Items.Add(item);
            }
        }
        private void listViewCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}