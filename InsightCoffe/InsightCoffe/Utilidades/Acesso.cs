using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InsightCoffe
{
    public partial class Form1 : Form
    {

        public Form1()
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
        private void picBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Minimizar aplicação
        private void picBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Conectar ao SISTEMA
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text == "Username" || tbUsername.Text == "") && (tbPassword.Text == "Password" || tbPassword.Text == ""))
            {
                MessageBox.Show("Insira o Usuario e Senha para prosseguir");
                return;
            }
            else if (tbUsername.Text == "adm" && tbPassword.Text == "adm")
            {
                MessageBox.Show("Bem vindo Administrador");
                Iniciar();
            }
            else if (tbUsername.Text == "func" && tbPassword.Text == "func")
            {
                MessageBox.Show("Bem vindo Funcionario");
                Iniciar();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos", "Erro!");
            }
        }


        //Start atualiza campos USUARIO e SENHA
        private void Form_click(object sender, EventArgs e)
        {
            if ((tbUsername.Text != "Username" && tbUsername.Text != "") && (tbPassword.Text != "Password" && tbPassword.Text != ""))
                return;

            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.Silver;
            }

            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.PasswordChar = '\0';
                tbPassword.ForeColor = Color.Silver;
            }
        }

        private void Click_user(object sender, EventArgs e)
        {
            if(tbUsername.Text != "Username" && tbUsername.Text != "")
                return;
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }

            if (tbPassword.Text == "")
            {
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Password";
            }
        }

        private void Click_pass(object sender, EventArgs e)
        {
            if (tbPassword.Text != "Password" && tbPassword.Text != "")
                return;
            if(tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.PasswordChar = Convert.ToChar("*");
                tbPassword.ForeColor = Color.Black;
            }
            if(tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
            }
        }
        //End atualiza campos USUARIO e SENHA

        //Iniciar outras APLICAÇÕES
        Thread Iniciar_aplicação;

        private void Iniciar()
        {
            this.Close();
            Iniciar_aplicação = new Thread(Aplicativo);
            Iniciar_aplicação.SetApartmentState(ApartmentState.STA);
            Iniciar_aplicação.Start();
        }

        private void Aplicativo()
        {
            Application.Run(new Utilidades.StartAPS());
        }
        //End outras APLICAÇÕES
    }
}
