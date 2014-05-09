using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using System.Reflection;
using log4net.Config;

namespace Adapter
{
    public class Adapter : ILog
    {
        private static log4net.ILog Log;
        //private static readonly log4net.ILog Log = LogManager.GetLogger("Adapter.Adapter");
       
        public void RegistraLog(string msg, TipoLog tipoLog)
        {
            if (Log == null)
            {
                 Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                 XmlConfigurator.Configure();//Apenas 1 vez
            }

            switch (tipoLog)
            {
                case TipoLog.Aviso:
                    Log.Warn(msg);
                    break;
                case TipoLog.Informação:
                    Log.Info(msg);
                    break;
                case TipoLog.Erro:
                    Log.Error(msg);
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
