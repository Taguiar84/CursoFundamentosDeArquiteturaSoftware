using FactoryMethod.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class FabricaPagamentos
    {
        public Pagamento CriarPagamento(OperadorPagamento operadorPagamento)
        {
            return null;
            //switch (operadorPagamento)
            //{
            //    case OperadorPagamento.PagSeguro:
            //        SistemaPagamento
            //}
        }
    }

    public enum OperadorPagamento
    {
        PayPall,
        PagSeguro

    }

}
