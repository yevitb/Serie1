using System;

namespace Serie1._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int bandera = 0;
            decimal num1 = 0;
            decimal num2 = 0;
            do
            {
                bandera = 0;
                try
                {
                    //ingresar el primer numero y esperar a que sea válido 
                    Console.WriteLine("============CALCULADORA=============");
                    Console.Write("Ingresa el primer numero para la operación: ");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    bandera = 1;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\n" + fe.Message);
                }
            } while (bandera != 1);
            do
            {
                bandera = 0;
                try
                {
                    //Ingresar el segundo numero y no salir hasta que se ingrese un valor que se requiere.
                    Console.Write("Ingresa el segundo numero para la operación: ");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    bandera = 1;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\n" + fe.Message);
                }
            } while (bandera != 1);
            do
            {
                bandera = 0;
                try 
                {
                    //Menú y espera de la opción para hacer el calculo requerido.
                    Console.WriteLine("\t1)\tSuma\n\t2)\tResta\n\t3)\tMultiplicación\n\t4)\tDivisión\n\t5)\tSalir");
                    int opc = Convert.ToInt32(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Suma(num1,num2);
                            break;
                        case 2:
                            Resta(num1,num2);
                            break;
                        case 3:
                            Multiplicacion(num1, num2);
                            break;
                        case 4:
                            División(num1,num2);
                            break;
                        case 5:
                            bandera = 1;
                            break;
                        default:
                            Console.WriteLine("Intenemoslo de nuevo");
                            break;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\n" + fe.Message);
                }
            } while (bandera!=1);
            
            
        }
        //Metodo de suma, imprime el resultado
        public static void Suma(decimal num1, decimal num2)
        {
            Console.WriteLine(num1 + num2);
        }
        //Metodo de resta, imprime el resultado
        public static void Resta(decimal num1, decimal num2)
        {
            Console.WriteLine(num1 - num2);
        }
        //Método de multiplicacion, imprime el resultado
        public static void Multiplicacion(decimal num1, decimal num2)
        {
            Console.WriteLine(num1 * num2);
        }
        //Método de división, imprime el resultado
        public static void División(decimal num1, decimal num2)
        {
            try
            {
                //Si el división entre cero manda una excepcion
                if (num2 == 0)
                    throw new DivededByZero();
                Console.WriteLine(num1 / num2);
            }
            catch (DivededByZero dbz)
            {
                Console.WriteLine("\n" + dbz.Message);
            }
        }
    }
}
