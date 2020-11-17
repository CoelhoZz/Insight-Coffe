using System;
using InsightCoffe.Utilidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightCoffe.Classes
{
    public class ValidaCliente
    {
        public static bool filtroNascimento(string valNasc)
        {
            try
            {
                Convert.ToDateTime(valNasc);
                return true;                    
            }
            catch (Exception)
            {
                MessageBox.Show("Data de nascimento inválida!", "Atenção!");
                return false;
            }
        }

        public static bool filtroCPF(string Cpf)
        {
            if (ValidaCPF.IsCpf(Cpf))
            {
                return true;
            }
            else
            {
                MessageBox.Show("CPF inválido!", "Atenção!");
                return false;
            }
        }

        public static bool filtroNome(string nome)
        {
            if (nome == "")
            {
                MessageBox.Show("Nome inválido!", "Atenção!");
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
