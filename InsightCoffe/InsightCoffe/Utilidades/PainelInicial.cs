using InsightCoffe.Entity;
using InsightCoffe.Repositorios;
using InsightCoffe.Utilidades.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;

namespace InsightCoffe.Utilidades
{
    public partial class PainelInicial : Form
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Pedido> pedido = new List<Pedido>(3);
        public List<PedidoPago> armazenaPedido = new List<PedidoPago>();
        public List<Cliente> clientes = new List<Cliente>();

        private Form1 Form1;
        public PainelInicial(Form1 form1, List<Usuarios> usuarios)
        {
            InitializeComponent();
            this.Form1 = form1;

            MetodosProdutos();
            MetodosPedidos();
            MetodosCliente();
            MetodosArmazenaPedidos();
        }
        //-------------------------------------Banco de Dados interno--------------------------------------



        /// Produtos
        /// Lista de Produtos
        /// Metodo VOID
        void MetodosProdutos()
        {
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

        /// Pedidos
        /// Lista de Pedidos
        /// Metodo VOID
        void MetodosPedidos()
        {
            pedido.Add(new Pedido()
            {
                CodigoDeBarras = (UInt64)1679435689426

            });            
            pedido.Add(new Pedido()
            {
                CodigoDeBarras = (UInt64)1679435689440
            });            
            pedido.Add(new Pedido()
            {
                CodigoDeBarras = (UInt64)1
            });
            //1679435689433
        }

        /// Armazena Pedidos
        /// Lista de Pedidos
        /// Metodo VOID
        void MetodosArmazenaPedidos()
        {
            armazenaPedido.Add(new PedidoPago()
            {
                ID = 1,
                CodigoUsado = (UInt64)1,
                Cliente = "Pedro devolve o macaco",
                DataeHora = DateTime.Now.ToShortTimeString(),
                Situacao = "Em aberto",
                Valor = (double) 100

                //pedido pago n tem uma definição para codigoDeBarras
            }) ;
        }

        /// Clientes
        /// Lista de Clientes
        /// Metodo void
        void MetodosCliente()
        {
            clientes.Add(new Cliente
            {

                ID = 1,
                Nome = "Pedro Devolve o Macaco",
                DataNascimento = "16/05/2002",
                CPF = "108.634.709-98"

            });
        }
        //----------------------------------------------END-------------------------------------------------


        //---------------------------------Informações personalizadas---------------------------------------
        public string user;
        public string acesso;
        public string time;

        private void PainelInicial_Load(object sender, EventArgs e)
        {
            //-------------------------------------Salvando o acesso-----------------------------------------
            user = Form1.user;
            acesso = Form1.acess;
            lblRelogio.Text = DateTime.Now.ToShortTimeString();
            //-----------------------------------Codigo de acesso restrito------------------------------------
            lblUsuarioLogado.Text = Form1.user;
            toolStrip_lblusuario.Text = "Usuario logado: " + user;
            if (Form1.acess != "Total")
            {
                btnProdutos.Visible = false;
            }
        }
        // Descrição de botões
        //private void timerTempoReal_Tick(object sender, EventArgs e)
        //{
        //    lblRelogio.Text = (time = DateTime.Now.ToShortTimeString());
        //}

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

        //-------------------------------------------Minimizar, Maximizar e Fechar aplicação--------------
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar todo o Sistema, incuindo todas as telas abertas neste momento?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar todo o Sistema, incuindo todas as telas abertas neste momento?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void bntMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bntMaximizar.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            bntMaximizar.Visible = true;
            btnNormal.Visible = false;
        }

