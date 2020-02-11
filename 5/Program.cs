using System;
using System.Collections.Generic;

namespace serie1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Diccionario para los contactos de la agenda
                Dictionary<string, string> contactos = new Dictionary<string, string>(); 
                int opcion;
                do
                {
                    //Elegir opcion del menú, depnendiend del cado, obtencin d datos para la accion a realizar
                    Console.WriteLine("Menu \n \t1) Agregar contacto\n\t2)Eliminar contacto\n\t3)Mostrar contacto\n\t4)Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    string nombre;
                    string numero;
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Nombre del nuevo contacto: ");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Numero telefonico del contacto nuevo: ");
                            numero = Console.ReadLine();
                            Agregar(nombre, numero, contactos);
                            break;
                        case 2:
                            Console.WriteLine("Nombre del contacto a eliminar: ");
                            nombre = Console.ReadLine();
                            Eliminar(nombre, contactos);
                            break;
                        case 3:
                            Console.WriteLine("Nombre del contacto a mostrar: ");
                            nombre = Console.ReadLine();
                            Mostrar(nombre, contactos);
                            break;
                        default:
                            throw new AnotherCharacter();
                    }

                } while (opcion != 4) ;
            }
            catch (AnotherCharacter ac)
            {
                Console.WriteLine("\n" + ac.Message);
            }
            catch ( FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
            }
        }
        //Metdo para agregar contacto
        public static void Agregar(string nombre, string numero, Dictionary<string,string> contactos)
        {
            contactos.Add(nombre, numero);
        }
        //MEtodo para eliminar contacto, buscando por nombre
        public static void Eliminar(string nombre, Dictionary<string, string> contactos)
        {
            if (contactos.ContainsKey(nombre))
            {
                contactos.Remove(nombre);
                Console.WriteLine("El contacto se ha eliminado exitosamente. ");
            }
            else
                Console.WriteLine("El usuario no existe");
        }
        //Metodo para mostrar contacto de existir, buscandolo por nombre.
        public static void Mostrar(string nombre, Dictionary<string, string> contactos)
        {
            if (contactos.ContainsKey(nombre))
                Console.WriteLine("El contacto {0} tiene el numero {1}", nombre, contactos[nombre]);
            else
                Console.WriteLine("El usuario no existe");
        }

    }
}
