using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Repositorios
{
    public class PedidoPago //nha
    {
        public int ID { get; set; }

        public UInt64 CodigoUsado { get; set; }

        public string Cliente { get; set; }

        public string DataeHora { get; set; }

        public string Situacao { get; set; }

        public double Valor { get; set; }

    }
}
