using System;

namespace serie1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Erik", 32, 1.90, 80);
            Console.WriteLine("Año de nacimiento: {0}",p1.AnioNac());
            Console.WriteLine("IMC de la persona {0}",p1.IMC());
            Console.WriteLine("año de nacimiento en romano: {0}",p1.Romanos());
        }
    }
}
