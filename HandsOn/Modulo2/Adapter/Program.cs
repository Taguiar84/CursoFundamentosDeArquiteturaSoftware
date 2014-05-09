using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog ILog = new Log();//Log Antigo
            ILog.RegistraLog("Teste de Log Antigo", TipoLog.Erro);


            ILog = new Adapter();
            ILog.RegistraLog("Teste de Log4Net", TipoLog.Erro);

            Console.ReadKey();
        }
    }
}
