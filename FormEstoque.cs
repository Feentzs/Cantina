using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class FormEstoque : Form
    {
        private string caminhoArquivo = "./Arquivos/produtos.txt";
        private List<Produto> produtos = new List<Produto>();
        private Produto produtoSelecionado;

        public FormEstoque()
        {
            InitializeComponent();
            CarregarProdutos();
            txtBuscar.TextChanged += (s, e) => AtualizarExibicao(txtBuscar.Text);
            AtualizarExibicao();
        }

        private void CarregarProdutos()
        {
            produtos.Clear();
            if (!File.Exists(caminhoArquivo)) return;

            foreach (string linha in File.ReadAllLines(caminhoArquivo))
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(new[] { " - " }, StringSplitOptions.None);
                if (partes.Length < 4) continue;

                string nome = partes[0].Trim();
                string categoria = partes[1].Trim();
                string precoTexto = partes[2].Replace("R$", "").Trim();
                string qtdTexto = partes[3].Trim();

                if (decimal.TryParse(precoTexto, out decimal preco) && int.TryParse(qtdTexto, out int qtd))
                {
                    produtos.Add(new Produto { Nome = nome, Categoria = categoria, Preco = preco, Quantidade = qtd });
                }
            }
        }

        private void AtualizarExibicao(string filtro = "")
        {
            flowLayoutPanelEstoque.Controls.Clear();
            IEnumerable<Produto> lista = produtos;

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                lista = lista.Where(p => p.Nome.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            foreach (var produto in lista)
            {
                Panel card = CriarCardProduto(produto);
                flowLayoutPanelEstoque.Controls.Add(card);
            }
        }

        private Panel CriarCardProduto(Produto p)
        {
            Panel panel = new Panel();
            panel.Size = new Size(750, 50);
            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = Color.White;
            panel.Padding = new Padding(10);
            panel.Margin = new Padding(10);
            panel.Cursor = Cursors.Hand;
            panel.Click += (s, e) => produtoSelecionado = p;
            panel.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle bounds = panel.ClientRectangle;
                bounds.Width -= 1;
                bounds.Height -= 1;
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 10;
                    path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                    path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
                    path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    using (Pen pen = new Pen(Color.LightGray))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            };

            Label lblNome = new Label()
            {
                Text = p.Nome,
                Font = new Font("Inter", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(5, 15)
            };

            Label lblCategoria = new Label()
            {
                Text = $"{p.Categoria}",
                Font = new Font("Inter", 12, FontStyle.Regular),
                Location = new Point(200, 15),
                AutoSize = true
            };

            Label lblPreco = new Label()
            {
                Text = $"R${p.Preco:F2}",
                Font = new Font("Inter", 12, FontStyle.Regular),
                Location = new Point(310, 15),
                AutoSize = true
            };

            Label lblQuantidade = new Label()
            {
                Text = $"{p.Quantidade}",
                Font = new Font("Inter", 12, FontStyle.Regular),
                Location = new Point(420, 15),
                AutoSize = true
            };

            Label lblStatus = new Label()
            {
                AutoSize = true,
                Font = new Font("Inter", 12, FontStyle.Bold),
                Location = new Point(530, 15)
            };

            if (p.Quantidade == 0)
            {
                lblStatus.Text = "Zerado";
                lblStatus.ForeColor = Color.Red;
            }
            else if (p.Quantidade <= 10)
            {
                lblStatus.Text = "Baixo";
                lblStatus.ForeColor = Color.Orange;
            }
            else
            {
                lblStatus.Text = "OK";
                lblStatus.ForeColor = Color.Green;
            }

            panel.Controls.Add(lblNome);
            panel.Controls.Add(lblCategoria);
            panel.Controls.Add(lblPreco);
            panel.Controls.Add(lblQuantidade);
            panel.Controls.Add(lblStatus);

            return panel;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto primeiro.");
                return;
            }

            int delta = 0;
            Form overlay = new Form()
            {
                Owner = this,
                BackColor = Color.Black,
                Opacity = 0.5,
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                Location = this.PointToScreen(Point.Empty),
                Size = this.ClientSize,
                TopMost = true
            };

            overlay.Show();

            Form popup = new Form()
            {
                Size = new Size(600, 500),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.White,
                TopMost = true
            };

            // Cantos arredondados
            popup.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Rectangle bounds = popup.ClientRectangle;
                bounds.Inflate(-1, -1);
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 20;
                    path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                    path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
                    path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    g.FillPath(Brushes.White, path);
                }
            };

            // Imagem decorativa
            PictureBox pic = new PictureBox()
            {
               Image = Properties.Resources.image__3_,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(203, 71),
                Location = new Point(30, 320)
            };

            // Campos texto
            TextBox txtNome = new TextBox() { Text = produtoSelecionado.Nome, Location = new Point(50, 105), Width = 250,Font = new Font("Inter", 10, FontStyle.Regular) };
            TextBox txtCategoria = new TextBox() { Text = produtoSelecionado.Categoria, Location = new Point(50, 175), Width = 250,Font = new Font("Inter", 10, FontStyle.Regular) };
            TextBox txtPreco = new TextBox() { Text = produtoSelecionado.Preco.ToString("F2"), Location = new Point(50, 250), Width = 250, Font = new Font("Inter", 10, FontStyle.Regular) };

           
            Button btnMais = new Button() { Text = "+", Location = new Point(160, 340), Size = new Size(38, 30), Image = Properties.Resources.mais, FlatStyle = FlatStyle.Flat };
            Button btnMenos = new Button() { Text = "-", Location = new Point(50, 340), Size = new Size(38, 30), Image = Properties.Resources.menos, FlatStyle = FlatStyle.Flat };
            Label lblQtd = new Label() { Text = produtoSelecionado.Quantidade.ToString(), Location = new Point(115, 345), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            Label edicao = new Label() { Text = "Editar Itens", Location = new Point(10, 20), AutoSize = true, Font = new Font("Agrandir Narrow Bold", 25, FontStyle.Bold), };
            Label lblnome = new Label() { Text = "Nome do Produto :", Location = new Point(40, 80), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            Label lblcategoria = new Label() { Text = "Categoria :", Location = new Point(40, 150), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            Label lblpreco = new Label() { Text = "Preço :", Location = new Point(40, 220), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            Label lblquantidade = new Label() { Text = "Quantidade :", Location = new Point(40, 290), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            btnMais.Click += (s, e) => { delta++; lblQtd.Text = (produtoSelecionado.Quantidade + delta).ToString(); };
            btnMenos.Click += (s, e) => { delta = Math.Max(-produtoSelecionado.Quantidade, delta - 1); lblQtd.Text = (produtoSelecionado.Quantidade + delta).ToString(); };
            btnMais.FlatAppearance.BorderSize = 0;
            btnMenos.FlatAppearance.BorderSize = 0;

            Button btnSalvar = new Button()
            {
                Text = "Salvar",
                BackgroundImage = Properties.Resources.Semtitulo2,
                BackgroundImageLayout = ImageLayout.Stretch,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Font = new Font("Inter", 12, FontStyle.Bold),
                Size = new Size(239, 59),
                Location = new Point(170, 400)
            };

            Button btnFechar = new Button()
            {
                Text = "X",
                
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Gray,
                Font = new Font("Inter", 14, FontStyle.Bold),
                Size = new Size(40, 40),
                Location = new Point(550, 5)
            };
            btnFechar.FlatAppearance.BorderSize = 0;


            btnSalvar.Click += (s, e) =>
            {
                if (decimal.TryParse(txtPreco.Text.Replace(",", "."), out decimal precoNovo))
                {
                    produtoSelecionado.Nome = txtNome.Text;
                    produtoSelecionado.Categoria = txtCategoria.Text;
                    produtoSelecionado.Preco = precoNovo;
                    produtoSelecionado.Quantidade += delta;
                    AtualizarExibicao(txtBuscar.Text);
                    popup.Close();
                    overlay.Close();
                }
                else
                {
                    MessageBox.Show("Preço inválido.");
                }
            };

            btnFechar.Click += (s, e) =>
            {
                popup.Close();
               overlay.Close();
               
            };

            popup.Controls.AddRange(new Control[] {lblquantidade,lblpreco,lblcategoria,lblnome,edicao,lblQtd,btnMenos,btnMais, txtNome, txtCategoria, txtPreco, pic, btnSalvar, btnFechar });
            overlay.Show();
            popup.ShowDialog();
        }
        private void btnNovoProduto_Click_1(object sender, EventArgs e)
        {
            int delta = 0;
            Form overlay = new Form()
            {
                Owner = this,
                BackColor = Color.Black,
                Opacity = 0.5,
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                Location = this.PointToScreen(Point.Empty),
                Size = this.ClientSize,
                TopMost = true
            };

            overlay.Show();

            Form adicionar = new Form()
            {
                Size = new Size(600, 500),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.White,
                TopMost = true
            };

           

            // Cantos arredondados
            adicionar.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Rectangle bounds = adicionar.ClientRectangle;
                bounds.Inflate(-1, -1);
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 20;
                    path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                    path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
                    path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    g.FillPath(Brushes.White, path);
                }
            };

            // Imagem decorativa
            PictureBox pic = new PictureBox()
            {
                Image = Properties.Resources.image__3_,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(203, 71),
                Location = new Point(30, 320)
            };

            // Campos texto
            TextBox txtNome = new TextBox() { PlaceholderText = "Insira o nome do produto aqui...", Location = new Point(50, 105), Width = 250, Font = new Font("Inter", 10, FontStyle.Regular) };
            TextBox txtCategoria = new TextBox() { PlaceholderText = "Insira a categoria do produto aqui...", Location = new Point(50, 175), Width = 250, Font = new Font("Inter", 10, FontStyle.Regular) };
            TextBox txtPreco = new TextBox() { PlaceholderText = "Insira o valor do prodto aqui", Location = new Point(50, 250), Width = 250, Font = new Font("Inter", 10, FontStyle.Regular) };


            Button btnMais = new Button() { Text = "+", Location = new Point(160, 340), Size = new Size(38, 30), Image = Properties.Resources.mais, FlatStyle = FlatStyle.Flat };
            Button btnMenos = new Button() { Text = "-", Location = new Point(50, 340), Size = new Size(38, 30), Image = Properties.Resources.menos, FlatStyle = FlatStyle.Flat };
            Label lblQtd = new Label() { Text = produtoSelecionado.Quantidade.ToString(), Location = new Point(115, 345), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            Label edicao = new Label() { Text = "Adicionar Itens", Location = new Point(10, 20), AutoSize = true, Font = new Font("Agrandir Narrow Bold", 25, FontStyle.Bold), };
            Label lblnome = new Label() { Text = "Nome do Produto :", Location = new Point(40, 80), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            Label lblcategoria = new Label() { Text = "Categoria :", Location = new Point(40, 150), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            Label lblpreco = new Label() { Text = "Preço :", Location = new Point(40, 220), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            Label lblquantidade = new Label() { Text = "Quantidade :", Location = new Point(40, 290), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold), };
            btnMais.Click += (s, e) => { delta++; lblQtd.Text = (produtoSelecionado.Quantidade + delta).ToString(); };
            btnMenos.Click += (s, e) => { delta = Math.Max(-produtoSelecionado.Quantidade, delta - 1); lblQtd.Text = (produtoSelecionado.Quantidade + delta).ToString(); };
            btnMais.FlatAppearance.BorderSize = 0;
            btnMenos.FlatAppearance.BorderSize = 0;

            Button btnSalvar = new Button()
            {
                Text = "Salvar",
                BackgroundImage = Properties.Resources.Semtitulo2,
                BackgroundImageLayout = ImageLayout.Stretch,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Font = new Font("Inter", 12, FontStyle.Bold),
                Size = new Size(239, 59),
                Location = new Point(170, 400)
            };

            Button btnFechar = new Button()
            {
                Text = "X",

                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Gray,
                Font = new Font("Inter", 14, FontStyle.Bold),
                Size = new Size(40, 40),
                Location = new Point(550, 5)
            };
            btnFechar.FlatAppearance.BorderSize = 0;


            btnSalvar.Click += (s, e) =>
            {
                if (decimal.TryParse(txtPreco.Text.Replace(",", "."), out decimal preco))
                {
                    produtos.Add(new Produto
                    {
                        Nome = txtNome.Text,
                        Categoria = txtCategoria.Text,
                        Preco = preco,
                        Quantidade = delta
                    });
                    AtualizarExibicao(txtBuscar.Text);
                }
                ;

                btnFechar.Click += (s, e) =>
                {
                    adicionar.Close();
                    overlay.Close();

                };

                adicionar.Controls.AddRange(new Control[] { lblquantidade, lblpreco, lblcategoria, lblnome, edicao, lblQtd, btnMenos, btnMais, txtNome, txtCategoria, txtPreco, pic, btnSalvar, btnFechar });
                
               
                overlay.Show();
                adicionar.ShowDialog();


            };
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }
            produtos.Remove(produtoSelecionado);
            produtoSelecionado = null;
            AtualizarExibicao(txtBuscar.Text);
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            List<string> linhas = new List<string>();
            foreach (var p in produtos)
            {
                linhas.Add($"{p.Nome} - {p.Categoria} - R${p.Preco} - {p.Quantidade}");
            }
            File.WriteAllLines(caminhoArquivo, linhas);
            MessageBox.Show("Estoque salvo.");
        }

        private class Produto
        {
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
        }


    }
}