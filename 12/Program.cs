using System;
using System.Collections.Generic;

namespace serie1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de las dos listas, tanto para precios como productos
            List<string> Productos = new List<string>();
            List<double> Precios = new List<double>();
            Console.WriteLine("¡Bienvenido a Becario-Mart!");
            int opc = 0;
            int bandera = 0;
            do
            {
                try
                {
                    //Primer menú para agregar producto o pagar, loq ue nos lleva al segundo menú
                    bandera = 0;
                    Console.WriteLine("¿Qué deseas hacer?\n\t1)Agregar Producto\n\t2)Pagar");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            AgregarProd(Productos, Precios);
                            break;
                        case 2:
                            ImprimirProd(Productos, Precios, bandera);
                            bandera = 2;
                            break;
                    }
                }
                catch( FormatException fe)
                {
                    Console.WriteLine("\n" + fe.Message);
                }
            } while (bandera != 2);
            do
            {
                try
                {
                    //Segundo menú para ver productos, dejar produtos agregar productos o pagar.
                    bandera = 0;
                    Console.WriteLine("Qué deseas hacer ahora?\n\t1)Dejar Producto\n\t2)Ver mis productos\n\t3)Seguir comprando\n\t4)Pagar");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            ImprimirProd(Productos, Precios, bandera);
                            DejarProd(Productos,Precios);
                            break;
                        case 2:
                            ImprimirProd(Productos,Precios,bandera);
                            break;
                        case 3:
                            AgregarProd(Productos,Precios);
                            break;
                        case 4:
                            //La bandera =2 hace a diferencia entre pagar o solo imprimir los productos y precios
                            bandera = 2;
                            bandera = ImprimirProd(Productos, Precios, bandera);
                            break;
                    }
                }
                catch (FormatException fe)
                {
                Console.WriteLine("\n" + fe.Message);
                }

            } while (bandera != 2);
        }
        //Método para agregar  productos, nombre y precio
        public static void AgregarProd(List<string> Productos, List<double> Precios)
        {
            try
            {
            Console.Write("Nombre Producto: ");
            string nombre = Console.ReadLine();
            Console.Write("\nPrecio Producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Productos.Add(nombre);
            Precios.Add(precio);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
            }
        }
        //Metodo para imprimir los productos o pagar si la bandrea=2.
        public static int ImprimirProd(List<string> Productos, List<double> Precios,int bandera)
        {
            try
            {
            double dinero = 0;
            double gastado = 0;
             //Si la bandera =2, entonces entra al ciclo y pregunta con cuanto  dinero cuenta,
             //De ser menor al total de los productos seleccionados, manda un mensaje de dejar productos,
             //para lo cual se le manda al menú 2 de nuevo, para dejar productos
             // de contar con el dinero se le manda un menajd e "Gracias por su compra" y se le
             //indica el cambio.
             //Ahora  si la bander !=2 etnces se imprimen los productos
            if (bandera == 2)
            {
                Console.WriteLine("¿Con cuanto dinero cuentas? ");
                dinero = Convert.ToDouble(Console.ReadLine());
                for (int i=0; i<Productos.Count;i++)
                {
                    gastado = gastado + Precios[i];
                }
                    if (gastado <= dinero)
                    {
                        Console.WriteLine("¡Gracias por su compra!");
                        double cambio = dinero - gastado;
                        Console.WriteLine("Su cambio es: {0}", cambio);
                    }

                    else
                    {
                        Console.WriteLine("Dinero insuficiente. Debe dejar productos.");
                        bandera = 0;
                    }
            }
            else
            {
                for (int i = 0; i < Productos.Count; i++)
                {
                    Console.WriteLine("{0}\t{1}.", Productos[i],Precios[i]);
                }
            }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
            }
            return bandera;
        }

        //Metodo para dejar producto, indicando el nombre del prodcto, 
        //exactamente el nombre ingresado, este se busca en la lista de
        //productos y se elimina esa posición tanto de Preoductos como de Precios.
        public static void DejarProd(List<string> Productos, List<double> Precios)
        {
            Console.WriteLine("¿Qué producto desea dejar?");
            string nombre = Console.ReadLine().ToLower();
            int total = Productos.Count;
            for (int i = 0; i < Productos.Count; i++)
            {
                string prod=Productos[i].ToLower();
                if (prod ==nombre)
                {
                    Productos.RemoveAt(i);
                    Precios.RemoveAt(i);
                }
            }
            if (Productos.Count == total)
            {
                Console.WriteLine("Producto no encontrado.");
            }
            else
            {
                Console.WriteLine("Producto eliminado exitosamente.");
            }
        }
    }
}
