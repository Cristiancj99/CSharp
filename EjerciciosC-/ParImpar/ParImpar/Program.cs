using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    class Program
    {
        public static void Comprovacion(int numero1, int numero2)
        {
            if (numero1 % 2 ==0)
            {
                Console.WriteLine(numero1 + " Es par.");
                Console.ReadLine();
            }
            else if (numero2 % 2 ==0)
            {
                Console.WriteLine(numero2 + " Es impar");
                Console.ReadLine();
            }
            else if ( (numero2 % 2!=0) && (numero1 %2 !=0 ))
            {
                Console.WriteLine(" Ningún número es par !! ");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            int primer_numero;
            int segundo_numero;

            Console.WriteLine("Introduzca el primer número: ");
            primer_numero = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número");
            segundo_numero = System.Convert.ToInt32(System.Console.ReadLine());
            Comprovacion(primer_numero, segundo_numero);


        }
    }
}