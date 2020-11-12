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
