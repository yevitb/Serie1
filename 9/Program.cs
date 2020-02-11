
using System;

namespace Serie1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nuevo objeto ciruclo
            Circulo c1 = new Circulo();
            c1.radio = 5;
            //NUevo objeto trinagulo rectangulo
            Console.WriteLine("Area circulo: {0}",c1.Area());
            Triangulo t1 = new Triangulo(5,9);
            Console.WriteLine("Area del triangulo: {0}",t1.Area());
            Console.WriteLine("Hipotenusa: {0}",t1.Hipotenusa());
            Console.WriteLine("Angulo A: {0}",t1.alpha());
            Console.WriteLine("Angulo B: {0}",t1.beta());
            Console.WriteLine("Angulo C: {0}",t1.gamma());

        }
    }
}
