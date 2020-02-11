using System;
using System.Collections.Generic;
using System.Text;

namespace Seri1._11
{
    class Matrices
    {
       // public int Tamanio { set; get; }
        public static  void NuevaMatriz(ref double[,] matriz,int Tamanio)
        {
            //Ingresar datos a la matriz
            
            for (int i = 0; i < Tamanio; i++)
            {

                for (int j = 0; j < Tamanio; j++)
                {
                    int bandera = 0;
                    do
                    {
                        try
                        {
                            Console.WriteLine("Ingresar el valor de la posicion [{0}][{1}]", i, j);
                            matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                            bandera = 1;
                        }
                        catch (FormatException fe)
                        {
                            Console.WriteLine("\n" + fe.Message);
                        }
                    } while (bandera != 1);
                }
                
            }

        }
        public static void Imprimir(ref double[,] matriz, int Tamanio)
        {
            //Imprimir matriz
            for (int i = 0; i < Tamanio; i++)
            {

                for (int j = 0; j < Tamanio; j++)
                {
                        Console.Write("\t{0}", matriz[i, j]);
                }
                Console.WriteLine("\n");
            }

        }
        public static void Sumar(ref double[,] matriz1, ref double[,] matriz2, int Tamanio)
        {
            //Sumar las matrices, dato por dato.
            double [,] res = new double[Tamanio, Tamanio];
            Console.WriteLine("Operación a realizar");
            for (int i = 0; i < Tamanio; i++)
            {

                for (int j = 0; j < Tamanio; j++)
                {
                    Console.Write("\t{0} + {1}",matriz1[i, j],matriz2[i,j]);
                    res[i, j] = matriz1[i, j] + matriz2[i, j];
                }
                Console.WriteLine("\n");

            }
            Console.WriteLine("Matriz resultado:");
            //imprimir resultado
            for (int i = 0; i < Tamanio; i++)
            {

                for (int j = 0; j < Tamanio; j++)
                {
                    Console.Write("\t{0}", res[i, j]);
                }
                Console.WriteLine("\n");
            }
        }
        //Restar matrices e impresion del resultado
        public static void Restar(ref double[,] matriz1, ref double[,] matriz2, int Tamanio)
        {
            double[,] res = new double[Tamanio, Tamanio];
            Console.WriteLine("Operación a realizar");
            for (int i = 0; i < Tamanio; i++)
            {

                for (int j = 0; j < Tamanio; j++)
                {
                    Console.Write("\t{0} - {1}", matriz1[i, j], matriz2[i, j]);
                    res[i, j] = matriz1[i, j] - matriz2[i, j];
                }
                Console.WriteLine("\n");

            }
            //Imprimir resultados
            Console.WriteLine("Matriz resultado:");
            for (int i = 0; i < Tamanio; i++)
            {

                for (int j = 0; j < Tamanio; j++)
                {
                    Console.Write("\t{0}", res[i, j]);
                }
                Console.WriteLine("\n");
            }
        }
        //Multiplicacion del resultado
        public static void Multiplicar(ref double[,] matriz1, ref double[,] matriz2, int Tamanio)
        {
            double[,] res = new double[Tamanio, Tamanio];
            Console.WriteLine("Operación a realizar");
            for (int i = 0; i < Tamanio; i++)
            {

                for (int j = 0; j < Tamanio; j++)
                {
                    //Se recorre la primer la suma de las multiplicaciones de la primera fila de la primer matriz con la primer clumna de la segunda matriz. Así sucesivamente hasta la suma de la utltima fila de la primera matriz con la ultima columna de la segunda matriz par aobtener los datos de la multiplicacion,
                    for (int k = 0; k < Tamanio; k++)
                    {
                        if (k != 0)
                            Console.Write("+");
                        Console.Write("{0} * {1}", matriz1[i, k], matriz2[k, j]);
                        res[i, j] = res[i,j]+(matriz1[i, k] * matriz2[k, j]);
                        ;
                    }
                    Console.Write("\t");
                }
                Console.WriteLine("\n");

            }
            //Imprimir resultado
            Console.WriteLine("Matriz resultado:");
            for (int i = 0; i < Tamanio; i++)
            {

                for (int j = 0; j < Tamanio; j++)
                {
                    Console.Write("\t{0}", res[i, j]);
                }
                Console.WriteLine("\n");
            }
        }

    }
}
