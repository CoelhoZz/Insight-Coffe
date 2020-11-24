using InsightCoffe.Entity;
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
    public partial class APSpagamento : Form
    {
        PainelInicial inicial1;
        public APSpagamento(PainelInicial inicial)
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
            inicial1.TelaPag = false;
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
        private void APSpagamento_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------start:Cliente------------------------------------------------
        //-------------------------------start: Codigos de ativação de pedido--------------------------------
        uint codigoDBarra;
        string cpf;
        List<Produto> salvaCarrinho = new List<Produto>();

        private void enterPedido()
        {
            if (Pedido.reativarPedido(inicial1.pedido, mskBCodeBar.Text) == true)
            {
                codigoDBarra = Convert.ToUInt32(mskBCodeBar.Text);
                foreach (Pedido pedido in inicial1.pedido)
                {
                    if (pedido.CodigoDeBarras == codigoDBarra)
                    {
                        lblID.Text = pedido.ID.ToString();
                        cpf = mskBCPF.Text = pedido.ClientCPF;
                        mskBNome.Text = pedido.ClientName;
                        lblData.Text = pedido.DataEHora;
                        lsViewCarrinho.DataSource = salvaCarrinho = pedido.Carrinho;

                        mskValorTotal.Mask = null;
                        mskValorTotal.Text = pedido.ValorTotal.ToString("C2");
                        mskSituação.Text = pedido.Situacao;
                        mskSituação.Enabled = false;
                        if (mskSituação.Text == "Em aberto")
                            btnEndSale.Enabled = true;
                        else
                            btnEndSale.Enabled = false;

                        mskBCodeBar.Enabled = false;
                        btnEnterPedido.Enabled = false;

                        return;
                    }
                }
                MessageBox.Show("Codigo não cadastrado!!", "Atenção!");

            }
            else
            {
                MessageBox.Show("Pedido vazio!!", "Atenção!");
            }
        }

        private void btnEnterPedido_Click(object sender, EventArgs e)
        {
            enterPedido();
        }

        private void KeyPress_CodigoBar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && mskBCodeBar.Text != "")
            {
                enterPedido();
            }
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public void Limpar_Pagamento()
        {
            mskBCodeBar.ResetText();
            mskBCodeBar.Enabled = true;

            mskBNome.ResetText();
            mskBCPF.ResetText();
            mskValorTotal.ResetText();
            mskSituação.ResetText();
            lblData.Text = "00/00/0000 00:00";

            lsViewCarrinho.DataSource = null;

        }
        //-----------------------------------end: Codigos de ativação de pedido-------------------------------

        //--------------------------------------start:Cliente-------------------------------------------------


        private void maskedValorCompra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnEndSale_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja encerrar o pedido?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if ((Pedido.limparPedido(inicial1.pedido, codigoDBarra) && (Cliente.atualizaCompra(inicial1.clientes, cpf))) == true)
                {
                    string cliente;
                    if (cpf != "null")
                        cliente = mskBNome.Text + "  " + cpf;
                    else
                        cliente = mskBNome.Text;

                    inicial1.armazenaPedido.Add(new Pagamentos()
                    {
                        ID = Pagamentos.geradorId(inicial1.armazenaPedido),
                        CodigoUsado = codigoDBarra,
                        Cliente = cliente,
                        DataeHora = lblData.Text,
                        Situacao = "Pedido finalizado",
                        Carrinho = salvaCarrinho,
                        Valor = Convert.ToDouble(mskValorTotal.Text.Replace("R$", ""))
                    });
                    Limpar_Pagamento();
                }
            }

        }
        //----------------------------------------end:Cliente-------------------------------------------------

    }
}