        //Leave
        private void LeaveMinimizar(object sender, EventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        private void LeaveMaximizar(object sender, EventArgs e)
        {
            bntMaximizar.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        private void LeaveFechar(object sender, EventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        private void LeaveNormal(object sender, EventArgs e)
        {
            btnNormal.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        //Mouse move em cima
        private void controlFechar(object sender, MouseEventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.Red;
        }
        private void controlMaximizar(object sender, MouseEventArgs e)
        {
            bntMaximizar.FlatAppearance.BorderColor = Color.Gainsboro;
            
        }
        private void controlMinimizar(object sender, MouseEventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.Gainsboro;
            
        }
        private void controlNormal(object sender, MouseEventArgs e)
        {
            btnNormal.FlatAppearance.BorderColor = Color.Gainsboro;
        }
        //-----------------------------------------------------------------------------------------------

        //-------------------------------Mostrar painel com botões de Aplicativos-------------------------
        private void bntMostrarAplicações_Click(object sender, EventArgs e)
        {
            if (!panelAplicações.Visible)
            {
                panelAplicações.Visible = true;
                return;
            }
            panelAplicações.Visible = false;
        }
        //---------------------------start Sequencia de EVENTOS abertura das outras Telas-----------------
        private void bntPagamento_Click_1(object sender, EventArgs e)
        {
            if (TelaPag == false)
                Tela_de_Pagamentos();
        }
        private void bntVendas_Click_1(object sender, EventArgs e)
        {
            if (TelaVend == false)
                Tela_de_Vendas();
        }

        private void bntProdutos_Click(object sender, EventArgs e)
        {
            if (TelaProd == false)
                Tela_de_Produtos();
        }

        ////           Ferramentas
        /// Lista de feramentas do Tool Strip
        // 
        // Pagamento
        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaPag == false)
                Tela_de_Pagamentos();
        }
        //
        //Pedidos
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaVend == false)
                Tela_de_Vendas();
        }
        //
        //Produtos
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaProd == false)
                Tela_de_Produtos();
        }
        //
        //Bloco de Notas
        private void BlocoAnotaçõestoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NotePad notePad = new NotePad();
            notePad.MdiParent = this;
            notePad.Show();
        }
        //
        //Fechar todas as Abas
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            TelaPag = false;
            TelaVend = false;
            TelaProd = false;
            TelaRegPagamento = false;
            TelaRegPedidos = false;
            TelaRegProdutos = false;
            TelaRegClientes = false;
        }

        ////            Consultas
        /// Lista de feramentas para consultas
        //
        //Registro de Pagamentos
        private void RegPagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //
        //Registro de Pedidos 
        private void RegPedidostoolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        //
        //Registros de Produtos 
        private void RegProdutostoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TelaRegProdutos == false)
                Tela_de_RegistrosProdutos();
        }
        //
        //Registro de Clientes
        private void RegClientestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TelaRegClientes == false)
                Tela_de_RegistrosClientes();
        }
        //-------------------------End Sequencia de EVENTOS abertura das outras Telas---------------------

        //---------------------------start Sequencia de EVENTOS abertura das outras Telas-----------------
        public bool TelaVend = false, TelaPag = false, TelaProd = false,
                    TelaRegPagamento = false, TelaRegPedidos = false, TelaRegProdutos = false,
                    TelaRegClientes = false;

        private void Tela_de_Vendas()
        {
            APSvendas apsVendas = new APSvendas(this, produtos, pedido, clientes);
            apsVendas.inicial1 = this;
            apsVendas.MdiParent = this;
            apsVendas.Show();
            TelaVend = true;
        }

        private void Tela_de_Pagamentos()
        {
            APSpagamento apsPagamento = new APSpagamento();
            apsPagamento.MdiParent = this;
            apsPagamento.Show();
            TelaPag = true;
        }

        private void Tela_de_Produtos()
        {
            APSprodutos apsProdutos = new APSprodutos(this, produtos);
            apsProdutos.MdiParent = this;
            apsProdutos.Start = this;
            apsProdutos.Show();
            TelaProd = true;
        }

        //private void Tela_de_RegistrosPagamentos()
        //{
        //    RegClientes registro = new RegClientes(this, clientes);
        //    registro.MdiParent = this;
        //    registro.Show();
        //    TelaRegPagamento = true;
        //}

        //private void Tela_de_RegistrosPedidos()
        //{
        //    RegClientes registro = new RegClientes(this, clientes);
        //    registro.MdiParent = this;
        //    registro.Show();
        //    TelaRegPedidos= true;
        //}

        private void Tela_de_RegistrosProdutos()
        {
            RegProdutos registro = new RegProdutos(this, produtos);
            registro.MdiParent = this;
            registro.Show();
            TelaRegProdutos = true;
        }

        private void Tela_de_RegistrosClientes() 
        {
            RegClientes registro = new RegClientes(this, clientes);
            registro.MdiParent = this;
            registro.Show();
            TelaRegClientes = true;
        }

        //-------------------------End Sequencia de EVENTOS abertura das outras Telas---------------------

        //-----------------------------start APSprodutos LISTA de PRODUTOS---------------------------------       
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
            foreach (Produto produto in produtos)
            {
                if (codigo == produto.ID)
                {
                    produto.Descricao = descricao;
                    produto.Quantidade = quantidade;
                    produto.Valor = valor;
                }
            }
        }
        //------------------------------end APSprodutos LISTA de PRODUTOS----------------------------------

        //-------------------------------start APSvendas LISTA de PEDIDOS----------------------------------       
        public void Adicionar_Cliente(string nome, string datadenascimento, string cpf)
        {
            
            clientes.Add(new Cliente()
            { 
                ID = identifyClient(),
                Nome = nome,
                DataNascimento = datadenascimento,
                CPF = cpf
            });
        }

        public int identifyClient()
        {
            int i = 1;
            foreach (Cliente cliente in clientes)
            {
                if (i != cliente.ID)
                {
                    return i;
                }
                i++;
            }
            return i++;
            
        }
        
        public void salvaPedido(UInt64 codeBar, string clientName, string clientCPF, double valorTotal, List<Produto> carrinho)
        {
            pedido.Add(new Pedido()
            {
                ID = identifyPedido(),
                CodigoDeBarras = codeBar,
                DataEHora = DateTime.Now.ToString("g"),
                ClientName = clientName,
                ClientCPF = clientCPF,
                Carrinho = carrinho,
                Situacao = "Em aberto",
                ValorTotal = valorTotal
            });

        }
        //tem tudo isso de atributo pra salvar
        //os que estão prontos são ID, CodeBar, DataeHora, ClientName, ClientCPF
        //falta o carrinho situação(gera automatico então é suave) e valor
        //olha teu disc

        public int identifyPedido()
        {
            int i = 1;
            foreach (Pedido pedido in pedido)
            {
                if (i != pedido.ID)
                {
                    return i;
                }
                i++;
            }
            return i++;
        }

        public void atualidaDataGrid()
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = clientes;
        }
        //--------------------------------end APSvendas LISTA de PEDIDOS-----------------------------------

        //---------------------------------start Tool Strip EVENTOS----------------------------------------



        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Empty);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }



        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //-----------------------------------end Tool Strip EVENTOS----------------------------------------

    }
}
