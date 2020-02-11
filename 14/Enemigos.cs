using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._14
{
    class Enemigos :IPersonaje1
    {
        protected int Vidas = 1;
        public string Nombre { get; set; }
        public bool Vive()
        {
            //Iniciamos las vidas
            Vidas = 1;
            Console.WriteLine("¡Rayos!");
            return true;
        }
        public bool Muere()
        {
            //Una vida menos
            Vidas = Vidas - 1;
            //Imprime una cadena para que se refleje en la pantalla que es distinto a las demás clases
            Console.WriteLine("¡Yo te mataré!, te mataré cueste lo que me cueste. ¡Ah!");
            Vidas = Vidas - 1;
            return true;
        }
        //Metodo de disparar con un dialogo de DB de Freezer.
        public bool Dispara()
        {
            Console.WriteLine("¿Qué pasa contigo?, no te muevas, no ves que te voy a matar?");
            return true;
        }
    }
}
