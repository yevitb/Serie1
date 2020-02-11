using System;
using System.Collections.Generic;
using System.Text;

namespace serie1._8
{
    class Auto
    {
        string color;
        int anio;
        double precio;
        //Obtenemos el  año actual para calculos posteriores
        int anioActual = DateTime.Now.Year;
        protected string modelo;
        protected string marca;
        protected bool encendido = false;
        //Getters y setters
        protected string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }
        protected string Marca
        {
            set { marca = value; }
            get { return marca; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        //getter y setter del año, para el cual se checa que no sea mayor al año siguiente del presente, 
        //puesto que en las agencias sacan autos semanas antes de año nuevo. pero mayor a este no, pues no es posible.
        public int Anio
        {
            get { return anio; }
            set
            {
                int bandera = 0;
                do
                {
                    try
                    {
                        if (value > anioActual + 1)
                            throw new ValueException();
                        else
                        {
                            anio = value;
                            bandera = 1;
                        }
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine("\n" + fe.Message);
                    }
                    catch (ValueException ve)
                    {
                        Console.WriteLine("\n" + ve.Message);
                    }
                } while (bandera != 1);

            }
        }
        //Getter y setter de precio, checando que lo que se ingresa son numeros y no algun otro tipo de dato, 
        //de ingresar otro tipo de dato al esperado se lanza una excepcion y se detiene el programa
        public double Precio
        {
            get { return precio; }
            set
            {
                try
                {
                    precio = value;

                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\n" + fe.Message);
                }
            }
        }

        //Sobrecarga de los contructores
        public Auto(int anio)
        {
            Anio = anio;
        }
        public Auto(int anio, int precio)
        {
            Anio = anio;
            Precio = precio;
        }
        public Auto(int anio, int precio, string color, string modelo)
        {
            Anio = anio;
            Precio = precio;
            Color = color;
            Modelo = modelo;
        }
        public Auto(int anio, int precio, string color, string modelo, string marca)
        {
            Anio = anio;
            Precio = precio;
            Color = color;
            Modelo = modelo;
            Marca = marca;
        }

        //Metodos
        public bool Encendido()
        {
            Console.WriteLine("Encendiendo motor");
            encendido = true;
            return encendido;
        }
        public bool Apagado()
        {
            Console.WriteLine("Apagando motor");
            encendido = false;
            return encendido;
        }
        //Checa el estado del motor.
        public string Motor()
        {
            if (encendido)
                return "encendido";
            return "apagado";
        }
        public string  Claxon()
        {
            Console.WriteLine("Piiiiiiiiiiiiii");
            return "Claxon presionado";
        }
        public void Avanzar()
        {
            Console.WriteLine("Avanzando");
        }
        public void Reversa()
        {
            Console.WriteLine("Reversa");
        }
        //Imprimir datos de los autos.
        public override string ToString()
        {
            string cadena = "El auto " + Modelo + ", de la marca " + Marca + ", año " + Anio + ", tiene un precio de $" + Precio + ", se encuentra disponible en color " + Color + " y se encuentra " + Motor();
            return cadena;
        }
        

    }
}
