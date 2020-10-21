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
    public partial class APSvendas : Form
    {
        PainelInicial inicial1;

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
            if (MessageBox.Show("Deseja fechar todo o Sistema, incuindo todas as telas abertas neste momento?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
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
            }
        }
        //------------------------------end: Codigos de ativação de pedido------------------------------
        //------------------------------Start: Methods -------------------------------------------------
        private void adicionarPedido()
        {
            try
            {
                UInt64 codigoBarra = Convert.ToUInt64(maskedBCodeBar.Text);
                foreach (Pedido pedido in inicial1.pedido)
                {
                    if (codigoBarra == pedido.CodigoDeBarras)
                    {
                        habilitarCliente();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um codigo de barras válido!!", "Atenção!");
            }
        }

        bool novoCliente = false;

        private void habilitarCliente()
        {
            btnNovoCliente.Enabled = true;

            btnExistente.Enabled = true;
        }
        
        private void habilitarCarrinho()
        {
            maskedBRetirarItem.Enabled = true;

            numUDQtdItem.Enabled = true;

            maskedBValorItem.Enabled = true;

            maskTBCodigoDeBarras.Enabled = true;

            maskedBQtdCode.Enabled = true;

            maskedBValorCode.Enabled = true;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            maskedBNome.Enabled = true;

            maskedBCPF.Enabled = true;

            maskedBNascimento.Enabled = true;

            novoCliente = true;
        }

        private void btnExistente_Click(object sender, EventArgs e)
        {
            maskedBCPF.Enabled = true;
        }

        private void KeyDown_CPF(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {        
                    clienteSearch();
            }
        }
        
        private void clienteSearch()
        {
            try
            {
                string clienteCPF = (maskedBCPF.Text).ToString();
                foreach (Cliente cliente in inicial1.clientes)
                {
                    if (clienteCPF == cliente.CPF)
                    {
                        maskedBNome.Text = cliente.Nome;
                        maskedBNascimento.Text = cliente.DataNascimento;
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um CPF válido!!", "Atenção!");
            }
        }

        //------------------------------end: Methods ---------------------------------------------------
    }
}
