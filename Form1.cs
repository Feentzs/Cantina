using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina
{
    public partial class Form1 : Form
    {
        private int _quantidade = 1;
        public decimal TotalCarrinho { get; private set; }
        private List<string[]> produtosOriginais = new List<string[]>();

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

        private void ConfigureListViews()
        {

            listViewProdutos.View = View.Details;
            listViewProdutos.FullRowSelect = true;
            listViewProdutos.Columns.Add("Produto", 295);
            listViewProdutos.Columns.Add("Preço", 80);

          
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
            produtosOriginais.Clear();

           string[] linhas = File.ReadAllLines("./Arquivos/produtos.txt");

           foreach (string linha in linhas)
            {
               string[] partes = linha.Split(new[] { " - R$" }, StringSplitOptions.None);
               string nome = partes[0];
               string preco = "R$" + partes[1];

               produtosOriginais.Add(new string[] { nome, preco });

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
            int quantidadeRemover = _quantidade; // Usa a quantidade dos botões +/-
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
            txtPesquisa.Clear();
        }

        private void btnDiminuir_MouseEnter(object sender, EventArgs e)
        {
            btnDiminuir.BackColor = ColorTranslator.FromHtml("#000000");
            btnDiminuir.Image = Properties.Resources.keyboard_arrow_down_verde;
        }


        private void btnDiminuir_MouseLeave(object sender, EventArgs e)
        {
            btnDiminuir.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btnDiminuir.Image = Properties.Resources.keyboard_arrow_down;

        }

        private void btnAumentar_MouseEnter(object sender, EventArgs e)
        {
            btnAumentar.Image = Properties.Resources.keyboard_arrow_up_verde;
        }

        private void btnAumentar_MouseLeave(object sender, EventArgs e)
        {
            btnAumentar.Image = Properties.Resources.keyboard_arrow_up;
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
            btnRemover.ForeColor = ColorTranslator.FromHtml("#ff3000");
        }

        private void btnRemover_MouseLeave(object sender, EventArgs e)
        {
            btnRemover.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
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

            var resultados = produtosOriginais
                .Where(p => RemoverAcentos(p[0].ToLower()).Contains(termo))
                .ToList();

            listViewProdutos.Items.Clear();

            foreach (var produto in resultados)
            {
                var item = new ListViewItem(produto[0]);
                item.SubItems.Add(produto[1]);
                listViewProdutos.Items.Add(item);
            }
        }

        
    }
}