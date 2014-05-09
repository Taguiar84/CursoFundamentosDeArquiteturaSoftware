using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Log : ILog
    {
        public void RegistraLog(string msg, TipoLog tipoLog)
        {
            Console.WriteLine("Log Antigo");
            Console.WriteLine(msg);
        }
    }
}
