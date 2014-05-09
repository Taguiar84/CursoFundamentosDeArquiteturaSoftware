using FactoryMethod.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class SistemaPagamento
    {
        public Pagamento Pagamento { get; private set; }

        public void RegistrarPagamento(Pagamento pagamento)
        {
            Pagamento = pagamento;
        }
    }
}
