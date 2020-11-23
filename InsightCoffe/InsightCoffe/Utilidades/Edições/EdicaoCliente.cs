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

        //------------------------------Start: Classes -------------------------------------------------
        string Cpf;
        private PainelInicial painelInicial;
        private List<Cliente> clientes;

        public bool filtroCPF()
        {
            Cpf = maskedBId.Text;
            if (ValidaCPF.IsCpf(Cpf))
            {
                return true;
            }
            else
            {
                MessageBox.Show("CPF inválido!", "Atenção!");
                maskedBId.ResetText();
                return false;
            }
        }
        //------------------------------end: Classes ---------------------------------------------------
        //-------------------------Start: Botão ----------------------------------------------
        private void maskedBCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnAction();
        }
        //-------------------------end: Botão ------------------------------------------------
        //-------------------------start: Method ---------------------------------------------
        public void BtnAction()
        {
            string name;
            DateTime birth;
            //Cpf = vendas1.Cpf;
            //name = vendas1.Nome;
            //birth = vendas1.Nascimento;

            if(filtroCPF() == true)
            {
                string message = "Tem certeza disso?";
                string title = "Atenção!!";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(message, title, buttons);
                foreach (Cliente cliente in inicial1.clientes)
                {
                    if (Cpf == cliente.CPF)
                    {
                        if (result == DialogResult.Yes)
                        {
                            //cliente.Nome = name;
                            //cliente.DataNascimento = birth.ToString();
                            cliente.CPF = Cpf;
                            MessageBox.Show("Alteração concluida!");
                        }
                        else
                            MessageBox.Show("Cancelado!", title);
                    }
                }
                MessageBox.Show("Usuario ou senha incorretos", "Erro!");
            }
        }
    }
    //-------------------------end: Method ---------------------------------------------
}
