using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._9
{
    class Triangulo
    {
        public int catA { get; set; }
        public int catB { get; set; }
        public Triangulo(int a, int b)
        {
            catA = a;
            catB = b;
        } 
        //Obtener area de tringulo rectangulo
        public double Area()
        {
            double a = catA * catB / 2;
            return a;
        }
        //Obtener hipotenusa con el teorema de pitagoras
        public double Hipotenusa()
        {
            double a = Math.Pow(catA, 2);
            double b = Math.Pow(catB, 2);
            return Math.Sqrt(a + b);
        }
        //Obtener angulo gamma
        public double gamma()
        {
            double A = alpha();
            double B = beta();
            return 180-A-B;
        }
        //OBtener angul  beta
        public double beta()
        {
            double d = catB / Hipotenusa();
            return Math.Asin(d)*180/Math.PI;
        }
        //Obtener ngulo alpha
        public double alpha()
        {
            double d = catA / Hipotenusa();
            return Math.Asin(d)*180/Math.PI;
        }
    }
}
