using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Cantina
{
    public partial class FormEstoque : Form
    {
        private string caminhoArquivo = "./Arquivos/produtos.txt";
        private List<Produto> produtos = new List<Produto>();
        private Produto produtoSelecionado;
        private Panel cardSelecionado = null;
        public enum FiltroStatus
        {
            Todos,
            OK,
            Baixo,
            Zerado
        }
        private FiltroStatus filtroAtual = FiltroStatus.Todos;

        public FormEstoque()
        {
            InitializeComponent();
            CarregarProdutos();
            AtualizarEstatisticas();
            txtBuscar.TextChanged += (s, e) => AtualizarExibicao(txtBuscar.Text);
            AtualizarExibicao();
            ConfigurarMenuFiltro();
        }

        private void ConfigurarMenuFiltro()
        {
            contextMenuStripFiltro.Items.Clear();

           
            var todos = new ToolStripMenuItem("Todos");
            todos.Click += (s, e) => AplicarFiltro(FiltroStatus.Todos);
            contextMenuStripFiltro.Items.Add(todos);

            var ok = new ToolStripMenuItem("OK (Estoque normal)");
            ok.Click += (s, e) => AplicarFiltro(FiltroStatus.OK);
            contextMenuStripFiltro.Items.Add(ok);

            var baixo = new ToolStripMenuItem("Baixo (≤ 10 unidades)");
            baixo.Click += (s, e) => AplicarFiltro(FiltroStatus.Baixo);
            contextMenuStripFiltro.Items.Add(baixo);

            var zerado = new ToolStripMenuItem("Zerado (0 unidades)");
            zerado.Click += (s, e) => AplicarFiltro(FiltroStatus.Zerado);
            contextMenuStripFiltro.Items.Add(zerado);
        }

        private void AplicarFiltro(FiltroStatus filtro)
        {
            filtroAtual = filtro;
            btnFiltro.Text = $"{filtro}";
            AtualizarExibicao(txtBuscar.Text);
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

            
            switch (filtroAtual)
            {
                case FiltroStatus.OK:
                    lista = lista.Where(p => p.Quantidade > 10);
                    break;
                case FiltroStatus.Baixo:
                    lista = lista.Where(p => p.Quantidade > 0 && p.Quantidade <= 10);
                    break;
                case FiltroStatus.Zerado:
                    lista = lista.Where(p => p.Quantidade == 0);
                    break;
                case FiltroStatus.Todos:
                default:
                   
                    break;
            }

            foreach (var produto in lista)
            {
                Panel card = CriarCardProduto(produto);
                flowLayoutPanelEstoque.Controls.Add(card);
            }

            AtualizarEstatisticas();
        }

        private Panel CriarCardProduto(Produto p)
        {
            Panel panel = new Panel();
            panel.Size = new Size(600, 50);
            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = Color.White;
            panel.Padding = new Padding(10);
            panel.Margin = new Padding(10);
            panel.Cursor = Cursors.Hand;
            panel.Click += (s, e) => produtoSelecionado = p;
            panel.MouseClick += (s, e) =>
            {
                if (cardSelecionado != null)
                    cardSelecionado.BackColor = Color.White;


                panel.BackColor = ColorTranslator.FromHtml("#E6FF00");
                cardSelecionado = panel;

                produtoSelecionado = p;
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


            PictureBox pic = new PictureBox()
            {
                Image = Properties.Resources.image__3_,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(203, 71),
                Location = new Point(30, 320)
            };


            TextBox txtNome = new TextBox() { Text = produtoSelecionado.Nome, Location = new Point(50, 105), Width = 250, Font = new Font("Inter", 10, FontStyle.Regular) };
            TextBox txtCategoria = new TextBox() { Text = produtoSelecionado.Categoria, Location = new Point(50, 175), Width = 250, Font = new Font("Inter", 10, FontStyle.Regular) };
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
                    List<string> linhas = new List<string>();
                    foreach (var p in produtos)
                    {
                        linhas.Add($"{p.Nome} - {p.Categoria} - R${p.Preco} - {p.Quantidade}");
                    }
                    File.WriteAllLines(caminhoArquivo, linhas);
                    MessageBox.Show("Estoque salvo.");
                    AtualizarExibicao(txtBuscar.Text);
                    popup.Close();
                    overlay.Close();
                }
                else
                {
                    MessageBox.Show("Preço inválido.");
                }
            };
            btnSalvar.MouseEnter += (s, e) =>
            {
                btnSalvar.ForeColor = ColorTranslator.FromHtml("#E1FF00");
            };
            btnSalvar.MouseLeave += (s, e) =>
            {
                btnSalvar.ForeColor = Color.White;
            };

            btnSalvar.FlatAppearance.MouseOverBackColor = Color.White;
            btnSalvar.BackColor = Color.White;

            btnFechar.Click += (s, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Você deseja sair? Todas as alterações feitas não seram salvas", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    popup.Close();
                    overlay.Close();

                }

            };

            popup.Controls.AddRange(new Control[] { lblquantidade, lblpreco, lblcategoria, lblnome, edicao, lblQtd, btnMenos, btnMais, txtNome, txtCategoria, txtPreco, pic, btnSalvar, btnFechar });
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




            PictureBox pic = new PictureBox()
            {
                Image = Properties.Resources.image__3_,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(203, 71),
                Location = new Point(30, 320)
            };


            TextBox txtNome = new TextBox() { PlaceholderText = "Insira o nome do produto aqui...", Location = new Point(50, 105), Width = 250, Font = new Font("Inter", 10, FontStyle.Regular) };
            TextBox txtCategoria = new TextBox() { PlaceholderText = "Insira a categoria do produto aqui...", Location = new Point(50, 175), Width = 250, Font = new Font("Inter", 10, FontStyle.Regular) };
            TextBox txtPreco = new TextBox() { PlaceholderText = "Insira o valor do produto aqui", Location = new Point(50, 250), Width = 250, Font = new Font("Inter", 10, FontStyle.Regular) };

            Button btnMais = new Button() { Text = "+", Location = new Point(160, 340), Size = new Size(38, 30), Image = Properties.Resources.mais, FlatStyle = FlatStyle.Flat };
            Button btnMenos = new Button() { Text = "-", Location = new Point(50, 340), Size = new Size(38, 30), Image = Properties.Resources.menos, FlatStyle = FlatStyle.Flat };
            Label lblQtd = new Label() { Text = "0", Location = new Point(115, 345), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold) };
            Label edicao = new Label() { Text = "Adicionar Itens", Location = new Point(10, 20), AutoSize = true, Font = new Font("Agrandir Narrow Bold", 25, FontStyle.Bold) };
            Label lblnome = new Label() { Text = "Nome do Produto :", Location = new Point(40, 80), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold) };
            Label lblcategoria = new Label() { Text = "Categoria :", Location = new Point(40, 150), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold) };
            Label lblpreco = new Label() { Text = "Preço :", Location = new Point(40, 220), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold) };
            Label lblquantidade = new Label() { Text = "Quantidade :", Location = new Point(40, 290), AutoSize = true, Font = new Font("Inter", 14, FontStyle.Bold) };

            btnMais.Click += (s, e) => { delta++; lblQtd.Text = delta.ToString(); };
            btnMenos.Click += (s, e) => { delta = Math.Max(0, delta - 1); lblQtd.Text = delta.ToString(); };
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

            btnSalvar.MouseEnter += (s, e) =>
            {
                btnSalvar.ForeColor = ColorTranslator.FromHtml("#E1FF00");
            };
            btnSalvar.MouseLeave += (s, e) =>
            {
                btnSalvar.ForeColor = Color.White;
            };

            btnSalvar.FlatAppearance.MouseOverBackColor = Color.White;
            btnSalvar.BackColor = Color.White;
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
                    List<string> linhas = new List<string>();
                    foreach (var p in produtos)
                    {
                        linhas.Add($"{p.Nome} - {p.Categoria} - R${p.Preco} - {p.Quantidade}");
                    }
                    File.WriteAllLines(caminhoArquivo, linhas);
                    MessageBox.Show("Estoque salvo.");
                    AtualizarExibicao(txtBuscar.Text);
                    adicionar.Close();
                    overlay.Close();
                }
                else
                {
                    MessageBox.Show("Preço inválido.");
                }

            };

            btnFechar.Click += (s, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Você deseja sair? Todas as alterações feitas não seram salvas", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    adicionar.Close();
                    overlay.Close();
                }
            };

            adicionar.Controls.AddRange(new Control[] { lblquantidade, lblpreco, lblcategoria, lblnome, edicao, lblQtd, btnMenos, btnMais, txtNome, txtCategoria, txtPreco, pic, btnSalvar, btnFechar });

            overlay.Show();
            adicionar.ShowDialog();
        }



        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }
            produtos.Remove(produtoSelecionado);
            produtoSelecionado = null;
            List<string> linhas = new List<string>();
            foreach (var p in produtos)
            {
                linhas.Add($"{p.Nome} - {p.Categoria} - R${p.Preco} - {p.Quantidade}");
            }
            File.WriteAllLines(caminhoArquivo, linhas);
            MessageBox.Show("Estoque salvo.");
            AtualizarExibicao(txtBuscar.Text);
        }


        private class Produto
        {
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
        }

        private void btnRemover_MouseEnter(object sender, EventArgs e)
        {
            btnRemover.BackgroundImage = Properties.Resources.excluir;
            btnRemover.BackColor = ColorTranslator.FromHtml("#F3F1EE");
            btnRemover.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#F3F1EE");
        }

        private void btnRemover_MouseLeave(object sender, EventArgs e)
        {
            btnRemover.BackgroundImage = Properties.Resources.lixo;
        }

        private void btnNovoProduto_MouseEnter(object sender, EventArgs e)
        {
            btnNovoProduto.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void btnNovoProduto_MouseLeave(object sender, EventArgs e)
        {
            btnNovoProduto.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            btnEditar.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }
        private void AtualizarEstatisticas()
        {
            int total = produtos.Count;
            int zerados = produtos.Count(p => p.Quantidade == 0);
            int baixos = produtos.Count(p => p.Quantidade > 0 && p.Quantidade <= 10);

            lblTotal.Text = $"Total: {total}";
            lblZerados.Text = $"• Produtos zerados: {zerados}";
            lblBaixo.Text = $"• Estoque baixo: {baixos}";
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            contextMenuStripFiltro.Show(btnFiltro, new Point(0, btnFiltro.Height));
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque.Visible = true;
            panelHistorico.Visible = false;
            panelTelas.Visible = false;
            if (btnEstoque != null)
            {
                btnEstoque.Font = new Font(btnEstoque.Font, FontStyle.Bold);
                btnHistorico.Font = new Font(btnHistorico.Font, FontStyle.Regular);
                telas.Font = new Font(telas.Font, FontStyle.Regular);
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Estoque.Visible = false;
            panelTelas.Visible = false;
            panelHistorico.Visible = true;
            if (btnHistorico != null)
            {
                btnHistorico.Font = new Font(btnHistorico.Font, FontStyle.Bold);
                btnEstoque.Font = new Font(btnEstoque.Font, FontStyle.Regular);
                telas.Font = new Font(telas.Font, FontStyle.Regular);
            }


            CarregarEstatisticas();
            CarregarHistorico();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estoque.Visible = false;
            panelHistorico.Visible = false;
            panelTelas.Visible = true;
            if (telas != null)
            {
                btnHistorico.Font = new Font(btnHistorico.Font, FontStyle.Regular);
                btnEstoque.Font = new Font(btnEstoque.Font, FontStyle.Regular);
                telas.Font = new Font(telas.Font, FontStyle.Bold);
            }


        }
        ///////////////////////////////////////////////////////////////////////////////////////
        ///
        private void CarregarEstatisticas()
        {
            string[] linhas = File.ReadAllLines("./Arquivos/pedidos_log.txt");

            int totalVendas = 0;
            decimal valorTotal = 0;
            var produtosContagem = new Dictionary<string, int>();
            var horarios = new Dictionary<string, int>();
            var clientes = new Dictionary<string, int>();

            foreach (string linha in linhas)
            {
                if (!linha.Contains("Cliente:")) continue;

                string[] partes = linha.Split('|');
                if (partes.Length < 3) continue;


                string dataHoraStr = linha.Split('[')[1].Split(']')[0];
                if (!DateTime.TryParse(dataHoraStr, out DateTime dataHora)) continue;


                string cliente = partes[0].Contains("Cliente:")
                    ? partes[0].Split("Cliente:")[1].Trim()
                    : partes[1].Replace("Cliente:", "").Trim();

                if (!clientes.ContainsKey(cliente))
                    clientes[cliente] = 0;
                clientes[cliente]++;


                if (dataHora.Date != DateTime.Now.Date) continue;

                totalVendas++;


                string valorStr = partes[1].Contains("Total:") ? partes[1] : partes[2];
                valorStr = valorStr.Replace("Total:", "").Trim().Replace("R$", "").Replace(",", ".");

                if (decimal.TryParse(valorStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor))
                    valorTotal += valor;


                string hora = dataHora.ToString("HH:00");
                if (!horarios.ContainsKey(hora)) horarios[hora] = 0;
                horarios[hora]++;


                string produtosTexto = partes.FirstOrDefault(p => p.Contains("Produtos:"));
                if (!string.IsNullOrEmpty(produtosTexto))
                {
                    string produtosLimpos = produtosTexto.Replace("Produtos:", "").Trim();
                    string[] produtos = produtosLimpos.Split(',');

                    foreach (string prod in produtos)
                    {
                        string nome = prod.Trim();
                        if (nome == "") continue;

                        if (!produtosContagem.ContainsKey(nome))
                            produtosContagem[nome] = 0;
                        produtosContagem[nome]++;
                    }
                }
            }


            decimal media = totalVendas > 0 ? valorTotal / totalVendas : 0;


            string horarioInicio = horarios.OrderByDescending(h => h.Value).FirstOrDefault().Key;
            string horarioPico = "N/A";
            if (!string.IsNullOrEmpty(horarioInicio) && int.TryParse(horarioInicio.Substring(0, 2), out int hIni))
            {
                string hFim = (hIni + 1).ToString("D2") + ":00";
                horarioPico = $"{horarioInicio} - {hFim}";
            }

            string produtoTop = produtosContagem.Any()
                ? produtosContagem.OrderByDescending(p => p.Value).First().Key
                : "N/A";

            string clienteTop = clientes.Any()
                ? clientes.OrderByDescending(p => p.Value).First().Key
                : "N/A";


            lblTotalVendas.Text = $"{totalVendas}";
            lblValorTotal.Text = $"R${valorTotal:N2}";
            lblMediaTicket.Text = $"R${media:N2}";
            lblHorarioPico.Text = $"{horarioPico}";
            lblMaisVendido.Text = $"{produtoTop}";
            lblClienteRecorrente.Text = $"{clienteTop}";
        }
        private void ArredondarBorda(Control controle, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            int largura = controle.Width;
            int altura = controle.Height;

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(largura - raio, 0, raio, raio, 270, 90);
            path.AddArc(largura - raio, altura - raio, raio, raio, 0, 90);
            path.AddArc(0, altura - raio, raio, raio, 90, 90);
            path.CloseFigure();

            controle.Region = new Region(path);
        }


        private void CarregarHistorico()
        {
            flowLayoutHistorico.Controls.Clear();
            string[] linhas = File.ReadAllLines("./Arquivos/pedidos_log.txt");

            
            var pedidosOrdenados = linhas
                .Where(l => l.Contains("Cliente:"))
                .Select(l =>
                {
                    try
                    {
                        string dataStr = l.Split('[')[1].Split(']')[0];
                        DateTime data = DateTime.Parse(dataStr);
                        return new { Data = data, Linha = l };
                    }
                    catch
                    {
                        return new { Data = DateTime.MinValue, Linha = l };
                    }
                })
                .OrderBy(p => ordemDecrescente ? -p.Data.Ticks : p.Data.Ticks) 
                .Select(p => p.Linha)
                .ToList();

            foreach (string linha in pedidosOrdenados)
            {
                string dataHora = linha.Split('[')[1].Split(']')[0];
                string linhaLimpa = linha.Substring(linha.IndexOf("]") + 1).Trim();

                string cliente = "", total = "", pagamento = "", produtosTxt = "";

                string[] partes = linhaLimpa.Split('|');
                foreach (string parte in partes)
                {
                    if (parte.Contains("Cliente:"))
                        cliente = parte.Replace("Cliente:", "").Trim();
                    else if (parte.Contains("Total:"))
                        total = parte.Replace("Total:", "").Trim();
                    else if (parte.Contains("Pagamento:"))
                        pagamento = parte.Replace("Pagamento:", "").Trim();
                    else if (parte.Contains("Produtos:"))
                        produtosTxt = parte.Replace("Produtos:", "").Trim();
                }

                string hora = DateTime.Parse(dataHora).ToString("dd-MM-yyyy HH:mm");

                Panel card = new Panel
                {
                    Width = flowLayoutHistorico.Width - 30,
                    Height = 110,
                    BackColor = Color.White,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.None
                };
                card.Paint += (s, e) => ArredondarBorda(card, 20);

                Label lblCliente = new Label
                {
                    Text = cliente,
                    Font = new Font("Inter", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblTotal = new Label
                {
                    Text = total,
                    Font = new Font("Inter", 12, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(card.Width - 90, 10)
                };

                Label lblHora = new Label
                {
                    Text = hora,
                    Font = new Font("Inter", 10),
                    Location = new Point(10, 35),
                    AutoSize = true
                };

                Label lblProdutos = new Label
                {
                    Text = produtosTxt,
                    Font = new Font("Inter", 10),
                    Location = new Point(10, 55),
                    AutoSize = true
                };

                Label lblPagamento = new Label
                {
                    Text = pagamento,
                    Font = new Font("Inter", 10),
                    AutoSize = true,
                    BackColor = Color.FromArgb(240, 240, 240),
                    Padding = new Padding(10, 4, 10, 4),
                    Location = new Point(card.Width - 110, 75)
                };
                lblPagamento.Paint += (s, e) =>
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        int raio = 15;
                        Rectangle bounds = lblPagamento.ClientRectangle;
                        path.AddArc(0, 0, raio, raio, 180, 90);
                        path.AddArc(bounds.Width - raio, 0, raio, raio, 270, 90);
                        path.AddArc(bounds.Width - raio, bounds.Height - raio, raio, raio, 0, 90);
                        path.AddArc(0, bounds.Height - raio, raio, raio, 90, 90);
                        path.CloseFigure();
                        lblPagamento.Region = new Region(path);
                    }
                };

                card.Controls.Add(lblCliente);
                card.Controls.Add(lblTotal);
                card.Controls.Add(lblHora);
                card.Controls.Add(lblProdutos);
                card.Controls.Add(lblPagamento);
                flowLayoutHistorico.Controls.Add(card);
            }
        }
        private bool ordemDecrescente = true;

        private void btnFiltroData_Click(object sender, EventArgs e)
        {
            ordemDecrescente = !ordemDecrescente;
            btnFiltroData.Text = ordemDecrescente ? "Data ↑" : "Data ↓";
            CarregarHistorico();
        }
        /////////////////////////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            telachamada Chamada = new telachamada();
            Chamada.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form1 Vendas = new Form1();
            Vendas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaCozinha Cozinha = new TelaCozinha();
            Cozinha.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            balcao telabalcao = new balcao();
            telabalcao.Show();
        }

        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            btnAdicionar.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            btnAdicionar.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = ColorTranslator.FromHtml("#E1FF00");
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }
    }
}
