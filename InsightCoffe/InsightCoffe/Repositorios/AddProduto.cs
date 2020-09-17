using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Repositorios
{
    public class AddProduto : IEquatable<AddProduto>
    {
        public int Identifier { get; set; }
        public string Descricao { get; set; }
        public string Quantidade { get; set; }
        public double Valor { get; set; }

        //public AddProduto(int codigo, string descricao, string quantidade, double valor)
        //{

        //    Identifier = codigo;
        //    Descricao = descricao;
        //    Quantidade = quantidade;
        //    Valor = valor;
        //}

        public override string ToString()
        {
            return "ID: " + Identifier + "  Descrição: " + Descricao + "  Quant. : " + Quantidade + "  Valor: " + Valor;
        }

        public override int GetHashCode()
        {
            for (int i = 0; i < Identifier; i++)
            {
                Identifier = i;
            }
            return Identifier;
        }

        public bool Equals(AddProduto other)
        {
            if (other == null) return false;
            return (this.Identifier.Equals(other.Identifier));
        }
    }
}
