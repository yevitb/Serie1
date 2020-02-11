using System;
using System.Collections.Generic;
using System.Text;

namespace serie1._8
{
    class ValueException : Exception
    {
        public ValueException():base("Dato inválido"){ }
        public ValueException(string Mensaje) : base(Mensaje) { }


    }
}
