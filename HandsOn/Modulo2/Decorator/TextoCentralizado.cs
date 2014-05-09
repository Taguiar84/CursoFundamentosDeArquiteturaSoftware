using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class TextoCentralizado : Editor
    {
        Editor editor;

        public TextoCentralizado(Editor editor)
        {
            this.editor = editor;
        }

        public override string Formatar()
        {
            return string.Format("<center>{0}</center>", editor.Formatar());
        }

    }
}
