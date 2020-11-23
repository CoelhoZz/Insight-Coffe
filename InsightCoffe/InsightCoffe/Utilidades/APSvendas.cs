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
            if (MessageBox.Show("Certifique-se de que salvou o pedido. Deseja fechar a janela atual?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
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

        //---------------------------------------------------------------------------------------------------

        //---------------------------------------start: Variaveis--------------------------------------------
        Int32 codigoDBarra;
        string nome, cpf;
        double valorTotal;
        //----------------------------------------end: Variaveis---------------------------------------------

        //-------------------------------start: Codigos de ativação de pedido--------------------------------
        private void enterPedido()
        {
            if (Pedido.codigoExistente(inicial1.pedido, mskBCodeBar.Text) == true)
            
            {
                codigoDBarra = Convert.ToInt32(mskBCodeBar.Text);
                foreach (Pedido pedido in inicial1.pedido)
                {
                    if (Pedido.reativarPedido(inicial1.pedido, mskBCodeBar.Text) == true)
                    {
                        mskBCPF.Text = pedido.ClientCPF;
                        clienteSearch();
                        lsViewCarrinho.DataSource = carrinho = pedido.Carrinho;
                        habilitarCarrinho();
                        return;
                    }
                }
                habilitar_BotõesCliente();
                mskBCodeBar.Enabled = false;
                btnEnterPedido.Enabled = false;

                btnSalvarPedido.Enabled = true;
                btnCancelarPedido.Enabled = true;
            }
            else
            {
                MessageBox.Show("Insira um codigo de barras válido!!", "Atenção!");
            }
        }

        private void btnEnterPedido_Click(object sender, EventArgs e)
        {
            enterPedido();
        }

        private void KeyPress_CodigoBar(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter && mskBCodeBar.Text != "")
            {
                enterPedido();
            }
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void habilitarCarrinho()
        {
            mskAdicionarItem.Enabled = true;
            mskBRetirarItem.Enabled = true;
            numUDQtdItemRetirar.Enabled = true;
            mskBValorItemRetirado.Enabled = true;
            numUDQtdItemAdicionar.Enabled = true;
            mskBValorAdicionar.Enabled = true;

            btnAdicionar.Enabled = true;
            btnLimparAdicionar.Enabled = true;

            btnSalvarPedido.Enabled = true;
            btnCancelarPedido.Enabled = true;
        }

        private void desabilitarCarrinho()
        {
            lblDesconto.Visible = false; 
            mskAdicionarItem.Enabled = false;
            mskBRetirarItem.Enabled = false;
            numUDQtdItemRetirar.Enabled = false;
            mskBValorItemRetirado.Enabled = false;
            numUDQtdItemAdicionar.Enabled = false;
            mskBValorAdicionar.Enabled = false;

            btnRetirar.Enabled = false;
            btnLimparRetirar.Enabled = false;
            btnAdicionar.Enabled = false;
            btnLimparAdicionar.Enabled = false;
        }

        public void salvarEcancelar_Pedido()
        {
            mskBCodeBar.ResetText();
            mskBCodeBar.Enabled = true;

            mskBNome.ResetText();
            mskBCPF.ResetText();
            mskBNascimento.ResetText();
            mskBRetirarItem.ResetText();
            mskBValortotal.ResetText();
            mskBValorAdicionar.ResetText();
            mskBValorItemRetirado.ResetText();

            numUDQtdItemRetirar.ResetText();
            numUDQtdItemAdicionar.ResetText();

            comboBoxAdicionar.ResetText();
            lsViewCarrinho.DataSource = null;
            btnSalvarPedido.Enabled = false;
            btnCancelarPedido.Enabled = false;
        }
        //-----------------------------------end: Codigos de ativação de pedido---------------------------------

        //---------------------------Start: Metodos Habilitar/Desabilitar de Clientes----------------------------
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
            mskBNome.BackColor = Color.White;
            mskBNascimento.Enabled = true;
            mskBNascimento.BackColor = Color.White;
            mskBCPF.Enabled = true;
            mskBCPF.BackColor = Color.White;

        }        
        
        private void desabilita_CamposCliente()
        {
            btnSalvar.Enabled = false;
            btnProcurar.Enabled = false;
            btnLimparClient.Enabled = false;

            mskBNome.Enabled = false;
            mskBNome.BackColor = Color.LightGray;
            mskBNascimento.Enabled = false;
            mskBNascimento.BackColor = Color.LightGray;
            mskBCPF.Enabled = false;
            mskBCPF.BackColor = Color.LightGray;
        }

        public int ItemDesconto = 8;
        private bool clienteSearch()
        {
            try
            {
                //string clienteCPF = (mskBCPF.Text).ToString();
                //string clienteNome = (mskBNome.Text).ToString();
                foreach (Cliente cliente in inicial1.clientes)
                {
                    if (mskBCPF.Text == cliente.CPF || mskBNome.Text == cliente.Nome)
                    {
                        nome = mskBNome.Text = cliente.Nome;
                        cpf = mskBCPF.Text = cliente.CPF;
                        mskBNascimento.Text = cliente.DataNascimento;
                        if (cliente.Compras == 0)
                        {
                            lblDesconto.Text = Pedido.GetDescontos(inicial1.produtos, carrinho, ItemDesconto);
                            lblDesconto.Visible = true;
                            AddProdutoToDList();
                        }   
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //-------------------------end: Metodos Habilitar/Desabilitar de Clientes-----------------------

        //------------------------------Start: Codigo ativação Cliente----------------------------------
        private void btnIncluirCliente_Click(object sender, EventArgs e)
        {
            desabilitar_BotõesCliente();
            habilita_CamposCliente();
        }

        private void btnPular_Click(object sender, EventArgs e)
        {
            desabilitar_BotõesCliente();
            habilitarCarrinho();
            nome = "Cliente";
            cpf = "null";
            inicial1.clientes.Add(new Cliente()
            {
                Nome = "Cliente",
                DataNascimento = "null",
                CPF = "null"
            });
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCliente.filtroNascimento(mskBNascimento.Text) == false || ValidaCliente.filtroNome(mskBNome.Text) == false || ValidaCliente.filtroCPF(mskBCPF.Text) == false) return;

            if(Cliente.checkCliente(inicial1.clientes, mskBCPF.Text) == true)
            {
                MessageBox.Show("Cliente já esta registrado no sistema, tente outro CPF", "Alerta");
                mskBCPF.Clear();
                return;
            }
            nome = mskBNome.Text;
            cpf = mskBCPF.Text;
            //Conceder Desconto
            lblDesconto.Text = Pedido.GetDescontos(inicial1.produtos, carrinho, ItemDesconto);
            lblDesconto.Visible = true;
            AddProdutoToDList();

            //Adicionando as Listas nescessarias
            Cliente.adiconaCliente(inicial1.clientes, Cliente.identifyClient(inicial1.clientes), mskBNome.Text, mskBNascimento.Text, mskBCPF.Text);

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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (clienteSearch() == false)
            {
                MessageBox.Show("Cliente não encontrado, certifique-se que pesquisou corrtamente. Pesquisas são feitas aparir do \"Nome\" ou \"Cpf\" ", "Atenção!");
                return;
            }
            else
            {
                desabilitar_BotõesCliente();
                desabilita_CamposCliente();

                Cliente.adiconaCliente(inicial1.clientes, Cliente.identifyClient(inicial1.clientes), mskBNome.Text, mskBNascimento.Text, mskBCPF.Text);
                habilitarCarrinho();
            }
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

        //----------------------------------Start: Classes do Carrinho-----------------------------------
        private void AddProdutoToDList()
        {
            lsViewCarrinho.DataSource = null;
            lsViewCarrinho.DataSource = carrinho;

            mskBValortotal.Mask = null;
            mskBValortotal.Text = Pedido.CalculoPreco(carrinho).ToString("C2");
            valorTotal = Pedido.CalculoPreco(carrinho);
            if (carrinho.Count() >= 1)
            {
                btnLimparRetirar.Enabled = true;
                btnRetirar.Enabled = true;
            }
            else
            {
                btnLimparRetirar.Enabled = false;
                btnRetirar.Enabled = false;
            }
        }

        //--Start Metodos:Retirar
        public void cleanRet()
        {
            comboBoxRetirar.Text = "";
            comboBoxRetirar.Items.Clear();
            numUDQtdItemRetirar.Value = 1;
            mskBRetirarItem.Clear();
            mskBValorItemRetirado.Clear();
            lblID.Text = "";
        }

        private void Retirar_items_CombBox()
        {
            comboBoxRetirar.Text = mskBRetirarItem.Text;
            try
            {
                comboBoxRetirar.Items.Clear();
                foreach (Produto list in carrinho)
                {
                    if (Convert.ToInt32(mskBRetirarItem.Text) == list.ID)
                    {
                        comboBoxRetirar.Items.Add(list.Descricao);
                        comboBoxRetirar.DroppedDown = true;
                        return;
                    }
                }
            }
            catch (Exception)
            {
                foreach (Produto list in carrinho)
                {
                    if (list.Descricao.StartsWith(mskBRetirarItem.Text))
                    {
                        comboBoxRetirar.Items.Add(list.Descricao);
                        comboBoxRetirar.DroppedDown = true;
                    }
                }
            }
        }

        private void TextChanged_mskRetirar(object sender, EventArgs e)
        {
            try
            {
                Retirar_items_CombBox();
                comboBoxRetirar.Text = mskAdicionarItem.Text;
                comboBoxRetirar.Enabled = true;
                comboBoxRetirar.DropDownStyle = ComboBoxStyle.DropDownList;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Valor inserido é invalido");
                comboBoxRetirar.DropDownStyle = ComboBoxStyle.Simple;
                return;
            }
        }

        private void Puxar_itemRetirar()
        {
            if (mskBRetirarItem.Text == "" || mskBRetirarItem.Text == "0")
            {
                MessageBox.Show("Digite algo valido para chamar um produto");
                return;
            }
            else
            {
                try
                {
                    foreach (Produto list in carrinho)
                    {
                        if (Convert.ToInt32(mskBRetirarItem.Text) == list.ID)
                        {
                            lblID.Text = list.ID.ToString();
                            mskBRetirarItem.Text = (list.Descricao);
                            numUDQtdItemRetirar.Maximum = Convert.ToDecimal(list.Quantidade);
                            numUDQtdItemRetirar.Value = Convert.ToDecimal(list.Quantidade);
                            mskBValorItemRetirado.Text = list.Valor.ToString("C2");
                            return;
                        }
                    }
                }
                catch (Exception)
                {
                    foreach (Produto list in carrinho)
                    {
                        if (mskBRetirarItem.Text == list.Descricao || list.Descricao.StartsWith(mskBRetirarItem.Text))
                        {
                            lblID.Text = list.ID.ToString();
                            mskBRetirarItem.Text = (list.Descricao);
                            numUDQtdItemRetirar.Value = Convert.ToDecimal(list.Quantidade);
                            numUDQtdItemRetirar.Maximum = Convert.ToDecimal(list.Quantidade);
                            mskBValorItemRetirado.Text = list.Valor.ToString("C2");
                            return;
                        }
                    }
                }
            }
        }

        public void retirarItem()
        {
            foreach (Produto produto in carrinho)
            {
                if (produto.Descricao == mskBRetirarItem.Text)
                {
                    if ((Convert.ToInt32(produto.Quantidade) - (int)numUDQtdItemRetirar.Value) == 0)
                    {
                        carrinho.Remove(new Produto
                        {
                            ID = Convert.ToInt32(lblID.Text),
                            Descricao = mskBRetirarItem.Text,
                            Quantidade = Convert.ToString((int)numUDQtdItemRetirar.Value),
                            Valor = Convert.ToDouble((mskBValorItemRetirado.Text).Replace("R$", " "))
                        });
                        lblID.Text = "";
                        return;
                    }
                    else
                    {
                        produto.Quantidade = (Convert.ToInt32(produto.Quantidade) - (int)numUDQtdItemRetirar.Value).ToString();
                        produto.Valor = Convert.ToDouble((mskBValorItemRetirado.Text).Replace("R$", ""));
                        return;
                    }
                }
            }
        }
        //--End Metodos:Retirar

        //--Start Metodos:Adicionar
        public void cleanAdd()
        {
            comboBoxAdicionar.Text = "";
            comboBoxAdicionar.Items.Clear();
            mskAdicionarItem.Clear();
            numUDQtdItemAdicionar.Value = 1;
            mskBValorAdicionar.Clear();
        }

        private void Adcionar_items_CombBox()
        {
            comboBoxAdicionar.Text = mskAdicionarItem.Text;
            try
            {
                comboBoxAdicionar.Items.Clear();
                foreach (Produto list in inicial1.produtos)
                {
                    if (Convert.ToInt32(mskAdicionarItem.Text) == list.ID)
                    {
                        comboBoxAdicionar.Items.Add(list.Descricao + " " + list.Quantidade);
                        comboBoxAdicionar.DroppedDown = true;
                        return;
                    }
                }
            }
            catch (Exception)
            {
                foreach (Produto list in inicial1.produtos)
                {
                    if (list.Descricao.StartsWith(mskAdicionarItem.Text))
                    {
                        comboBoxAdicionar.Items.Add(list.Descricao + " " + list.Quantidade);
                        comboBoxAdicionar.DroppedDown = true;
                    }
                }
            }
        }

        private void TextChanged_mskAdicionar(object sender, EventArgs e)
        {
            try
            {
                comboBoxAdicionar.Text = mskAdicionarItem.Text;
                comboBoxAdicionar.Enabled = true;
                comboBoxAdicionar.DropDownStyle = ComboBoxStyle.DropDownList;
                Adcionar_items_CombBox();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Valor inserido é invalido");
                comboBoxAdicionar.DropDownStyle = ComboBoxStyle.Simple;
                return;
            }
        }

        private void Puxar_itemAdicionar()
        {
            try
            {
                foreach (Produto list in inicial1.produtos)
                {
                    if (Convert.ToInt32(mskAdicionarItem.Text) == list.ID)
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
                    if (mskAdicionarItem.Text == (list.Descricao + " " + list.Quantidade) || list.Descricao.StartsWith(mskAdicionarItem.Text))
                    {
                        mskAdicionarItem.Text = (list.Descricao + " " + list.Quantidade);
                        mskBValorAdicionar.Text = list.Valor.ToString("C2");
                        return;
                    }
                }
            }
            MessageBox.Show("Digite algo valido para chamar um produto");
            return;
        }

        public bool adicionarItem()
        {
            foreach (Produto produto in carrinho)
            {
                if (produto.Descricao == mskAdicionarItem.Text)
                {
                    produto.Quantidade = (Convert.ToInt32(produto.Quantidade) + (int)numUDQtdItemAdicionar.Value).ToString();
                    produto.Valor = produto.Valor + Convert.ToDouble(mskBValorAdicionar.Text.Replace("R$", " "));
                    return true;
                }
            }
            return false;
        }
        //--End: Metodos:Adicionar
        //----------------------------------end: Classes do Carrinho-------------------------------------

        //--------------------------------Start: Adcionar/Limpar e Retirar/Limpar------------------------
        //--Start: Adicionar Item
        private void numUDQtdItemAdicionar_ValueChanged(object sender, EventArgs e)
        {
            mskBValorAdicionar.Text = Carrinho.valor_unidade(mskAdicionarItem.Text, (double)numUDQtdItemAdicionar.Value, inicial1.produtos);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (mskAdicionarItem.Text == "" || numUDQtdItemAdicionar.Value == 0 || mskBValorAdicionar.Text == "0")
                return;

            string descição = mskAdicionarItem.Text;
            string quantidade = Convert.ToString((int)numUDQtdItemAdicionar.Value);
            double valor = Convert.ToDouble((mskBValorAdicionar.Text).Replace("R$", " "));
            if(adicionarItem() == false)
            {
                carrinho.Add(new Produto
                {
                    ID = Produto.geradorId(carrinho),
                    Descricao = descição,
                    Quantidade = quantidade,
                    Valor = valor
                });
            }
            AddProdutoToDList();
            cleanAdd();
        }

        private void SelectItem_cbBox(object sender, EventArgs e)
        {
            try
            {
                if (mskAdicionarItem.Text == "")
                    mskAdicionarItem.Text = comboBoxAdicionar.Text;
                Puxar_itemAdicionar();
                comboBoxAdicionar.Enabled = false;
                comboBoxAdicionar.DropDownStyle = ComboBoxStyle.Simple;
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
                    Puxar_itemAdicionar();
                    comboBoxAdicionar.Enabled = false;
                    comboBoxAdicionar.DropDownStyle = ComboBoxStyle.Simple;
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void btnLimparAdicionar_Click(object sender, EventArgs e)
        {
            cleanAdd();
        }
        //--End: Adicionar Item

        //--Start: Retirar Item
        private void numUDQtdItemRetirar_ValueChanged(object sender, EventArgs e)
        {
            mskBValorItemRetirado.Text = Carrinho.valor_unidade(mskBRetirarItem.Text, (double)numUDQtdItemRetirar.Value, inicial1.produtos);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (mskBRetirarItem.Text == "" || numUDQtdItemRetirar.Value == 0 || mskBRetirarItem.Text == "0" || lblID.Text == "0")
                return;

            retirarItem();
            AddProdutoToDList();
            cleanRet();
        }

        private void SelectItemRetirar_cbBox(object sender, EventArgs e)
        {
            try
            {
                if (mskBRetirarItem.Text == "")
                    mskBRetirarItem.Text = comboBoxRetirar.Text;
                Puxar_itemRetirar();
                comboBoxRetirar.Enabled = false;
                comboBoxRetirar.DropDownStyle = ComboBoxStyle.Simple;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void KeyPress_mskRetirar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    comboBoxRetirar.Enabled = false;
                    comboBoxRetirar.DropDownStyle = ComboBoxStyle.Simple;
                    Puxar_itemRetirar();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void btnLimparRetirar_Click(object sender, EventArgs e)
        {
            cleanRet();
        }
        //--End: Retirar Item
        //---------------------------------Start: Finalização Pedido-------------------------------------

        public bool ExisteItem()
        {
            if (carrinho.Count == 0)
                return false;
            else
                return true;
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            
            if(ExisteItem() == true)
            {
                try
                {
                    salvarEcancelar_Pedido();
                    inicial1.salvaPedido(codigoDBarra, nome, cpf, valorTotal, carrinho);
                    carrinho = new List<Produto>();
                }
                catch(Exception)
                {
                    MessageBox.Show("Ta errado pr-+");
                }
            }
            else
            {
                MessageBox.Show("Carrinho vazio");
            }
            desabilitarCarrinho();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            inicial1.Tela_de_Vendas();
            this.Close();
        }
        //----------------------------------end: Finalização Pedido---------------------------------------

    }
}
