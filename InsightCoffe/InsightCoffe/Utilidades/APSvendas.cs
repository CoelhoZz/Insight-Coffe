using InsightCoffe.Classes;
using InsightCoffe.Entity;
using InsightCoffe.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightCoffe.Utilidades
{
    public partial class APSvendas : Form
    {
        List<Produto> carrinho = new List<Produto>();
        List<Cliente> clientePedido = new List<Cliente>(1);

        
        public PainelInicial inicial1 { get; set; }

        public APSvendas(PainelInicial inicial, List<Produto> produtos, List<Pedido> pedido, List<Cliente> clientes)
        {
            InitializeComponent();
            this.inicial1 = inicial;
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

        //------------------------------Minimizar, Maximizar e Fechar aplicação---------------------------
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Certifique-se de que salvou o pedido" + "\n" + "Deseja fechar a janela atual?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            this.Close();
            inicial1.TelaVend = false;
        }

        private void bntMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bntMaximizar.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
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
        //Control
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

        //----------------------------------------------------------------------------------------------

        //----------------------------start: Codigos de ativação de pedido------------------------------
        private void KeyPress_CodigoBar(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void KeyDown_CodigoBar(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                adicionarPedido();
                mskBCodeBar.Enabled = false;
            }
        }
        //------------------------------end: Codigos de ativação de pedido------------------------------

        //------------------------------Start: Classes -------------------------------------------------
        private bool checkCliente(string cpf)
        {
            foreach (Cliente cliente in inicial1.clientes)
            {
                if (cpf == cliente.CPF)
                {
                    return true;
                }
            }

            return false;
        }

        public bool filtroNascimento()
        {
            try
            {
                Nascimento = Convert.ToDateTime(mskBNascimento.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Data de nascimento inválida!", "Atenção!");
                return false;
            }
        }

        public bool filtroCPF()
        {
            Cpf = mskBCPF.Text;
            if (ValidaCPF.IsCpf(Cpf))
            {
                return true;
            }
            else
            {
                MessageBox.Show("CPF inválido!", "Atenção!");
                return false;
            }
        }

        public bool filtroNome()
        {
            if (mskBNome.Text == "")
            {
                MessageBox.Show("Nome inválido!", "Atenção!");
                return false;
            }
            else
            {
                Nome = mskBNome.Text;
                return true;

            }

        }
        //------------------------------end: Classes -------------------------------------------------

        //------------------------------Start: Methods -------------------------------------------------
        private void adicionarPedido()
        {
            try
            {
                UInt64 codigoBarra = Convert.ToUInt64(mskBCodeBar.Text);
                foreach (Pedido pedido in inicial1.pedido)
                {
                    if (codigoBarra == pedido.CodigoDeBarras)
                    {
                        habilitar_BotõesCliente();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um codigo de barras válido!!", "Atenção!");
            }
        }
        
        private void habilitarCarrinho()
        {
            mskBRetirarItem.Enabled = true;
            numUDQtdItemRetirar.Enabled = true;
            mskBValorItemRetirado.Enabled = true;
            numUDQtdItemAdicionar.Enabled = true;
            mskBValorAdicionar.Enabled = true;

            btnAdicionar.Enabled = true;
            btnLimparAdicionar.Enabled = true;
        }


        //--------------------------------------Client
        private void habilitar_BotõesCliente()
        {
            btnIncluirCampoCliente.Enabled = true;
            btnPular.Enabled = true;
        }        

        private void desabilitar_BotõesCliente()
        {
            btnIncluirCampoCliente.Enabled = false;
            btnPular.Enabled = false;
        }

        private void habilita_CamposCliente()
        {
            btnSalvar.Enabled = true;
            btnProcurar.Enabled = true;
            btnLimparClient .Enabled = true;

            mskBNome.Enabled = true;
            mskBNascimento.Enabled = true;
            mskBCPF.Enabled = true;
        }        
        
        private void desabilita_CamposCliente()
        {
            btnSalvar.Enabled = false;
            btnProcurar.Enabled = false;
            btnLimparClient.Enabled = false;

            mskBNome.Enabled = false;
            mskBNascimento.Enabled = false;
            mskBCPF.Enabled = false;
        }

        private void clienteSearch()
        {
            try
            {
                string clienteCPF = (mskBCPF.Text).ToString();
                string clienteNome = (mskBNome.Text).ToString();
                foreach (Cliente cliente in inicial1.clientes)
                {
                    if (clienteCPF == cliente.CPF || clienteNome == cliente.Nome)
                    {
                        mskBNome.Text = cliente.Nome;
                        mskBCPF.Text = cliente.CPF;
                        mskBNascimento.Text = cliente.DataNascimento;
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente não encontrado, certifique-se que pesquisou corrtamente. Pesquisas são feitas aparir do \"Nome\" ou \"Cpf\" ", "Atenção!");
                return;
            }
        }
        
        private void confirmarCliente()
        {
            Nome = mskBNome.Text;
            Cpf = mskBCPF.Text;
            Nascimento = Convert.ToDateTime(mskBNascimento.Text);

            clientePedido.Add(new Cliente()
            {
                Nome = Nome,
                DataNascimento = Nascimento.ToString("dd/MM/yyyy"),
                CPF = Cpf

            });
        }

        public void whenSalvarPedido_LockAll()
        {
            mskBCodeBar.ResetText();
            mskBNome.ResetText();
            mskBCPF.ResetText();
            mskBRetirarItem.ResetText();
            mskBValortotal.ResetText();
            mskBValorAdicionar.ResetText();
            mskBValorItemRetirado.ResetText();

            numUDQtdItemRetirar.ResetText();
            numUDQtdItemAdicionar.ResetText();

            comboBoxCodProd.ResetText();

            panelNCN.Enabled = false;
            btnIncluirCampoCliente.Enabled = false;
            btnPular.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimparClient.Enabled = false;
            btnProcurar.Enabled = false;
        }

        //------------------------------end: Methods ---------------------------------------------------

        //------------------------------Start: Codigo ativação Cliente----------------------------------
        public string Nome;
        public string Cpf;
        public DateTime Nascimento;

        private void btnIncluirPedido_Click(object sender, EventArgs e)
        {
            desabilitar_BotõesCliente();
            habilita_CamposCliente();
        }

        private void btnPular_Click(object sender, EventArgs e)
        {
            desabilitar_BotõesCliente();
            clientePedido.Add(new Cliente()
            {
                Nome = "Desconhecido(a)",
                DataNascimento = "Null",
                CPF = "Null"
            });

            habilitarCarrinho();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            clienteSearch();

            if (mskBNome.Text != "" && mskBNascimento.Text != "  /  /")
            {
                desabilitar_BotõesCliente();
                desabilita_CamposCliente();

                confirmarCliente();
                habilitarCarrinho();
            }
            else
            {
                return;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Checagem de campos preenchidos corretamente
            if (filtroNascimento() == false || filtroNome() == false || filtroCPF() == false) return;

            //Checagem para Cpf ja salvo no sistema
            if(checkCliente(Cpf) == true)
            {
                MessageBox.Show("Cliente já esta registrado no sistema, tente outro CPF", "Alerta");
                mskBCPF.Clear();
                return;
            }

            //Adicionando as Listas nescessarias
            inicial1.Adicionar_Cliente(Nome, Nascimento.ToString("dd/MM/yyyy"), Cpf);
            confirmarCliente();

            desabilitar_BotõesCliente();
            desabilita_CamposCliente();

            habilitarCarrinho();
        }

        private void btnLimparClient_Click(object sender, EventArgs e)
        {
            mskBNome.Clear();
            mskBCPF.Clear();
            mskBNascimento.Clear();
        }

        private void KeyPress_CPF(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void KeyPress_Nascimeto(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        //---------------------------------End: Codigo ativação Cliente----------------------------------

        //------------------------------Start: Codigo ativação Carrinho----------------------------------
        bool limpa_tudo = false;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparAdicionar_Click(object sender, EventArgs e)
        {
            comboBoxCodProd.Text = "";
            comboBoxCodProd.Items.Clear();
            mskAdicionarItem.Clear();
            numUDQtdItemAdicionar.ResetText();
            numUDQtdItemAdicionar.Value = 1;
            mskBValorAdicionar.Clear();
        }

        private void SelectItem_cbBox(object sender, EventArgs e)
        {
            try
            {
                mskAdicionarItem.Text = comboBoxCodProd.Text;
                Puxar_item(mskAdicionarItem.Text);
                comboBoxCodProd.Enabled = false;
                comboBoxCodProd.DropDownStyle = ComboBoxStyle.Simple;
            }
            catch (Exception)
            {
                return;
            }
        
        }

        private void KeyPress_mskAdicionar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    comboBoxCodProd.Enabled = false;
                    comboBoxCodProd.DropDownStyle = ComboBoxStyle.Simple;
                    Puxar_item(mskAdicionarItem.Text);
                    //mskAdicionarItem.Text = comboBoxCodProd.Text;
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void Puxar_item(string itemPesc)
        {
            if(itemPesc == "" || itemPesc == "0")
            {
                MessageBox.Show("Digite algo valido para chamar um produto");
                return;
            }
            else
            {
                try
                {
                    foreach (Produto list in inicial1.produtos)
                    {
                        if (Convert.ToInt32(itemPesc) == list.ID)
                        {
                            mskAdicionarItem.Text = (list.Descricao + " " + list.Quantidade);
                            mskBValorAdicionar.Text = list.Valor.ToString("C2");
                            return;
                        }
                    }
                }
                catch (Exception)
                {
                    foreach (Produto list in inicial1.produtos)
                    {
                        if (itemPesc == (list.Descricao + " " + list.Quantidade) || list.Descricao.StartsWith(itemPesc))
                        {
                            mskAdicionarItem.Text = (list.Descricao + " " + list.Quantidade);
                            mskBValorAdicionar.Text = list.Valor.ToString("C2");
                            return;
                        }
                    }
                }
            }
        }

        private void TextChanged_mskAdicionar(object sender, EventArgs e)
        {
            if (mskAdicionarItem.Text == "" || mskAdicionarItem.Text == "0" )
            {
                MessageBox.Show("Valor inserido é invalido");
                return;
            }
            else if(limpa_tudo == true)
            {
                return;
            }
            else
            {
                try
                {
                    comboBoxCodProd.Text = mskAdicionarItem.Text;
                    comboBoxCodProd.Enabled = true;
                    comboBoxCodProd.DropDownStyle = ComboBoxStyle.DropDownList;
                    Adcionar_items_CombBox();
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor inserido é invalido");
                    return;
                }
            }
        }

        private void Adcionar_items_CombBox()
        {
            comboBoxCodProd.Text = mskAdicionarItem.Text;
            try
            {
                comboBoxCodProd.Items.Clear();
                foreach (Produto list in inicial1.produtos)
                {
                    if(Convert.ToInt32(mskAdicionarItem.Text) == list.ID)
                    {
                        comboBoxCodProd.Items.Add(list.Descricao + " " + list.Quantidade);
                        comboBoxCodProd.DroppedDown = true;
                        return;
                    }
                }
            }
            catch(Exception)
            {
                foreach (Produto list in inicial1.produtos)
                {
                    if (list.Descricao.StartsWith(mskAdicionarItem.Text))
                    {
                        comboBoxCodProd.Items.Add(list.Descricao + " " + list.Quantidade);
                        comboBoxCodProd.DroppedDown = true;
                    }
                }
            }
        }


        //-------------------------------end: Codigo ativação Carrinho-----------------------------------



        //---------------------------------Start: Finalização Pedido-------------------------------------

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            whenSalvarPedido_LockAll();

            inicial1.salvaPedido(Convert.ToUInt64(mskBCodeBar.Text), mskBNome.Text, mskBCPF.Text, 100, carrinho);
            carrinho = new List<Produto>();
        }

        //----------------------------------end: Finalização Pedido---------------------------------------

    }
}
