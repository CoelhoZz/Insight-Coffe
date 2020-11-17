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

        public static int geradorId(List<Pedido> items)
        {
            int i = 1;
            foreach (Pedido item in items)
            {
                if (i != item.ID)
                {
                    return i;
                }
                i++;
            }
            return i++;
        }

        public static double CalculoPreco(List<Produto> produtos)
        {
            double valorTot = 0;
            foreach (Produto item in produtos)
            {
                valorTot = valorTot + item.Valor;
            }
            return valorTot;
        }



        public static string GetDescontos(List<Produto> produtos, List<Produto> carrinho, int ItemDesconto)
        {
            foreach (Produto produto in produtos)
            {
                if (produto.ID == ItemDesconto)
                {
                    carrinho.Add(new Produto()
                    {
                        ID = Produto.geradorId(carrinho),
                        Descricao = produto.Descricao,
                        Quantidade = produto.Quantidade,
                        Valor = 0
                    });
                    return "Parabens!! Você ganhou um " + produto.Descricao + " " + produto.Quantidade;
                }
            }
            return "Sem desconto";
        }

        public static bool codigoExistente(List<Pedido> pedidos, string codigo)
        {
            UInt64 codigoBarra = Convert.ToUInt64(codigo);
            foreach (Pedido pedido in pedidos)
            {
                if (pedido.CodigoDeBarras == codigoBarra)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool reativarPedido(List<Pedido> pedidos, string codigo)
        {
            UInt64 codigoBarra = Convert.ToUInt64(codigo);
            foreach (Pedido pedido in pedidos)
            {
                if (pedido.CodigoDeBarras == codigoBarra && pedido.Situacao == "Em aberto")
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ID;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Pedido objAsPedido = obj as Pedido;
            if (objAsPedido == null) return false;
            else return Equals(objAsPedido);
        }

        public bool Equals(Pedido other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.CodigoDeBarras));
        }
    }
}
