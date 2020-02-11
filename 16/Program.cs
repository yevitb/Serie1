using System;

namespace Serie1._16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varios objetos de las clases
            Perro d1 = new Dalmata("Perdita");
            Perro d2 = new Dalmata ("Pongo");
            Perro c3 = new Chihuahuenos ("Bruiser" );
            Perro p4 = new Pug ("Olive");
            //ingresarlos a un arreglo para poder iterar con todos 
            Perro[] perros = { d1, d2, c3, p4 };
            //por cada perro en el arreglo, mandamos llamar todos los metodos y cada uno lo
            //realiza de distinta manera.
            foreach (Perro canino in perros)
            {
                Console.WriteLine("\n========================\n");
                Console.WriteLine(canino.ToString());
                Console.WriteLine(canino.Ladra());
                Console.WriteLine(canino.Respirar());
                Console.WriteLine(canino.Duerme());
                Console.WriteLine(canino.Come());
                Console.WriteLine(canino.Corre());
                Console.WriteLine(canino.Ejercicio());
            }

        }
    }
}
