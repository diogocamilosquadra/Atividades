using System;

namespace Loja_de_produtos
{
    class main 
    {
        static void Main(string[] args)
        {

            Cliente c = new Cliente();
            Produto p = new Produto();
            Fornecedor f = new Fornecedor();
            Pedido pedido = new Pedido();

            int opcao = 0;
            int i = 0;
            do
            {

                Console.WriteLine("Digite a opção que deseja\n");
                Console.WriteLine("1- Incluir Produto      / 2- Cadastrar Cliente");
                Console.WriteLine("3- Cadastrar Fornecedor / 4- Verificar Produtos Cadastrados  ");
                Console.WriteLine("5- Fazer Pedido         / 6- Excluir produto  ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {

                    Console.Clear();
                    Console.WriteLine("Digite o codigo do produto");
                    p.codigoProduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome do produto");
                    p.nomeProduto = Console.ReadLine();
                    Console.WriteLine("Digite a categoria do produto ");
                    p.categoria = Console.ReadLine();
                    Console.WriteLine("Digite a data de fabricação do produto");
                    p.dataFabricacao = Console.ReadLine();
                    Console.WriteLine("Digite a data de vencimento do produto");
                    p.dataVencimento = Console.ReadLine();
                    Console.WriteLine("Digite o Preço do produto");
                    p.preco = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nProduto cadastrado com sucesso!\n");

                    p.IncluirProduto(p);
                    Console.Clear();
                }

                else if (opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o codigo do cliente");
                    c.codigoCliente = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome do cliente");
                    c.nomeCliente = Console.ReadLine();
                    Console.WriteLine("Digite o endereco do cliente");
                    c.endereco = Console.ReadLine();
                    Console.WriteLine("Digite o telefone do cliente");
                    c.telefone = Console.ReadLine();
                    Console.WriteLine("Digite a filiação do cliente");
                    c.filiacao = Console.ReadLine();
                    Console.WriteLine("Digite o status do cliente");
                    c.status = Console.ReadLine();
                    Console.WriteLine("Digite o limite de credito do cliente");
                    c.limite = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nCliente cadastrado com sucesso!\n");

                    c.CadastrarCliente(c);
                    Console.Clear();
                }
                else if (opcao == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o codigo do fornecedor");
                    f.codigoFornecedor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o CNPJ do fornecedor");
                    f.cnpj = Console.ReadLine();
                    Console.WriteLine("Digite o endereço do fornecedor");
                    f.endereco = Console.ReadLine();
                    Console.WriteLine("Digite o Nome Fantasia do fornecedor");
                    f.nomeFantasia = Console.ReadLine();
                    Console.WriteLine("Digite o telefone do fornecedor");
                    f.telefone = Console.ReadLine();

                    f.CadastraFornecedor(f);
                    Console.Clear();
                }

                else if (opcao == 4)
                {
                   
                    foreach (Produto item in p.listaProduto)
                    {

                        Console.WriteLine("\nCodigo do produto cadastrado: " + item.codigoProduto);
                        Console.WriteLine("Nome do produto: " + item.nomeProduto);

                    }

                    foreach (Cliente item in c.listaCliente)
                    {


                        Console.WriteLine("\nNome do cliente cadastrado: " + item.nomeCliente);
                        Console.WriteLine("Limite: " + item.limite);

                    }

                    foreach (Fornecedor item in f.listaFornecedor)
                    {

                        Console.WriteLine("\nNome Fantasia do fornecedor cadastrado: " + item.nomeFantasia);
                        Console.WriteLine("CNPJ do Fornecedor cadastrado: " + item.cnpj);
                        Console.WriteLine("\n");
                    }

                    /* for (i = 0; i < p.listaProduto.Count; i++)
                     {
                         Console.WriteLine("Codigo do produto cadastrado: "+p.listaProduto[i].codigoProduto);

                     };*/

                }
                else if (opcao == 5)
                {
                    pedido.FazerPedido(p);

                }
                else if (opcao == 6) {

                    p.excluirProduto(p);

                }
            } while (opcao != 0);

        }


    }
}
