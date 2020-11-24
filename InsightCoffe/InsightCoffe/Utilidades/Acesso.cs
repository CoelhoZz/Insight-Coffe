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
using InsightCoffe.Entity;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Documents;

namespace InsightCoffe
{
    public partial class Form1 : Form
    {
        public List<Usuarios> usuarios = new List<Usuarios>();

        public Form1()
        {
            InitializeComponent();
            usuarios.Add(new Usuarios() { ID = 0, Usuario = "q", Senha = "q", Acesso = "Total"});
            usuarios.Add(new Usuarios() { ID = 1, Usuario = "Gerente", Senha = "Gerente", Acesso = "Total"});
            usuarios.Add(new Usuarios() { ID = 2, Usuario = "Thyago", Senha = "Thyago", Acesso = "Parcial" });
            usuarios.Add(new Usuarios() { ID = 3, Usuario = "Leonam", Senha = "Leonam", Acesso = "Pequeno" });
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
            Application.Exit();
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

        //---------------------------------------Conectar ao SISTEMA--------------------------------------
        public string user, acess;
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text == "Username" || tbUsername.Text == "") && (tbPassword.Text == "Password" || tbPassword.Text == ""))
            {
                MessageBox.Show("Insira o Usuario e Senha para prosseguir");
                return;
            }
            else
            {
                foreach(Usuarios usuarios in usuarios)
                {
                    if (usuarios.Usuario == tbUsername.Text && usuarios.Senha == tbPassword.Text)
                    {
                        user = usuarios.Usuario;
                        acess = usuarios.Acesso;

                        Iniciar();
                    } 
                }
                MessageBox.Show("Usuario ou senha incorretos", "Erro!");
            }
        }

        public string userLogado()
        {
            return user;
        }
        public string userAcessLogado()
        {
            return acess;
        }
        //-------------------------------------end Conectar ao Sistema-------------------------------------

        //--------------------------Start atualiza campos USUARIO, SENHA e MOSTRAR-------------------------
        
        //----------------------user
        private void Enter_user(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbUsername.Text != "Username")
                return;
            tbUsername.ForeColor = Color.Black;
            tbUsername.Text = "";
        }

        private void Leave_user(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.SandyBrown;
            }
        }

        //-----------------------passs
        private void Enter_pass(object sender, EventArgs e)
        {
            if (tbPassword.Text != "" && tbPassword.Text != "Password")
                return;
            tbPassword.ForeColor = Color.Black;
            tbPassword.Text = "";
            tbPassword.PasswordChar = Convert.ToChar("*");
        }

        private void Leave_pass(object sender, EventArgs e)
        {
            if(tbPassword.Text == "" || tbPassword.Text == "Password")
            {
                tbPassword.Text = "Password";
                tbPassword.PasswordChar = Convert.ToChar("\0");
                tbPassword.ForeColor = Color.SandyBrown;
            }
        }

        private void Click_mostar(object sender, EventArgs e)
        {
            if (chkMostrar.Checked == true)
                tbPassword.PasswordChar = Convert.ToChar("\0");
            else
                tbPassword.PasswordChar = Convert.ToChar("*");
        }
        //----------------------------End atualiza campos USUARIO, SENHA e MOSTRAR-----------------------

        //--------------------------------------Iniciar outras APLICAÇÕES--------------------------------
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
            Application.Run(new Utilidades.PainelInicial(this, usuarios));
        }
        //--------------------------------------End outras APLICAÇÕES------------------------------------
    }
}
