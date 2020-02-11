using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._14
{
    class Secundarios : IPersonaje1
    {
        protected int Vidas = 1;
        public string Nombre { get; set; }
        public bool Vive()
        {
            //Iniciar vidas
            Vidas = 1;
            Console.WriteLine("¡Las esferas del dragon!");
            return true;
        }
        public bool Muere()
        {
            //Una vida menos
            Vidas = Vidas - 1;
            Console.WriteLine("¡Gokú, ahh!");
            return true;
        }
        //Método de pegar de un personaje "secundario", en seste caso Krillin solo
        //es muy fuerte.
        public bool Pega()
        {
            Console.WriteLine("Krillin le pega a Freezer");
            return true;
        }
    }
}
