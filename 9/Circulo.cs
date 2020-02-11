using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._9
{
    class Circulo
    {
        public double radio { get; set; }
       //Obtener area de circulo
        public double Area()
        {
            radio = Math.Pow(radio,2);
            return Math.PI*(radio);
        }

    }
}
