using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Produto
{
    public abstract class Pagamento
    {

        public string CPF { get; set; }
        public string Estado { get; set; }
        public decimal ICMS { get; set; }
        public string UF { get; set; }
        public decimal ValorTotal { get; set; }


        public void AdcionarItens()
        {

        }

        public decimal CalcularICMS()
        {
            return ValorTotal * (ICMS / 100);
        }
    
        public void ProcessarPagamento()
        {
            //SistemaPagamento sistemaPagamento = new PagSeguro();
            //sistemaPagamento.RegistrarPagamento(this);
        }
    }
}
