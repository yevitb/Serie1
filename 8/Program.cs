using System;

namespace serie1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*public Auto(int anio, int precio, string color, string modelo, string marca)
        {
            Anio = anio;
            Precio = precio;
            Color = color;
        }*/
            Auto a1 = new Auto(2009,80000,"azul marino","Focus","Ford");
            Auto a2 = new Auto(2014, 180000, "negro", "Tiida", "Nissan");
            Auto a3 = new Auto(2020, 250000, "rojo", "Jetta", "Volkswagen");
            //Vemos los datos del auto 1 y activamos el claxon
            Console.WriteLine("====================Auto1======================");
            Console.WriteLine(a1.ToString());
            a1.Claxon();
            a1.Avanzar();
            //Encendemos el auto, vemos sus datos y lo apagamos para checar que los datos del auto ha cambiado en su estado.
            Console.WriteLine("====================Auto2======================");
            a2.Encendido();
            Console.WriteLine(a2.ToString());
            a2.Apagado();
            a2.Reversa();
            Console.WriteLine(a2.ToString());
            //Actualizamos uno de los datos del carro y vemos los cambios en los datos del auto, en este caso el dato actualiado es precio.
            Console.WriteLine("====================Auto3======================");
            Console.WriteLine(a3.ToString());
            a3.Precio = 300000;
            Console.WriteLine(a3.ToString());


        }
    }
}
