using InsightCoffe.Classes;
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

namespace InsightCoffe.Utilidades.Edições
{
    public partial class EdicaoCliente : Form
    {
        public PainelInicial inicial1 { get; set; }

        public EdicaoCliente(PainelInicial inicial, List<Cliente> clientes)
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
            if (MessageBox.Show("Deseja fechar esta janela?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            this.Close();
            inicial1.TelaEdtCliente = false;
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
        //------------------------------Start: Classes -------------------------------------------------
        
        //------------------------------end: Classes ---------------------------------------------------
        //-------------------------Start: Botão ----------------------------------------------
        private void maskedBCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && mskBCPF.Text != "")
            {
                btnPesq_Click(sender, e);
            }
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = false;  
        }

        private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txbNome.Text != "")
            {
                btnPesq_Click(sender, e);
            }
        }
        //-------------------------end: Botão ------------------------------------------------
        //-------------------------start: Method ---------------------------------------------
        string Cpf;
        public void BtnEditar()
        {
            Cpf = mskBCPF.Text;

            string message = "Tem certeza disso?";
            string title = "Atenção!!";

            if (ValidaCliente.filtroCPF(Cpf) == true)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.No) 
                { 
                    MessageBox.Show("Alteração cancelada!", title); 
                    return;
                }

                foreach (Cliente cliente in inicial1.clientes)
                {
                    if (Cpf == cliente.CPF) 
                    {
                        cliente.Nome = txbNome.Text;
                        cliente.DataNascimento = mskBDate.Text;
                        cliente.CPF = mskBCPF.Text;

                        MessageBox.Show("Alteração concluida!");

                        txbNome.ResetText();
                        txbID.ResetText();
                        mskBCPF.ResetText();
                        mskBDate.ResetText()
                        return;
                    }
                }
            }
            else 
            {
                MessageBox.Show("CPF Inválido!", title);
            }
        }

        private bool clienteSearch()
        {
            try
            {
                foreach (Cliente cliente in inicial1.clientes)
                {
                    if (mskBCPF.Text == cliente.CPF || cliente.Nome.StartsWith(txbNome.Text))
                    {
                        txbNome.Text = cliente.Nome;
                        mskBCPF.Text = cliente.CPF;
                        mskBDate.Text = cliente.DataNascimento;
                        lblCompras.Text = cliente.Compras.ToString();
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

        //-------------------------end: Method ---------------------------------------------
        //-------------------------Start: Buttons ------------------------------------------

        private void btnPesq_Click(object sender, EventArgs e)
        {
            if (clienteSearch() != true)
            {
                MessageBox.Show("Cliente não encontrado!", "Atenção!"); return;
            }
            btnEdit.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BtnEditar();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            txbID.Text = Cliente.identifyClient(inicial1.clientes).ToString();
            btnADD.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCliente.filtroCPF(mskBCPF.Text) && ValidaCliente.filtroNascimento(mskBDate.Text) && ValidaCliente.filtroNome(txbNome.Text) == true)
            {
                Cliente.adiconaCliente(inicial1.clientes, Cliente.identifyClient(inicial1.clientes), txbNome.Text, mskBDate.Text, mskBCPF.Text);
            }
            else
                MessageBox.Show("Veja se inseriu todos os campos corretamente!", "Atenção!!");

        }




        //-------------------------end: Buttons --------------------------------------------
    }

}
