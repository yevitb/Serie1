using System;
using System.Collections.Generic;
using System.Text;

namespace Seri1._13
{
    class Carro
    {
        private double peso;
        public double Peso
        {
            set 
            {
                //Checamos que el dato ingresado sea válido, aunque sea para un Hot Wheels
                if (value < 0)
                    Console.WriteLine("Ningun carro pesa menos de 0, ni un Hot Wheels");
                else
                {
                    peso = value;
                } 
            }
            get { return peso; }
        }
        private double altura;
        public double Altura
        {
            set
            {
                //Checamps valores para altura
                if (value < 0)
                    Console.WriteLine("Ningun carro mide menos de 0, ni un Hot Wheels");
                else
                {
                    altura = value;
                }
            }
            get { return altura; }
        }
        //Se define que todo auto recién creado se encuentra apagado.
        public bool  Encendido=false;
        //constructor
        public Carro (double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }
        //Metodo que enciende el carro, regresando un valor vredadero, además de
        //imprimir una cadena que avisa del estado de del auto.
        public bool Encender()
        {
            Console.WriteLine("Se ha encendido el auto.");
            return Encendido = true;
        }
        //Método de apagado del carro, regresa valor falso del estado del motor,
        //Además imprime una cadena que avisa que se ha apagado.
        public bool Apagar()
        {
            Console.WriteLine("Se ha apagado el auto.");
            return Encendido = false;
        }
        //Metodo que checa una variavle, modificada en Encender() y Apagar()
        //para ver si esta encendido o apagado
        public string Estado()
        {
            if (Encendido == false)
                return "Auto apagado";
            return "Auto encendido";
        }
        //Metodo que imprime los valores de los autos.
        public override string ToString()
        {
            return string.Format("El auto peso {0} y su altura es {1}",Peso,Altura);
        }

    }
}
