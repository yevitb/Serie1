using System;

namespace Serie1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir cadena ausuario
            Console.WriteLine("Ingresar cadena");
            string cadena = Console.ReadLine();
            Sub(cadena);
        }
        public static void Sub(string cadena)
        {
            //Pasar la cadena aminusculas para reducir errores
            string cadena1 = cadena.ToLower();
            string cadena2="";
            int bandera = 0;
            int cont = 0;
            //Buscar las vocales en la cadena
            for (int i=0; i<cadena.Length;i++)
            {
                switch (cadena1[i])
                {
                    case 'a':
                        bandera = i;
                        break;
                    case 'e':
                        bandera = i;
                        break;
                    case 'i':
                        bandera = i;
                        break;
                    case 'o':
                        bandera = i;
                        break;
                    case 'u':
                        bandera = i;
                        break;
                    default:
                        bandera = 0;
                        break;
                }
                //Agregar la f antes de cada vocal
                if (bandera != 0)
                {
                    cadena2 = cadena2.Substring(0, i + cont);
                    cadena2 = cadena2 + "f" + cadena[i];
                    cont++;
                }
                //si no es vocal, solo agregala a la cadena
                else
                {
                    cadena2 = cadena2 + cadena[i];
                }
            }
            Console.WriteLine(cadena2);
            Console.ReadKey();
        }
    }
}
