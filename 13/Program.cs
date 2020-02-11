using System;

namespace Seri1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creaoms objetos de ambas clases
            CarroFord c1 = new CarroFord(120000,1.87,"Focus","Sedán","Estándar");
            Volkswagen v1 = new Volkswagen(115000,1.90,"Jetta","Sedán","Automática");
            //Imprimimos sus datos y estado, ya sea encendido o apagado, por default debe estar alagado.
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1.Estado());
            //Lo encendemos y checamos el estado
            c1.Encender();
            Console.WriteLine(c1.Estado());
            //Se apaga y volvemos a chear el estado
            c1.Apagar();
            Console.WriteLine(c1.Estado());
            //HAcemos la actualizacion de un dato y checamos los datos.
            c1.Altura = 2.00;
            Console.WriteLine(c1.ToString());

            //Vemos la imporfacon del auto.
            Console.WriteLine(v1.ToString());
            //Encendemos el auto y checamos el estado
            v1.Encender();
            Console.WriteLine(v1.Estado());
            //Lo apagamos y volvemos a checar el estado
            v1.Apagar();
            Console.WriteLine(v1.Estado());
            //Actualizamos un dato e imprimimos todo de este objeto.
            v1.Peso = 200000;
            Console.WriteLine(v1.ToString());
        }
    }
}
