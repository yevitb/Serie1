using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Cuando  numeros obtendra la serie y sus excepciones de ingresar un dato incorrecto
                Console.WriteLine("Cuantos numeros de la serie se obtendrán?");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 1)
                    throw new LessThanZero();
                else
                {
                    Console.WriteLine("La serie Fibonacci de {0} elementos es: ",n);
                    for (int i = 0; i < n; i++)
                        Console.WriteLine(Fibonacci(i));
                }
            }
            catch(LessThanZero ltz)
            {
                Console.WriteLine("\n" + ltz.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
            }
        }
        //OBtener la seri de Fibonacci de forma recursiva.
        public static int Fibonacci(int num)
        {
            if (num < 2)
                return num;
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }
    }
}
