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
    public partial class EditarComanda : Form
    {
        public PainelInicial inicial1;

        public EditarComanda(PainelInicial inicial, List<Pedido> pedido)
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
            inicial1.TelaEditComandas = false;
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
        //---------------------------------------------------------------------------------------------
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pedido.codigoExistente(inicial1.pedido, mskBCodeBar.Text) == true)
                {
                    MessageBox.Show("Verifique se o codigo ja esta cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Pedido.adicionaComanda(inicial1.pedido, mskBCodeBar.Text);
                    MessageBox.Show("Comanda salva com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    mskBCodeBar.ResetText();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um numero para salvar a comanda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void reorganizarComandas()
        {
            int i = 0;
            foreach(Pedido pedido in inicial1.pedido)
            {
                if(i != pedido.ID)
                {
                    pedido.ID = i;
                }
                i++;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pedido.codigoExistente(inicial1.pedido, mskBCodeBar.Text) == true)
                {
                    if (Pedido.reativarPedido(inicial1.pedido, mskBCodeBar.Text) == true)
                    {
                        if (MessageBox.Show("Situação da comanda  Nº " + mskBCodeBar.Text + " \"Em Aberto\"" + "\n" + "Deseja exclui-la mesmo assim?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (Pedido.removerComanda(inicial1.pedido, Convert.ToUInt32(mskBCodeBar.Text)) == true)
                            {
                                mskBCodeBar.ResetText();
                                reorganizarComandas();
                                return;
                            }
                        }
                        else
                            return;
                    }
                    if (MessageBox.Show("Deseja excluir a comanda Nº " + mskBCodeBar.Text + " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (Pedido.removerComanda(inicial1.pedido, Convert.ToUInt32(mskBCodeBar.Text)) == true)
                        {
                            mskBCodeBar.ResetText();
                            reorganizarComandas();
                            return;
                        }
                    return;
                }
                else
                {
                    MessageBox.Show("Digite um numero de uma comanda existente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um numero para excluir a comanda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------

    }
}
