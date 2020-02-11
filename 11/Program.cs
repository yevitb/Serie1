using System;

namespace Seri1._11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int Tamano=0;
            int opc=0;
            int bandera = 0;
            do 
            {
                try
                {
                    //Indicar el tamaño de las matrices cuadradas y excepciones, además de evitar que se cierre el programa en caso de mete algun valor no cálido
                    Console.WriteLine("¿Cual es el tamaño de las matrices? ");
                    Tamano = Convert.ToInt32(Console.ReadLine());
                    bandera = 1;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\n" + fe.Message);
                }
            } while (bandera != 1);
            bandera = 0;
            //Crear ambas matrices con el tamaño indicado
            double[,] matriz1 = new double[Tamano, Tamano];
            double[,] matriz2 = new double[Tamano, Tamano];
            //LLenar la matriz 1
            Console.WriteLine("Es hora de llenar la matriz A: ");
            Matrices.NuevaMatriz(ref matriz1, Tamano);
            //Llenar la matriz 2
            Console.WriteLine("Es hora de llenar la matriz B: ");
            Matrices.NuevaMatriz(ref matriz2, Tamano);
            do
            {
                bandera = 0;
                try
                {
                    //ELegir la operacion a realizar, previamente a cada operacion dela s matrices se imprimen las matrices
                    //a operar y, posteriormente, su resultado.
                    //L aunica forma de cerrar el programa será con la opción 4. De no poner ninguna opcion 
                    //dada, se manda una excepcion
                    Console.WriteLine("=============Menú=============");
                    Console.WriteLine("\t1)Suma\n\t2)Resta\n\t3)Multiplicacion\n\t4)Salir");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("Matriz1");
                            Matrices.Imprimir(ref matriz1, Tamano);
                            Console.WriteLine("Matriz2");
                            Matrices.Imprimir(ref matriz2, Tamano);
                            Matrices.Sumar(ref matriz1, ref matriz2, Tamano);
                            break;
                        case 2:
                            Console.WriteLine("Matriz1");
                            Matrices.Imprimir(ref matriz1, Tamano);
                            Console.WriteLine("Matriz2");
                            Matrices.Imprimir(ref matriz2, Tamano);
                            Matrices.Restar(ref matriz1, ref matriz2, Tamano);
                            break;
                        case 3:
                            Console.WriteLine("Matriz1");
                            Matrices.Imprimir(ref matriz1, Tamano);
                            Console.WriteLine("Matriz2");
                            Matrices.Imprimir(ref matriz2, Tamano);
                            Matrices.Multiplicar(ref matriz1, ref matriz2, Tamano);
                            break;
                        case 4:
                            bandera = 1;
                            break;
                        default:
                            Console.WriteLine("Intentemoslo de nuevo.");
                            break;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\n" + fe.Message);
                }
            } while (bandera != 1);

        }
    }
}

