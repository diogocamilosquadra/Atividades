using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_de_produtos
{
    class Pedido 
    {
        public DateTime dataPedido;
        public int qtdPedido, codPedido = 0;
        public double valorPedido;
        public int codigoProduto;

        Produto p = new Produto();

        public void FazerPedido(Produto p)
        {

            Console.WriteLine("Digite o codigo do produto que deseja fazer o pedido");
            codigoProduto = int.Parse(Console.ReadLine());

            if (codigoProduto == p.codigoProduto)
            {
                Console.WriteLine("Quantos produtos voce deseja comprar?");
                qtdPedido = int.Parse(Console.ReadLine());

                valorPedido = qtdPedido * p.preco;

                Console.WriteLine("Seu pedido total vai ficar em {0}", valorPedido);
            }
            else
            {

                Console.WriteLine("Produto Não encontrado ");
            }

        }


    }
}
