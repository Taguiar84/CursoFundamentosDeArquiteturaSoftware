using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Produto
{
    public class PagSeguro: SistemaPagamento
    {

        protected override void Processo1()
        {
            base.Processo1();
            Console.WriteLine("Processo1 - PagSeguro");
        }

        protected override void Processo2()
        {
            base.Processo2();
            Console.WriteLine("Processo2 - PagSeguro");
        }
    }
}
