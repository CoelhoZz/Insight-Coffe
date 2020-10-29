using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Repositorios
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Quantidade { get; set; }
        public double Valor { get; set; }

        public override int GetHashCode()
        {
            return ID;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Produto objAsProduto = obj as Produto;
            if (objAsProduto == null) return false;
            else return Equals(objAsProduto);
        }

        public bool Equals(Produto other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
    }
}
