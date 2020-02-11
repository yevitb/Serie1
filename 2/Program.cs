
using System;

namespace serie1._2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Ingresar los numeros y lanzar error de ser un tipo distinto al requerido.
            int num1 = 0;
            int num2 = 0;
            int bandera = 0;
            do 
            {
                try
                {
                    Console.WriteLine("Ingresa el primer numero: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    //Checar si los nuemro ingresados son mayor a 9 o menor a 0
                    if (num1 < 1 )
                        throw new LessOne();
                    else if (num1 > 9 )
                        throw new MoreNine();
                    else
                        bandera = 1;
                }
                catch (MoreNine mn)
                {
                    Console.WriteLine("\n" + mn.Message);
                }
                catch (LessOne lo)
                {
                    Console.WriteLine("\n" + lo.Message);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\n" + fe.Message);
                }
            } while (bandera != 1) ;
            do
            {
                try
                {
                    Console.WriteLine("Ingresa el segundo numero: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    //Checar si los nuemro ingresados son mayor a 9 o menor a 0
                    if ( num2 < 1)
                        throw new LessOne();
                    else if ( num2 > 9)
                        throw new MoreNine();
                    else
                        bandera = 1;
                }
                catch (MoreNine mn)
                {
                    Console.WriteLine("\n" + mn.Message);
                }
                catch (LessOne lo)
                {
                    Console.WriteLine("\n" + lo.Message);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\n" + fe.Message);
                }
            } while (bandera != 1);
            try 
            { 
            Nat(num1, num2);

            }
            catch (MoreNine mn)
            {
                Console.WriteLine("\n" + mn.Message);
            }
            catch (LessOne lo)
            {
                Console.WriteLine("\n" + lo.Message);
            }
            catch ( FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
            }
            Console.ReadKey();
        }
        public static  void Nat(int num1, int num2)
        {
            Console.WriteLine("Los numeros naturales del 1-100, exceptuando los multiplos de {0} y {1} son: ", num1, num2);
            //Imprimir los numeros naturales de 1 - 100 y, de ser multiplo de los numeros ingresados, se imprime clap en lugar del numero
            for (int i=1;i<101;i++)
            {
                if (i % num1 == 0 || i % num2 == 0)
                    Console.WriteLine("clap");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
