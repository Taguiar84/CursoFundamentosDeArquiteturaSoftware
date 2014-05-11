using FactoryMethod.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            var pagamento = new Pagamento();


            pagamento.AddItem(new Item()
            {
                Codigo = 1,
                Valor = 0.5M
            });

            pagamento.AddItem(new Item()
            {
                Codigo = 2,
                Valor = 2.39M
            });

            pagamento.ProcessarPagamento();


            Console.ReadKey();

        }
    }
}
