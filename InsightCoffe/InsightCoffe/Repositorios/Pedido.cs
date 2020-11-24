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

        public UInt32 CodigoDeBarras { get; set; }
        
        public string DataEHora { get; set; }

        public string ClientName { get; set; }

        public string ClientCPF { get; set; }

        public List<Produto> Carrinho { get; set; }

        public string Situacao { get; set; }

        public double ValorTotal { get; set; }

        public static int geradorId(List<Pedido> items)
        {
            int i = 0;
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

        public static void adicionaComanda(List<Pedido> pedidos, string code)
        {
            pedidos.Add(new Pedido()
            {
                ID = Pedido.geradorId(pedidos),
                CodigoDeBarras = Convert.ToUInt32(code),
                DataEHora = "00/00/0000",
                ClientName = "",
                ClientCPF = "",
                Carrinho = null,
                Situacao = "Comanda vazia",
                ValorTotal = 0,
            });
        }

        public static bool removerComanda(List<Pedido> pedidos, UInt32 codeBarr)
        {

            foreach (var pedido in pedidos)
            {
                if (codeBarr == pedido.CodigoDeBarras)
                {
                    pedidos.RemoveAt(pedido.ID);
                    return true;
                }
            }
            return false;
        }

        public static bool limparPedido(List<Pedido> pedidos, UInt32 codeBarr)
        {

            foreach (Pedido pedido in pedidos)
            {
                if (codeBarr == pedido.CodigoDeBarras)
                {
                    pedido.DataEHora = "00/00/0000";
                    pedido.ClientName = "";
                    pedido.ClientCPF = "";
                    pedido.Carrinho = null;
                    pedido.Situacao = "Comanda vazia";
                    pedido.ValorTotal = 0;

                    return true;
                }
            }
            return false;
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
            Int32 codigoBarra = Convert.ToInt32(codigo);
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
            Int32 codigoBarra = Convert.ToInt32(codigo);
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
