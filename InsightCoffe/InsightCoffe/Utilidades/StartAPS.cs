using InsightCoffe.Entity;
using InsightCoffe.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightCoffe.Utilidades
{
    public partial class StartAPS : Form
    {
        public List<Produto> produtos = new List<Produto>();

        private Form1 Form1;
        public StartAPS(Form1 form1, List<Usuarios> usuarios)
        {
            InitializeComponent();
            this.Form1 = form1;

            produtos.Add(new Produto()
            {
                ID = 1,
                Descricao = "Café",
                Quantidade = "100ml",
                Valor = 2
            });
            produtos.Add(new Produto()
            {
                ID = 2,
                Descricao = "Café",
                Quantidade = "180ml",
                Valor = 2.50
            });
            produtos.Add(new Produto()
            {
                ID = 3,
                Descricao = "Café",
                Quantidade = "280ml",
                Valor = 3
            });
            produtos.Add(new Produto()
            {
                ID = 4,
                Descricao = "Café c/ Leite",
                Quantidade = "180ml",
                Valor = 2.75
            });
            produtos.Add(new Produto()
            {
                ID = 5,
                Descricao = "Café c/ Leite",
                Quantidade = "280ml",
                Valor = 3.25
            });
            produtos.Add(new Produto()
            {
                ID = 6,
                Descricao = "Capuccino",
                Quantidade = "80ml",
                Valor = 2.10
            });
            produtos.Add(new Produto()
            {
                ID = 7,
                Descricao = "Capuccino",
                Quantidade = "180ml",
                Valor = 3.50
            });
            produtos.Add(new Produto()
            {
                ID = 8,
                Descricao = "Capuccino",
                Quantidade = "280ml",
                Valor = 5
            });
            produtos.Add(new Produto()
            {
                ID = 9,
                Descricao = "Macchiato",
                Quantidade = "180ml",
                Valor = 4
            });
            produtos.Add(new Produto()
            {
                ID = 10,
                Descricao = "Macchiato",
                Quantidade = "280ml",
                Valor = 5.50
            });
            produtos.Add(new Produto()
            {
                ID = 11,
                Descricao = "Café latte",
                Quantidade = "180ml",
                Valor = 4.25
            });
            produtos.Add(new Produto()
            {
                ID = 12,
                Descricao = "Café latte",
                Quantidade = "280ml",
                Valor = 5.75
            });
            produtos.Add(new Produto()
            {
                ID = 13,
                Descricao = "Mocha",
                Quantidade = "180ml",
                Valor = 4
            });
            produtos.Add(new Produto()
            {
                ID = 14,
                Descricao = "Mocha",
                Quantidade = "280ml",
                Valor = 5
            });
            produtos.Add(new Produto()
            {
                ID = 15,
                Descricao = "Naked",
                Quantidade = "180ml",
                Valor = 4.50
            });
            produtos.Add(new Produto()
            {
                ID = 16,
                Descricao = "Naked",
                Quantidade = "280ml",
                Valor = 5.50
            });
            produtos.Add(new Produto()
            {
                ID = 17,
                Descricao = "Bomba de chocolate",
                Quantidade = "Media",
                Valor = 4.50
            });
            produtos.Add(new Produto()
            {
                ID = 18,
                Descricao = "Donuts",
                Quantidade = "Grande",
                Valor = 3
            });
            produtos.Add(new Produto()
            {
                ID = 19,
                Descricao = "Cookie",
                Quantidade = "Pequeno",
                Valor = 2.50
            });
            produtos.Add(new Produto()
            {
                ID = 20,
                Descricao = "Torta d/ Limão",
                Quantidade = "Pedaço Mediano",
                Valor = 4
            });
            produtos.Add(new Produto()
            {
                ID = 21,
                Descricao = "Torta d/ Chocolate",
                Quantidade = "Pedaço Mediano",
                Valor = 4
            });
            produtos.Add(new Produto()
            {
                ID = 22,
                Descricao = "Esfirras Carne",
                Quantidade = "Media",
                Valor = 3.50
            });
            produtos.Add(new Produto()
            {
                ID = 23,
                Descricao = "Esfirras Frango",
                Quantidade = "Grande",
                Valor = 3.50
            });
            produtos.Add(new Produto()
            {
                ID = 24,
                Descricao = "Coxinha Frango",
                Quantidade = "Media",
                Valor = 3.50
            });
            produtos.Add(new Produto()
            {
                ID = 25,
                Descricao = "Coxinha c/ Catupiry",
                Quantidade = "Media",
                Valor = 3.50
            });
            produtos.Add(new Produto()
            {
                ID = 26,
                Descricao = "Coxinha Carne",
                Quantidade = "Media",
                Valor = 3.50
            });
            produtos.Add(new Produto()
            {
                ID = 27,
                Descricao = "Quibes",
                Quantidade = "Pequenos",
                Valor = 0.75
            });
            produtos.Add(new Produto()
            {
                ID = 28,
                Descricao = "Quibes",
                Quantidade = "Medio",
                Valor = 1.50
            });
            produtos.Add(new Produto()
            {
                ID = 29,
                Descricao = "Quibes",
                Quantidade = "Grande",
                Valor = 2.25
            });
        }

        //--------------------------------------Mover formulario--------------------------------------------
        Point DragCursor;
        Point DragForm;
        bool Dragging;
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }
        //-------------------------------------end-Mover formulario---------------------------------------

        //-------------------------------------------Fechar aplicação-------------------------------------
        private void picBExit_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fechar todo o Sistema, incuindo todas as telas abertas neste momento?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
        //-----------------------------------------------------------------------------------------------

        //-----------------------------------------Minimizar aplicação------------------------------------
        private void picBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //------------------------------------------------------------------------------------------------

        //---------------------------start Sequencia de EVENTOS abertura das outras Telas-----------------
        private void bntVendas_Click_1(object sender, EventArgs e)
        {
            APSvendas apsPagamento = new APSvendas();
            apsPagamento.Show();
        }

        private void bntPagamento_Click_1(object sender, EventArgs e)
        {
            APSpagamento apsPagamento = new APSpagamento();
            apsPagamento.Show();
        }

        private void bntProdutos_Click_1(object sender, EventArgs e)
        {
            APSprodutos apsProdutos = new APSprodutos(this, produtos);
            apsProdutos.Start = this;
            apsProdutos.Show();
        }
        //-------------------------End Sequencia de EVENTOS abertura das outras Telas---------------------

        //-----------------------------------Codigo de acesso restrito------------------------------------
        private void StartAPS_Load(object sender, EventArgs e)
        {
            lblUsuarioLogado.Text = "Usuario logado: " + Form1.user;
            if(Form1.acess != "Total")
            {
                bntProdutos.Enabled = false;
            }
        }
        //--------------------------------end Codigo de acesso restrito------------------------------------       
        public void Adicionar_produto(double valor, string quantidade, string descricao, int codigo)
        {
            produtos.Add(new Produto()
            {
                ID = codigo,
                Descricao = descricao,
                Quantidade = quantidade,
                Valor = valor
            });
        }
        
        public void Editar_produto(double valor, string quantidade, string descricao, int codigo)
        {
            foreach(Produto produto in produtos)
            {
                if(codigo == produto.ID)
                {
                    produto.Descricao = descricao;
                    produto.Quantidade = quantidade;
                    produto.Valor = valor;
                }
            }
        }
        //--------------------------------end Codigo de acesso restrito------------------------------------
    }
}

