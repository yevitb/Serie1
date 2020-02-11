using System;
//Usado para manejo de archivos
using System.IO;
//usado para manejo de listas
using System.Collections.Generic;

namespace Serie1._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de una lista para escribir estos datos en un archivo
            List<string> alumnos = new List<string>();
            alumnos.Add("Yazmin");
            alumnos.Add("Ximena");
            alumnos.Add("Saul");
            alumnos.Add("Abraham");
            alumnos.Add("Alex");
            alumnos.Add("Rodolfo");
            alumnos.Add("Beto");
            alumnos.Add("Daniel");
            alumnos.Add("Rodrigo");
            alumnos.Add("Tony");
            //Clase para manejo de archivos
            StreamWriter archivo;
            //Crear un archivo
            archivo = File.CreateText("Lista_Alumnos.txt");
            //Escribir los datos de la lista en el archivo.
            for (int i=0;i < alumnos.Count;i++)
            {
                archivo.Write(string.Format("\n{0}\t{1}", i+1, alumnos[i]));
            }
            Console.WriteLine("Archivo creado con contenido escrito exitosamente");
            //Cerrar archivo
            archivo.Close();

            //Clase para abrir archivo en modo lectura
            StreamReader archivoR = new StreamReader("Lista_Alumnos.txt");
            //Copiar el contenid completo del archivo en un variable
            string contenido = archivoR.ReadToEnd();
            //Imprimir el contenido de la variable que guarda lo que leyó en el archivo
            Console.WriteLine(contenido);
            //Cerrar arhcivo
            archivoR.Close();
        }
    }
}
