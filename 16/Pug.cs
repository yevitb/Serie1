using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._16
{
    class Pug : Perro
    {
        //POr default la raa en Pug en esta clase
        public string Raza="Pug";
        //Constructor
        public Pug(string nombre):base(nombre){}
        //Métodos heredados y aplicados a la raza en especifico. Regresan una cadena
        //para que se imprima en el programa principal.
        public override string Ladra()
        {
            return "¡Guau! intentando no morir en el intento";
        }
        public override string Corre()
        {
            return "Paso, respira, paso, respira...";
        }
        public override string Come()
        {
            return "Mediana porción";
        }
        public override string Duerme()
        {
            return "Roncando";
        }
        public override string Respirar()
        {
            return "Roncando ";
        }
        public override string Ejercicio()
        {
            return "Paso, ronca, paso, ronca...";
        }
        //Imprimir datos del perro
        public override string ToString()
        {
            return string.Format("Soy un {0} y mi nombre es {1}",  Raza, Nombre);
        }
    }
}
