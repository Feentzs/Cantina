using System;
using System.Configuration;
using System.Drawing.Imaging;
using System.Globalization;
using System.Security.Policy;

namespace Cantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto para adicionar.");
                return;
            }
            listBox2.Items.Add(listBox1.SelectedItem);
            UpdateTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto no carrinho para excluir.");
                return;
            }
            MessageBox.Show($"Produto '{listBox2.SelectedItem}' excluído!");
            listBox2.Items.Remove(listBox2.SelectedItem);
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0m;

            foreach (var item in listBox2.Items)
            {
                string itemText = item.ToString();

                int currencyIndex = itemText.IndexOf("R$");
                if (currencyIndex < 0) continue;

                string valorString = itemText.Substring(currencyIndex + 2).Trim();

                valorString = new string(valorString.Where(c => char.IsDigit(c) || c == ',' || c == '.').ToArray());

                valorString = valorString.Replace(",", ".");

                if (decimal.TryParse(valorString, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor))
                {
                    total += valor;
                }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}