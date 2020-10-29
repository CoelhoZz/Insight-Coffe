using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace InsightCoffe.Utilidades.Consultas
{
    public partial class RegProdutos : Form
    {
        PainelInicial Inicial;

        public RegProdutos(PainelInicial inicial,  List<Repositorios.Produto> produtos)
        {
            InitializeComponent();
            this.Inicial = inicial;
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

        //-------------------------------------------Minimizar, Maximizar e Fechar aplicação--------------

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Inicial.TelaRegProdutos = false;
            this.Close();
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
        //-----------------------------------------------------------------------------------------------

        private void RegProdutos_Load(object sender, EventArgs e)
        {
            Mostrar_lista();

        }

        private void Mostrar_lista()
        {
            foreach (var item in Inicial.produtos)
            {
                listVRegistroCliente.Items.Add(new ListViewItem(new string[] { item.ID.ToString(), item.Descricao, item.Quantidade, item.Valor.ToString() }));
            }

        }
    }
}
