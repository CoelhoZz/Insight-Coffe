using InsightCoffe.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightCoffe.Utilidades.Consultas
{
    public partial class RegClientes : Form
    {
        PainelInicial Inicial;
        public RegClientes(PainelInicial inicial, List<Cliente> clientes)
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
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar todo o Sistema, incuindo todas as telas abertas neste momento?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Inicial.TelaRegClientes = false;
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

        private void RegClientes_Load(object sender, EventArgs e)
        {
            Mostrar_lista();
        }

        private void Mostrar_lista()
        {
            foreach (var item in Inicial.clientes)
            {
                listVRegistroCliente.Items.Add(new ListViewItem(new string[] { item.ID.ToString(), item.Nome, item.DataNascimento, item.CPF }));
            }

        }
    }
}
