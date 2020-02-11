using System;
using System.Collections.Generic;
using System.Text;

namespace Seri1._17
{
    //Hereda de instrumentos
    class Guitarra : Instrumentos
    {
        public int NoCuerdas { get; set; }
        //Hereda algunas caracteristias y las que no, sea gregan en el constructor
        public Guitarra(string nombre, double precio, string tipo, string marca, int noCuerdas) : base(nombre, precio,tipo,marca)
        {
            NoCuerdas = noCuerdas;
        }
        //Las guitarras suenan al rasguear las cuerdas
        public override string Sonar()
        {
            return "Rasgueo";
        }
        //Imprime los datos de las guitarras
        public override string ToString()
        {
            return Nombre+" $"+Precio+" "+Tipo+" "+Marca+" No. cuerdas "+NoCuerdas;
        }

    }
}
