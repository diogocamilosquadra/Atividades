using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_de_produtos
{
    class Produto
    {
        public int codigoProduto;
        public int verificaProduto;
        public string nomeProduto;
        public string categoria;
        public string dataFabricacao; 
        public string dataVencimento;
        public double preco;

        public List<Produto> listaProduto = new List<Produto>(); 
        
        public void IncluirProduto(Produto produto)
        {
            listaProduto.Add(produto);
          
        }

        public void excluirProduto(Produto produto) {

            Console.WriteLine("Digite o codigo do produto que deseja excluir");
            verificaProduto= int.Parse(Console.ReadLine());

            if (verificaProduto == produto.codigoProduto)
            {
                listaProduto.Remove(produto);
                Console.WriteLine("\nProduto Excluido com sucesso!");
            }
            else {
                Console.Clear();
                Console.WriteLine("\nCodigo Não encontrado!");
            }
        }

        

    }
}
