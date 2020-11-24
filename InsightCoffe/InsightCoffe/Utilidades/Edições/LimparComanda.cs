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

namespace InsightCoffe.Utilidades.Edições
{
    public partial class LimparComanda : Form
    {
        public PainelInicial inicial1;

        public LimparComanda(PainelInicial inicial, List<Pedido> pedido)
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
            this.Close();
            inicial1.TelaLimparComanda = false;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Leave
        private void LeaveFechar(object sender, EventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        private void LeaveMinimizar(object sender, EventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        //Control
        private void controlFechar(object sender, MouseEventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.Red;
        }
        private void controlMinimizar(object sender, MouseEventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.Gainsboro;

        }
        //----------------------------------------------------------------------------------------------

        //-------------------------------start: Codigos de ativação de pedido--------------------------------
        uint codigoDBarra;
        private void enterPedido()
        {
            if (Pedido.codigoExistente(inicial1.pedido, mskBCodeBar.Text) == true)
            {
                codigoDBarra = Convert.ToUInt16(mskBCodeBar.Text);
                foreach (Pedido pedido in inicial1.pedido)
                {
                    if (Pedido.reativarPedido(inicial1.pedido, mskBCodeBar.Text) == true)
                    {
                        mskBValortotal.Mask = null;
                        mskBValortotal.Text = pedido.ValorTotal.ToString("C2");
                        mskSituacao.Text = pedido.Situacao;
                        lsViewCarrinho.DataSource = pedido.Carrinho;

                        btnLimpar.Enabled = true;
                        return;
                    }
                }
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
            if (e.KeyChar == (char)Keys.Enter && mskBCodeBar.Text != "")
            {
                enterPedido();
            }
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar totalmente esta comanda?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Pedido.limparPedido(inicial1.pedido, codigoDBarra);
            
            lsViewCarrinho.DataSource = null;

            mskBCodeBar.ResetText();
            mskSituacao.ResetText();
            mskBValortotal.ResetText();
            mskBValortotal.Mask = "$";

            btnLimpar.Enabled = false;
        }

    }
}
