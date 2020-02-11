using System;
using System.Collections.Generic;
using System.Text;

namespace serie1._2
{
    class LessOne : Exception
    {
        public LessOne() : base("El numero debe ser mayor a 0. :)") { }
        public LessOne(string Mensaje) : base (Mensaje) { }
    }
    class MoreNine : Exception
    {
        public MoreNine() : base("EL numero debe ser menor a 10. :)") { }
        public MoreNine(string Mensaje) : base(Mensaje) { }
    }
}
