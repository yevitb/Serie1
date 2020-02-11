using System;
using System.Collections.Generic;
using System.Text;

namespace serie1
{
    class LessOneNumberException : Exception
    {
        public LessOneNumberException() : base("Operacion inválida. ") { }
        public LessOneNumberException(string Mensaje) : base(Mensaje) { }
    }
}
