using System;
using System.Collections.Generic;
using System.Text;

namespace serie1._10
{
    class Excepciones :Exception
    {
        public Excepciones() : base("Operacion invlálida") { }
        public Excepciones(string Mensaje) : base(Mensaje) { }

    }
}
