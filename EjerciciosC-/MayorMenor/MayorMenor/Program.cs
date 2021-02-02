using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MayorMenor
{
    class Program
    {
        public static void Comprovacion(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                Console.WriteLine(" el número mayor es: " + numero1);
                Console.ReadLine();
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine(" el número mayor es: " + numero2);
                Console.ReadLine();
            }
            else if (numero2 == numero1)
            {
                Console.WriteLine(" Los numeros son iguales !! ");
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
