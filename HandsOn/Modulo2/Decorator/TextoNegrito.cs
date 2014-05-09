using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class TextoNegrito : Editor
    {
        private Editor editor;
        public TextoNegrito(Editor editor)
        {
            this.editor = editor;
        }

        public override string Formatar()
        {
            return string.Format("<b>{0}</b>", editor.Formatar());
        }
    }
}
