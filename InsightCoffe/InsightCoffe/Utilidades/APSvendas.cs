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

namespace InsightCoffe.Utilidades
{
    public partial class APSvendas : Form
    {
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
                maskedBCodeBar.Enabled = false;
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

        bool novoCliente;

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
                MessageBox.Show("Esse CPF não esta cadastrado!", "Atenção!");
                return;
            }
            btnExistente.Enabled = false;
            btnProcurar.Enabled = false;
            maskedBCPF.Enabled = false;
        }

        public void filtroNascimento()
        {
            try
            {
                Nascimento = Convert.ToDateTime(maskedBNascimento.Text);
                ValidoData = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Data de nascimento inválida!", "Atenção!");
                ValidoData = false;
                return;
            }
        }

        public void filtroCPF()
        {
            Cpf = maskedBCPF.Text;
            if (ValidaCPF.IsCpf(Cpf))
            {
                ValidoCPF = true;
            }
            else
            {
                MessageBox.Show("CPF inválido!", "Atenção!");
                ValidoCPF = false;
                return;
                
            }
        }

        public void filtroNome()
        {
            if(maskedBNome.Text == "")
            {
                MessageBox.Show("Nome inválido!", "Atenção!");
                ValidoNome = false;
                return;
            }
            else
            {
                ValidoNome = true;
                Nome = maskedBNome.Text;
            }
            
        }

        //------------------------------end: Methods ---------------------------------------------------

        //------------------------------Start: Codigo ativação Cliente----------------------------------
        public DateTime Nascimento;
        public string Cpf;
        public string Nome;
        public bool ValidoNome, ValidoCPF, ValidoData; 

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            //Campos Cliente
            maskedBNome.Enabled = true;
            maskedBCPF.Enabled = true;
            maskedBNascimento.Enabled = true;

            //Variavel
            novoCliente = true;

            //Botão
            btnExistente.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnExistente_Click(object sender, EventArgs e)
        {
            //Campo Cliente
            maskedBCPF.Enabled = true;

            //Botão
            btnNovoCliente.Enabled = false;
            btnProcurar.Enabled = true;

            //Variavel
            novoCliente = false;
        }

        private void KeyPress_CPF(object sender, KeyPressEventArgs e)
        {
            if (novoCliente == false) return;
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    clienteSearch();
                    return;
                }
            }
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            clienteSearch();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            filtroNascimento();
            filtroNome();
            filtroCPF();

            if (ValidoData == false || ValidoNome == false || ValidoCPF == false) return;


            inicial1.Adicionar_Cliente(Nome, Nascimento.ToString("dd/MM/yyyy"), Cpf);
        }


        //------------------------------end: Codigo ativação Cliente------------------------------------
    }
}
