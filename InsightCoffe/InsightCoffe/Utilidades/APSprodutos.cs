using InsightCoffe.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightCoffe.Utilidades
{
    public partial class APSprodutos : Form
    {
        public List<AddProduto> produtos = new List<AddProduto>();

        public APSprodutos()
        {
            InitializeComponent();

            produtos.Add(new AddProduto()
            {
                Identifier = 1,
                Descricao = "Café",
                Quantidade = "100ml",
                Valor = 2
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 2,
                Descricao = "Café",
                Quantidade = "180ml",
                Valor = 2.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 3,
                Descricao = "Café",
                Quantidade = "280ml",
                Valor = 3
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 4,
                Descricao = "Café c/ Leite",
                Quantidade = "180ml",
                Valor = 2.75
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 5,
                Descricao = "Café c/ Leite",
                Quantidade = "280ml",
                Valor = 3.25
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 6,
                Descricao = "Capuccino",
                Quantidade = "180ml",
                Valor = 3.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 8,
                Descricao = "Capuccino",
                Quantidade = "280ml",
                Valor = 5
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 9,
                Descricao = "Macchiato",
                Quantidade = "180ml",
                Valor = 4
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 10,
                Descricao = "Macchiato",
                Quantidade = "280ml",
                Valor = 5.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 11,
                Descricao = "Café latte",
                Quantidade = "180ml",
                Valor = 4.25
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 12,
                Descricao = "Café latte",
                Quantidade = "280ml",
                Valor = 5.75
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 13,
                Descricao = "Mocha",
                Quantidade = "180ml",
                Valor = 4
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 14,
                Descricao = "Mocha",
                Quantidade = "280ml",
                Valor = 5
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 15,
                Descricao = "Naked",
                Quantidade = "180ml",
                Valor = 4.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 16,
                Descricao = "Naked",
                Quantidade = "280ml",
                Valor = 5.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 17,
                Descricao = "Bomba de chocolate",
                Quantidade = "Media",
                Valor = 4.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 18,
                Descricao = "Donuts",
                Quantidade = "Grande",
                Valor = 3
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 19,
                Descricao = "Cookie",
                Quantidade = "Pequeno",
                Valor = 2.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 20,
                Descricao = "Torta d/ Limão",
                Quantidade = "Pedaço Mediano",
                Valor = 4
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 21,
                Descricao = "Torta d/ Chocolate",
                Quantidade = "Pedaço Mediano",
                Valor = 4
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 22,
                Descricao = "Esfirras Carne",
                Quantidade = "Media",
                Valor = 3.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 23,
                Descricao = "Esfirras Frango",
                Quantidade = "Grande",
                Valor = 3.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 24,
                Descricao = "Coxinha Frango",
                Quantidade = "Media",
                Valor = 3.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 25,
                Descricao = "Coxinha c/ Catupiry",
                Quantidade = "Media",
                Valor = 3.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 26,
                Descricao = "Coxinha Carne",
                Quantidade = "Media",
                Valor = 3.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 27,
                Descricao = "Quibes",
                Quantidade = "Pequenos",
                Valor = 0.75
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 28,
                Descricao = "Quibes",
                Quantidade = "Medio",
                Valor = 1.50
            });
            produtos.Add(new AddProduto()
            {
                Identifier = 29,
                Descricao = "Quibes",
                Quantidade = "Grande",
                Valor = 2.25
            });
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            
            if (txbDescricao.Text == "" || txbQuantidade.Text == "" || txbValor.Text == "")
                MessageBox.Show("Insira todos os campos necessarios para o cadastro", "Aviso!");
            else
            {

                int codigo = Convert.ToInt32(txbCodigo.Text);
                string descricao = txbDescricao.Text;
                string quantidade = txbQuantidade.Text;
                double valor = Convert.ToDouble(txbValor.Text);
                produtos.Add(new AddProduto()
                {
                    Identifier = codigo,
                    Descricao = descricao,
                    Quantidade = quantidade,
                    Valor = valor
                });
            }
        }

        private void APSprodutos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = produtos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbCodigo.Enabled = true;
            txbValor.Enabled = true;
            txbQuantidade.Enabled = true;
            txbDescricao.Enabled = true;
            bntCadastrar.Enabled = true;
        }

        private void picBExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
