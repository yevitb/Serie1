using System;

namespace serie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            try
            {
                //Obtener los numeros naturales a sumar, tomando en cuenta las excepciones por ingreso erroneo de datos.
                Console.WriteLine("Ingresar el numero total de numeros naturales a sumar:  ");
                num = Convert.ToInt32(Console.ReadLine());
                int suma = Naturales(num);
                Console.WriteLine(suma);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Favor de ingresar un numero natural.");

            }
            //El nuemro ingresado debe ser natural, por lo cual si se ingresa 0 o menos, marca error.
            catch (LessOneNumberException lz)
            {
                Console.WriteLine("\n" + lz.Message);
                Console.WriteLine("ERROR");
            }
            
        
            Console.ReadKey();
        }
        //Función para obtener la suma de los numeros naturales indicados.
        public static int Naturales(int n)
        {
            int sum = 0;
            if (n < 1)
                throw new LessOneNumberException("Un numero mayor a 0, buddy!");
            for (int i=1;i<n+1;i++)
                sum+=i;
            return sum;
        }
    }
}
