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
        public UInt64 CodigoDeBarras { get; set; }
        
        public List<Cliente> Cliente { get; set; }

        public List<Produto> Carinho { get; set; }
    }
}
