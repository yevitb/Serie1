using System;

namespace serie1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numero complejos, ingresarlos para hacer la spruebas.
            string complejo = "2-3i";
            int real1=0;
            string imaginario1="";
            int real2=0;
            string imaginario2="";
            //Partir la cadena en parte real e imaginaria del primer numero complejo para así pasarlos separados ocmo atributos de la clase de numero complejos.
            for (int i = 0; i < complejo.Length; i++)
            {
                //Encuentra el sigo y parte la cadena
                if (complejo[i] == '+' || complejo[i] == '-')
                { 
                    
                    real1 = Convert.ToInt32(complejo.Substring(0, i));
                    imaginario1 = complejo.Substring(i, complejo.Length - 1);

                }
            }
            //De igual forma parte el segundo numero complejo
            NumeroComplejocs n1 = new NumeroComplejocs(real1, imaginario1);
            string complejo2 = "4+8i";
            for (int i = 0; i < complejo2.Length; i++)
            {
                if (complejo2[i] == '+' || complejo2[i] == '-')
                {
                    real2 = Convert.ToInt32(complejo2.Substring(0, i));
                    imaginario2 = complejo2.Substring(i, complejo2.Length - 1);
                }
            }
            //Imprime los numero complejos y sumalos.
            Console.WriteLine("real2 {0}, imaginario2 {1}", real2, imaginario2);
            NumeroComplejocs n2 = new NumeroComplejocs(real2, imaginario2);
            n1.Imprimir();
            n2.Imprimir();
            string res=n1.Sumar(real2, imaginario2);
            Console.WriteLine("El resultado de la suma de los numeros reales ingresados es: {0}", res);
        }
    }
}
