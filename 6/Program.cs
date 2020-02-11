using System;

namespace Serie1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de los objetos y utilizacion de lo smetodos.
            CuentaBancaria p = new CuentaBancaria("Abisinia", 10000);
            p.mostrarInformacion();
            p.retiro(11000);
            p.deposito(100);
            p.retiro(5000);
            CuentaBancaria p2 = new CuentaBancaria("Roberto", 20000);
            p2.mostrarInformacion();
            p2.retiro(10000);
            p2.deposito(50);
            p2.retiro(15000);
            Console.ReadKey();

        }
    }
}
