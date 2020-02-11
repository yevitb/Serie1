using System;
using System.Collections.Generic;
using System.Text;

namespace serie1._5
{
    class AnotherCharacter : Exception
    {
        public AnotherCharacter() : base("Valores ingresados inválidos") { }
        public AnotherCharacter(string Mensaje) : base(Mensaje) { }
    }
}
