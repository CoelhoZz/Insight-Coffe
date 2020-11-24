using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Repositorios
{
    public class Pagamentos
    {
        public int ID { get; set; }

        public UInt64 CodigoUsado { get; set; }

        public string Cliente { get; set; }

        public string DataeHora { get; set; }

        public string Situacao { get; set; }

        public List<Produto> Carrinho { get; set; }

        public double Valor { get; set; }


        public static int geradorId(List<Pagamentos> items)
        {
            int i = 0;
            foreach (Pagamentos item in items)
            {
                if (i != item.ID)
                {
                    return i;
                }
                i++;
            }
            return i++;
        }
    }
}
