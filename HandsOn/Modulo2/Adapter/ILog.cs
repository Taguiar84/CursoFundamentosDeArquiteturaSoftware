using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{

    public enum TipoLog
    {
        Informação,
        Aviso,
        Erro
    }

    public interface ILog
    {
        void RegistraLog(string msg, TipoLog tipoLog);
    }
}
