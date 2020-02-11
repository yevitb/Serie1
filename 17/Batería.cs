using System;
using System.Collections.Generic;
using System.Text;

namespace Seri1._17
{
    //Hereda de instrumentos
    class Bateria :Instrumentos
    {
        //Caractersiticas propias de la clase, Numero de tambores
        // y numero de pedales.
        protected int NoTambores;
        protected int NoPedales;
        //constructor
        public Bateria(string nombre, double precio, string tipo, string marca, int noTambores, int noPedales) : base(nombre, precio, tipo, marca)
        {
            NoTambores = noTambores;
            NoPedales = noPedales;
        }
        //Suena distinto a otros instrumentos. *BADUMTSSS*
        public override string Sonar()
        {
            return "Ba dum tsssss";
        }
        //Imprime los datos de la batería
        public override string ToString()
        {
            return "Nombre " + Nombre+"  $"+ Precio +" "+Tipo+" "+Marca +" No tambores "+ NoTambores+" No. pedales "+NoPedales;
        }
    }
}
