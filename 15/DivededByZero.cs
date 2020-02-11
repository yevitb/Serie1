using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._15
{
    class DivededByZero:Exception
    {
        public DivededByZero() : base("Operacion invlálida") { }
        public DivededByZero(string Mensaje) : base(Mensaje) { }
    }
}
