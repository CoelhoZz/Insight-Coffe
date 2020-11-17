using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Repositorios
{
    public class Carrinho
    {
        public static string valor_unidade(string item, double unidade, List<Produto> produtos)
        {
            string valorPorUnidade = "Error";
            foreach (Produto produto in produtos)
            {
                if ((produto.Descricao + " " + produto.Quantidade) == item)
                {
                    valorPorUnidade = (produto.Valor * unidade).ToString("C2");
                    return valorPorUnidade;
                }
            }
            return valorPorUnidade;
        }
    }
}
