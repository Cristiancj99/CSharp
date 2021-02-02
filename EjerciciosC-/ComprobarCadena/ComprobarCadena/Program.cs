using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobarCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=0;
            Console.WriteLine("Introduzca su cadena para comprobar cuantos 7 hay en esta: ");
            String cadena = Console.ReadLine();
            foreach(char i in cadena)
            {        
                if (i == '7')
                {
                    contador++;
                }
            }
            Console.WriteLine("el numero 7 se repite: " + contador + " veces");
            Console.ReadLine();
        }
    }
}
