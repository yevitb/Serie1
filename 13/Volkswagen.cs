using System;
using System.Collections.Generic;
using System.Text;

namespace Seri1._13
{
    class Volkswagen : Carro
    {

        //Modelo Jetta, Bocho,etc
        public string Modelo { get; set; }
        //HAtchback o Sedán
        public string HatchSedan { get; set; }
        //La marca siempre será Volkwagen si son objetos creados de esta clase.
        public string Marca = "Volkswagen";
        public string Transmision { set; get; }
        //Constructor de la clase.
        public Volkswagen(double peso, double altura, string modelo, string hatchSedan, string transmision) : base(peso, altura)
        {
            Modelo = modelo;
            HatchSedan = hatchSedan;
            Transmision = transmision;
        }
        //imprimir los datos del auto.
        public override string ToString()
        {
            return string.Format("El carro de marca {0}, modelo {1}, altura {2}, peso {3}, tipo {4}, {5} y es de transmision {6}", Marca, Modelo, Altura, Peso, HatchSedan, Estado(), Transmision);
        }
    }
}
