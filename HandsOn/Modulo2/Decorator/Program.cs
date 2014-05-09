using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            editor.Texto = "LagaTinga";

            var negrito = new TextoNegrito(editor);
            var centralizado = new TextoCentralizado(negrito);


            Console.WriteLine(centralizado.Formatar());

            Console.ReadKey();

        }
    }
}
