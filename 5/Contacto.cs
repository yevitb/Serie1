using System;
using System.Collections.Generic;
using System.Text;

namespace serie1._5
{
    class Contacto
    {
        protected string Nombre { get; set; }
        protected string Numero { get; set; }
        //Constructores
        public Contacto() { }
        public Contacto(String nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
