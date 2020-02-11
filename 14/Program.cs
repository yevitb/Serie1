using System;

namespace Serie1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonaje1 b1 = new Buenos { Nombre = "Goku" };
            IPersonaje1 e1 = new Enemigos { Nombre = "Freezer" };
            IPersonaje1 s1 = new Secundarios { Nombre = "Krillin" };

            IPersonaje1[] personajes = new IPersonaje1[] { b1, e1, s1 };
            //Viven los 3 personajes.
            foreach (var personaje in personajes)
            {
                Console.WriteLine(personaje.Vive());
            }
            //Downcasting de los objetos
            Buenos b = b1 as Buenos;
            Enemigos e = e1 as Enemigos;
            Secundarios s = s1 as Secundarios;
            //Metodos de los objetos, que aunque utilicen el mismo metodo, cada uno lo 
            //ejecuta distinto, en este caso se utiliza una cadena distinta
            s.Pega();
            e.Dispara();
            Console.WriteLine("¡PUM!");
            //hace rnefasis que Krillin explota
            s.Muere();
            b.Habla();
            //s.Vive();
            b.Dispara();
            e.Muere();

            b.Muere();
        }
    }
}
