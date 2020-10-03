using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExemploStringBuilder.Entities
{
    class Coment
    {
        public string Text { get; set; }

        public Coment()
        {

        }

        public Coment(string Text)
        {
            this.Text = Text;
        }
    }
}
