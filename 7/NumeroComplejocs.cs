using System;
using System.Collections.Generic;
using System.Text;

namespace serie1._7
{
    class NumeroComplejocs
    {
        protected int ParteReal { set; get; }
        protected string ParteImaginaria { set; get; }
        public NumeroComplejocs(int parteReal, string parteImaginaria)
        {
            ParteReal = parteReal;
            ParteImaginaria = parteImaginaria;
        }

        public void Imprimir()
        {
            Console.WriteLine("El numero es {0}{1}", ParteReal, ParteImaginaria);
        }
        public string Sumar( int parteReal2, string parteImaginaria2)
        {
            int real= ParteReal + parteReal2;
            int cadena1=0;
            string signo1 = ParteImaginaria.Substring(0, 1);
            for (int i = 1 ; i < ParteImaginaria.Length; i++)
            {
                
                if (ParteImaginaria[i]=='i')
                {
                    if (i == '1')
                        cadena1 = 1;
                    else
                    {
                        cadena1 = Convert.ToInt32(ParteImaginaria.Substring(1, i - 1));
                    }
                }
            }
            string signo2 = parteImaginaria2.Substring(0, 1);
            int cadena2=0;
            for (int i = 1; i < parteImaginaria2.Length; i++)
            {
                
                if (parteImaginaria2[i] == 'i')
                {
                    if (i == '1')
                        cadena1 = 1;
                    else
                    {
                        cadena2 = Convert.ToInt32(parteImaginaria2.Substring(1, i - 1));
                    }
                }
            }
            int imaginaria=0;
            if (signo1 == "+" && signo2 == "+")
                imaginaria = cadena1 + cadena2;
            else if (signo1 == "+" && signo2 == "-")
                imaginaria = cadena1 - cadena2;
            else if (signo1 == "-" && signo2 == "+")
                imaginaria = -cadena1 + cadena2;
            else if (signo1 == "-" && signo2 == "-")
                imaginaria = - cadena1 - cadena2;
            string res = Convert.ToString(real) + "+("+ Convert.ToString(imaginaria) + "i)";
            return res;
        }
    }
}
