using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivino
{
    class Program
    {
        static void Comprobacion( int numero_adivinanza, int numero_usuario, int i)
        {
            if (numero_adivinanza > numero_usuario)
            {
                Console.WriteLine("El numero es mayor. Sigue probando!!");

            }
            else if (numero_usuario > numero_adivinanza)
            {
                Console.WriteLine("El numero es menor. Sigue probando!!");
                


            }
            else if (numero_adivinanza == numero_usuario)
            {
                Console.WriteLine("ENHORABUENAAAA!! has acertado el numero.");
                Console.ReadLine();


            }
            else if (i == 5)
            {
                Console.WriteLine("Lo siento, has agotado los intentos...");
                Console.ReadLine();


            }

        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numero_adivinanza = rnd.Next(0, 20);
            int numero_usuario = 0;
            for(int i=0; ( (i < 5) && (numero_usuario != numero_adivinanza) ); i++)
            {
                Console.WriteLine("Introduzca un número para intentar ganar la adivinanza!!");
                numero_usuario = System.Convert.ToInt32(System.Console.ReadLine());
                Comprobacion(numero_adivinanza, numero_usuario, i);
               
            }
        }

    }
}
