using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Repositorios
{
    public class Produto
    {
        public int Identifier { get; set; }
        public string Descricao { get; set; }
        public string Quantidade { get; set; }
        public double Valor { get; set; }

        public Produto(){}

        public Produto(int codigo, string descricao, string quantidade, double valor)
        {

            Identifier = codigo;
            Descricao = descricao;
            Quantidade = quantidade;
            Valor = valor;
        }
    }
}
