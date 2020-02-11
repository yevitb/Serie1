using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._16
{
    class Chihuahuenos : Perro
    {
        //RAza Chichuahueño si son objetod de esta clase
        public string Raza="Chihuahueño";
        //Constructores
        public Chihuahuenos(string nombre) : base(nombre) {}
        //NMetodos especializados en esta raza
        public override string Ladra()
        {
            return "¡Guau! temblando";
        }
        public override string Corre()
        {
            return "Corre poquito a poquito.";
        }
        public override string Come()
        {
            return "Poquito y temblando.";
        }
        public override string Duerme()
        {
            return "Duerme... supongo que con frío.";
        }
        public override string Respirar()
        {
            return "Respirando y temblando, para variar...";
        }
        public override string Ejercicio()
        {
            return "Temblar";
        }
        //Metodo que imprime los datos de los perros
        public override string ToString()
        {
            return string.Format("¡BRRRR! soy {0}, un {1}", Nombre, Raza);
        }
    }
}
