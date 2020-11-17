using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Repositorios
{
    public class CodigoBarras
    {
        List<uint> CodeBar = new List<uint>();

        public CodigoBarras(uint codigo)
        {
            CodeBar.Add(codigo);
        }
    }
}
