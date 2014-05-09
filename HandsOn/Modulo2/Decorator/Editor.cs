using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Editor
    {
        public string Texto { get;set;}

        public virtual string Formatar()
        {
            return Texto;
        }
    }
}
