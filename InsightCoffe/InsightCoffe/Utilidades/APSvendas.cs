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
        public APSvendas(PainelInicial inicial, List<Produto> produtos)
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

        //-------------------------------------------Minimizar, Maximizar e Fechar aplicação--------------
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar todo o Sistema, incuindo todas as telas abertas neste momento?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void bntMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            bntMaximizar.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            bntMaximizar.Visible = true;
            btnNormal.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        //Leave
        private void LeaveMinimizar(object sender, EventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.DimGray;
        }
        private void LeaveMaximizar(object sender, EventArgs e)
        {
            bntMaximizar.FlatAppearance.BorderColor = Color.DimGray;
        }
        private void LeaveFechar(object sender, EventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.DimGray;
        }
        private void LeaveNormal(object sender, EventArgs e)
        {
            btnNormal.FlatAppearance.BorderColor = Color.DimGray;
        }
        //Control
        private void controlFechar(object sender, MouseEventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.Gray;
        }
        private void controlMaximizar(object sender, MouseEventArgs e)
        {
            bntMaximizar.FlatAppearance.BorderColor = Color.Gray;
        }
        private void controlMinimizar(object sender, MouseEventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.Gray;
        }
        private void controlNormal(object sender, MouseEventArgs e)
        {
            btnNormal.FlatAppearance.BorderColor = Color.Gray;
        }
        //-----------------------------------------------------------------------------------------------


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
