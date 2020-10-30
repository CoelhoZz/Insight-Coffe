using InsightCoffe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Repositorios
{
    public class Pedido
    {
        public int ID { get; set; }

        public UInt64 CodigoDeBarras { get; set; }
        
        public string DataEHora { get; set; }

        public string ClientName { get; set; }

        public string ClientCPF { get; set; }

        public List<Produto> Carrinho { get; set; }

        public string Situacao { get; set; }

        public double ValorTotal { get; set; }
    }

}
