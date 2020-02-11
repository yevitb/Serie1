using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._14
{
    class Buenos : IPersonaje1
    {
        protected int Vidas { get; set; }
        public string Nombre { get; set; }
        public bool Vive()
        {
            //Iniciar vidas
            Vidas = 1;
            Console.WriteLine("¡Las esferas del dragón!");
            return true;
        }
        //Método de muere a un personaje principal
        public bool Muere()
        {
            //Una vida menos
            Vidas = Vidas - 1;
            Console.WriteLine("¡Vamos a entrenar con Kaiosama!");
            return true;
        }
        //MEtodo para disparar de goku con una Genkidama
        public bool Dispara()
        {
            Console.WriteLine("¡GenkiDama!");
            return true;
        }
        //MEtodo que halba, es el único que lo contiene. Normalente en un juego
        //el que mas habla es el personaje principal
        public void Habla()
        {
            Console.WriteLine("¡Ya basta Freeezer!");
        }

    }
}
