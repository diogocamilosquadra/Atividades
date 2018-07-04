using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double porcentagem, valor_depositado, renda_fixa, rendimento_fixo = 0;
            int opcao, meses = 0;
            double rendimento = 0;

            do
            {
                Console.WriteLine("Deseja depositar em poupança ou em renda fixa?");
                Console.WriteLine("1- POUPANÇA / 2 RENDA FIXA / 0- SAIR");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o valor a ser depositado: ");
                    valor_depositado = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a porcentagem do rendimento a ser utilizada: ");
                    porcentagem = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de meses que o valor permanecerá na poupança: ");
                    meses = int.Parse(Console.ReadLine());


                    rendimento = (meses * (valor_depositado * porcentagem / 100));

                    Console.WriteLine("O deposito de {0} rendeu R$ {1}, com o montante de {2}", valor_depositado, rendimento, valor_depositado + rendimento);
                    Console.ReadLine();

                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Digite o valor da sua renda fixa: ");
                    renda_fixa = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a porcentagem do rendimento  ");
                    porcentagem = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de meses que o valor permanecerá na poupança: ");
                    meses = int.Parse(Console.ReadLine());

                    rendimento_fixo = (meses * (renda_fixa * porcentagem / 100));

                    if (meses <= 12)
                    {
                        rendimento_fixo = rendimento_fixo - ((rendimento_fixo * 25) / 100);

                    }
                    else if (meses >= 13 || meses <= 24)
                    {

                        rendimento_fixo = rendimento_fixo - ((rendimento_fixo * 15) / 100);
                    }
                    else if (meses >= 25 || meses <= 36)
                    {

                        rendimento_fixo = rendimento_fixo - ((rendimento_fixo * 5) / 100);
                    }
                    else if (meses > 36)
                    {

                        rendimento_fixo = rendimento_fixo - ((rendimento_fixo * 1) / 100);
                    }

                    renda_fixa = renda_fixa + rendimento_fixo;

                    Console.WriteLine("O seu rendimento no final dessa operação é de {0}, com o montante de {1}", rendimento_fixo, renda_fixa);
                    Console.ReadLine();

                }

            } while (opcao != 0);

            if (rendimento_fixo > rendimento)
            {
                Console.WriteLine("A opção mais indicada é investir com renda fixa");
                Console.ReadLine();
            }
            else{

                Console.WriteLine("A opção mais indicada é investir na poupança");
                Console.ReadLine();
            }

        }
    }
}

