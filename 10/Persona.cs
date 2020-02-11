using System;
using System.Collections.Generic;
using System.Text;

namespace serie1._10
{
    class Persona
    {
        protected string Nombre { get; set; }
        protected int Edad { get; set; }
        protected double Estatura { get; set; }
        protected double Peso { get; set; }
        //Sobrecarga de constructores
        public Persona (string nombre, int edad, double estatura, double peso)
        {
            Nombre = nombre;
            Edad = edad;
            Estatura = estatura;
            Peso = peso;
        }
        public Persona(string nombre, int edad, double estatura)
        {
            Nombre = nombre;
            Edad = edad;
            Estatura = estatura;
        }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public Persona() { }
        //Obtener el indice de masa corporal y su diagniostico del peso de una persona.
        public string IMC()
        {
            double est2 = Math.Pow(Estatura, 2);
            double imc = Peso / est2;
            string comp;
            if (imc <= 18.5)
                comp = "Peso inferior";
            else if (imc >= 18.6 && imc <= 24.9)
                comp = "Normal";
            else if (imc >= 25 && imc < 29.9)
                comp = "Peso superior al normal";
            else if (imc > 30)
                comp = "Obesidad";
            else
                comp = "Alienigena";
            string res = "Si condigion es " + comp + " pues su IMC es " + imc;

            return res;
        }
        //Obtener el año de nacimiento a partir de la edad y si ya se ha cumplido años o no
        public int AnioNac()
        {
            int cont = 0;
            int opc = 0;

            Console.WriteLine("¿Ya pasó tu cumpleaños en el año presente?\n\t1)Sí\n\t2)No");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    cont = 0;
                    break;
                case 2:
                    cont = 1;
                    break;
                default:
                    Console.WriteLine("Se tomará como que no ha cumplido años");
                    cont = 1;
                    break;
            }
            return DateTime.Now.Year - Edad-cont;
        }
        //Comversion del año de nacimiento a numeros romanos.
        public string Romanos()
        {
            string romanos="";
            string anio = Convert.ToString(AnioNac());

            switch (anio[0])
            {
                case '1':
                    romanos = "M";
                    break;
                case '2':
                    romanos = "MM";
                    break;
                case '3':
                    romanos = "MMM";
                    break;
                default:
                    Console.WriteLine("UPS!, ha surgido un error");
                    break;
            }
            switch (anio[1])
            {
                case '1':
                    romanos = romanos + "C";
                    break;
                case '2':
                    romanos = romanos + "CC";
                    break;
                case '3':
                    romanos = romanos + "CCC";
                    break;
                case '4':
                    romanos = romanos + "CD";
                    break;
                case '5':
                    romanos = romanos + "D";
                    break;
                case '6':
                    romanos = romanos + "DC";
                    break;
                case '7':
                    romanos = romanos + "DCC";
                    break;
                case '8':
                    romanos = romanos + "DCCC";
                    break;
                case '9':
                    romanos = romanos + "CM";
                    break;
            }
            switch (anio[2])
            {
                case '1':
                    romanos = romanos + "X";
                    break;
                case '2':
                    romanos = romanos + "XX";
                    break;
                case '3':
                    romanos = romanos + "XXX";
                    break;
                case '4':
                    romanos = romanos + "XL";
                    break;
                case '5':
                    romanos = romanos + "L";
                    break;
                case '6':
                    romanos = romanos + "LX";
                    break;
                case '7':
                    romanos = romanos + "LXX";
                    break;
                case '8':
                    romanos = romanos + "LXXX";
                    break;
                case '9':
                    romanos = romanos + "XC";
                    break;
            }
            switch (anio[3])
            {
                case '1':
                    romanos = romanos + "I";
                    break;
                case '2':
                    romanos = romanos + "II";
                    break;
                case '3':
                    romanos = romanos + "III";
                    break;
                case '4':
                    romanos = romanos + "IV";
                    break;
                case '5':
                    romanos = romanos + "V";
                    break;
                case '6':
                    romanos = romanos + "VI";
                    break;
                case '7':
                    romanos = romanos + "VII";
                    break;
                case '8':
                    romanos = romanos + "VIII";
                    break;
                case '9':
                    romanos = romanos + "IX";
                    break;
            }
            return romanos;

        }




    }
}
