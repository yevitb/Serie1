using System;
using System.Collections.Generic;
using System.Text;

namespace Seri1._17
{
    //Hereda de instrumentos
    class Saxofon:Instrumentos
    {
        //Se agrega el numero de boquillas que viene con el instrumento
        protected int NoBoquilla;
        //Constructor
        public Saxofon(string nombre, double precio, string tipo, string marca, int noBoquilla):base(nombre, precio, tipo,marca)
        {
            NoBoquilla = noBoquilla;
        }
        //El saxofon no suena igua al al guitarra o batería.
        public override string Sonar()
        {
            return "Turururutu";
        }
        //Imprime los datos de saxofon.
        public override string ToString()
        {
            return Nombre+" $" + Precio +" "+ Tipo +" "+ Marca +" No. de boquillas "+ NoBoquilla;
        }
    }
}
