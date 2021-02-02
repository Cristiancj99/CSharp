using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numero1 = 0;
            int numero2 = 0;
            int division = 0;

            Console.WriteLine("Introduzca el dividendo: ");
            numero1 = System.Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Introduzca el divisor: ");
            numero2 = System.Convert.ToInt32(System.Console.ReadLine());

            try
            {
                division = numero1 / numero2;
            }
            catch
            {
                Console.WriteLine("lo siento, ha ocurrido una excepcion, no se puede dividir entre 0!!");
                Console.ReadLine();
            }

        }
    }
}
