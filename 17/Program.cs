using System;

namespace Seri1._17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancian clases
            Instrumentos gui1 = new Guitarra("Guitarra Acústica",50000,"Cuerdas","Fender",6);
            Instrumentos sax2 = new Saxofon("Saxofon", 5000, "Viento", "Yamaha", 2);
            Instrumentos bat3 = new Bateria("Batería", 10000, "Percusión", "Pearl", 5, 1);
            //Para llamar los métodos más rápido, se meten en un arreglo, además no conienen muchos métodos
            //Pues los insrumentos suenan y, este caso se imprimen sus datos. Son mas las
            //caracterísiticas que no comparten enter sí
            Instrumentos[] ins= { gui1, sax2, bat3 };
            //Por cada instrumento, invoca los metodos de las clases.
            foreach(Instrumentos item in ins)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(item.Sonar());
            }

        }
    }
}
