using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._16
{
    class Perro
    {
        public string Nombre;

        //Métodos a heredar
        public Perro (string nombre)
        {
            Nombre = nombre;
        }
        public virtual string Ladra()
        {
            return "¡Guau general!";
        }
        public virtual string Corre()
        {
            return "Corre general";
        }
        public virtual string Come()
        {
            return "Ñam general";
        }
        public virtual string Duerme()
        {
            return "Zzzzzzz";
        }
        public virtual string Respirar()
        {
            return "Inhala, exhala. ";
        }
        public virtual string Ejercicio()
        {
            return "Ir al parque";
        }
        //Método que imprime los datos del perro
        public override string ToString()
        {
            return string.Format("{0}", Nombre);
        }
    }
}
