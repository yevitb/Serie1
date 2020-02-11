using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._16
{
    class Dalmata : Perro
    {
        ///Raza dálmata por default en esta clase
        public string Raza="Dálmata";
        //Constructor
        public Dalmata(string nombre) : base(nombre) {}
        //Metodos
        public override string Ladra()
        {
            return "¡Guau! con manchas";
        }
        public override string Corre() 
        {
            return "Corre veloz";
        }
        public override  string Come()
        {
            return "Come mucho";
        }
        public override string Duerme() 
        {
            return "ZZZZzzzzz";
        }
        public override string Ejercicio()
        {
            return "Correr como por horas.";
        }
        //Imprime los dato del perro
        public override string ToString()
        {
            return string.Format("Mi nombre es {0} y soy un {1}", Nombre, Raza);
        }
    }
}
