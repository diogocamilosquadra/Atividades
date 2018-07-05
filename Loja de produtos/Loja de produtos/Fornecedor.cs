using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_de_produtos
{
    class Fornecedor 
    {

        public int codigoFornecedor;
        public string cnpj;
        public string nomeFantasia;
        public string endereco;
        public string telefone;


        public List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        public void CadastraFornecedor(Fornecedor fornecedor)
        {
            listaFornecedor.Add(fornecedor);

        }
    }
}
