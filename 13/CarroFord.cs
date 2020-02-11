using System;
using System.Collections.Generic;
using System.Text;

namespace Seri1._13
{
    class CarroFord : Carro
    {
        //Modelo como Focus, Fiesta, Figo,etc 
        public string Modelo { get; set; }
        //Hatchback o Sedán
        public string HatchSedan { get; set; }
        //por omisión la marca siempre será Ford en esta clase.
        public string Marca = "Ford";
        public string Transmision { set; get; }
        //Constructor de la clase.
        public CarroFord(double peso,double altura, string modelo, string hatchSedan,string transmision):base(peso,altura)
        {
            Modelo = modelo;
            HatchSedan = hatchSedan;
            Transmision = transmision;
        }
        //imprime los datos del auto
        public override string ToString()
        {
            return string.Format("El carro de marca {0}, modelo {1}, altura {2}, peso {3}, tipo {4}, {5} y es de transmision {6}", Marca, Modelo, Altura, Peso, HatchSedan, Estado(), Transmision);
        }
    }
}
