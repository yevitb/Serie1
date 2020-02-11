using System;
using System.Collections.Generic;
using System.Text;

namespace Serie1._6
{
    class CuentaBancaria
    {
        protected string Nombre {get;set; }
        protected int Saldo { get; set; }
        //COnstructor
        public CuentaBancaria (string nombre, int saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }
        //Metodo para imprimir la informacion de la cuenta
        public void mostrarInformacion()
        {
            Console.WriteLine("Cuenta: {0}", Nombre);
            Console.WriteLine("Saldo: {0}", Saldo);
        }
        //Metodo para hcacer undeposito al saldo de la cuenta
        public void deposito(int deposito)
        {
            Saldo = Saldo+ deposito;
            mostrarInformacion();
        }
        //Metodo para retirar dinero, pero antes checar que el saldo sea suficiencte, de lo conrario marca alerta.
        public void retiro(int cantidad)
        {
            if (cantidad > Saldo)
                Console.WriteLine("No se puede realizar la operación. Saldo insificiente");
            else
            {
                Saldo = Saldo - cantidad;
                mostrarInformacion();
            }
        }
    }
}
