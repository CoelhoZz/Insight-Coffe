using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightCoffe.Utilidades
{
    public partial class StartAPS : Form
    {
        public StartAPS()
        {
            InitializeComponent();
        }

        //Mover formulario
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
        //end-Mover formulario

        //Fechar aplicação
        private void picBExit_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fechar todo o Sistema, incuindo todas as telas abertas neste momento?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        //Minimizar aplicação
        private void picBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Start Sequencia de EVENTOS abertura das outras Telas
        private void bntVendas_Click_1(object sender, EventArgs e)
        {
            vendas = true;
            pagamento = false;
            produtos = false;
            Iniciar();
        }

        private void bntPagamento_Click_1(object sender, EventArgs e)
        {
            pagamento = true;
            vendas = false;
            produtos = false;
            Iniciar();
        }

        private void bntProdutos_Click_1(object sender, EventArgs e)
        {
            produtos = true;
            pagamento = false;
            vendas = false;
            Iniciar();
        }
        //End Sequencia de EVENTOS abertura das outras Telas

        //Iniciar outras APLICAÇÕES
        Thread Iniciar_aplicação;

        bool vendas = false;
        bool pagamento = false;
        bool produtos = false;

        private void Iniciar()
        {
            Iniciar_aplicação = new Thread(Aplicativo);
            Iniciar_aplicação.SetApartmentState(ApartmentState.STA);
            Iniciar_aplicação.Start();
        }

        private void Aplicativo()
        {
            if (vendas == true)
                Application.Run(new Utilidades.APSvendas());
            else if (produtos == true)
                Application.Run(new Utilidades.APSprodutos());
            else if (pagamento == true)
                Application.Run(new Utilidades.APSpagamento());
        }
        //End outras APLICAÇÕES
    }
}
