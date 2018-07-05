using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_de_produtos
{
    class Cliente
    {
        public int codigoCliente;
        public string nomeCliente;
        public string endereco;
        public string telefone;
        public string filiacao;
        public string status;
        public double limite;
        


        public List<Cliente> listaCliente = new List<Cliente>();
        

        public void CadastrarCliente(Cliente cliente)
        {
            listaCliente.Add(cliente);
        }

    }
}
