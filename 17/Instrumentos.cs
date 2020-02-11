using System;
using System.Collections.Generic;
using System.Text;

namespace Seri1._17
{
    class Instrumentos
    {
        //Encapsulamiento, permisos para ingresar a metodos o caracteristicas
        //de la clase.
        protected string Nombre;
        protected double Precio;
        protected string Tipo;
        protected string Marca;
        //constructor
        public Instrumentos(string nombre, double precio, string tipo,string marca)
        {
            Nombre = nombre;
            Precio = precio;
            Tipo = tipo;
            Marca = marca;
        }
        //Todos los instrumentos suenan y tocan notas
        public virtual string Sonar()
        {
            return "Do, Re, Mi, Fa, Sol, La, Si";
        }
        //Imprimir lso datos de los intrumentos.
        public override string ToString()
        {
            return Nombre+" $"+Precio+" "+Tipo+" "+Marca;
        }
    }
}
