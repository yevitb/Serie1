using System;
using System.Collections.Generic;
using System.Text;

namespace fibonacci
{
    class LessThanZero : Exception
    {
        public LessThanZero() : base("No se puede realizar la operacion requerida. Ingresa un numero mayor a 0") {}
        public LessThanZero(string Mensaje) : base(Mensaje) { }
    }
}
