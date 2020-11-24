using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Entity
{
    public class Cliente
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string DataNascimento { get; set;}

        public string CPF { get; set; }

        public int Compras { get; set; }

        public static int identifyClient(List<Cliente> clientes)
        {
            int i = 1;
            foreach (Cliente cliente in clientes)
            {
                if (i != cliente.ID)
                {
                    return i;
                }
                i++;
            }
            return i++;
        }

        public static bool checkCliente(List<Cliente> clientes, string cpf)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cpf == cliente.CPF)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool clientePadrao(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                if ("null" == cliente.CPF)
                {
                    return true;
                }
            }
            return false;
        }

        public static void adiconaCliente(List<Cliente> clientePedido, int id, string nome, string nascimento, string cpf)
        {
            clientePedido.Add(new Cliente()
            {
                ID = id,
                Nome = nome,
                DataNascimento = nascimento,
                CPF = cpf,
                Compras = 0
            });
        }

        public static bool atualizaCompra(List<Cliente> clientes, string cpf)
        {
            if (cpf == "")
                return true;
            foreach (Cliente cliente in clientes)
            {
                if (cpf == cliente.CPF)
                {
                    cliente.Compras++;
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Cliente objAsCliente = obj as Cliente;
            if (objAsCliente == null) return false;
            else return Equals(objAsCliente);
        }

        public bool Equals(Cliente other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
    }
}
