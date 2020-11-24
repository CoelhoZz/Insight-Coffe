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
    public partial class ExcluirPagamento : Form
    {
        public PainelInicial inicial1;

        public ExcluirPagamento(PainelInicial inicial, List<Pagamentos> pagamento)
        {
            InitializeComponent();

            this.inicial1 = inicial;
        }

        //----------------------------------Mover formulario-----------------------------------------------
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
        //------------------------------------------end-Mover formulario----------------------------------

        //-------------------------------------------Minimizar, Maximizar e Fechar aplicação--------------

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            inicial1.TelaExcluirPag = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Leave
        private void LeaveMinimizar(object sender, EventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        private void LeaveFechar(object sender, EventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        //Mouse move em cima
        private void controlFechar(object sender, MouseEventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.Red;
        }
        private void controlMinimizar(object sender, MouseEventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        int id;
        public bool idPagamento()
        {
            if (mskBCodeBar.Text == "")
                return false;
            id = Convert.ToInt32(mskBCodeBar.Text);
            foreach (Pagamentos pagamento in inicial1.armazenaPedido)
            {
                if (pagamento.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnExcluirPag_Click(object sender, EventArgs e)
        {
            try
            {
                if(idPagamento() == true)
                {
                    if (MessageBox.Show("Deseja cancelar o registro de pagamento ID:" + mskBCodeBar.Text + " ??", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        inicial1.armazenaPedido.RemoveAt(id);
                    }
                }
                else
                    MessageBox.Show("Digite um numero valido para excluir", "Erro", MessageBoxButtons.OK);

            }
            catch(Exception)
            {
                MessageBox.Show("Digite um numero valido para excluir", "Erro", MessageBoxButtons.OK);
            }
        }
        //-----------------------------------------------------------------------------------------------
    }
}
