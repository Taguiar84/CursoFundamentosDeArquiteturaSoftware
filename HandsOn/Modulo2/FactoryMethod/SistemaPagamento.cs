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
            Processo1();
            Processo2();
        }

        protected virtual void Processo1()
        {
            Console.WriteLine("parte 1 do processo de pagamento");
        }
        protected virtual void Processo2()
        {
            Console.WriteLine("parte 2 do processo de pagamento");
        }
    }
}
