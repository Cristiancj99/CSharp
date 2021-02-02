using System;

namespace Ejercicio_multiplos_Arturo
{
    class Program
    {
        static void Main(string[] args)
        {
			int x1 = 5, x2 = 36; // variables para asignar el parámetro
			int numero = 0; // variable que se le asignará al numero introdcido por el usuario
			double division = 0.0; // variable para ir haciendo la división y poder comprobar.
			int progresion = 0; // variable itinerante.
								  // Entradas
			Console.WriteLine(" introduzca el numero para calcular sus múltiplos: ");

			numero = System.Convert.ToInt32(System.Console.ReadLine());


			for (progresion = x1; progresion <= x2; progresion++)
			{ // bucle para que vaya comprobando cada número del intervalo

				division = progresion % numero;

				if (division == 0)
				{

					Console.WriteLine(progresion + " Es múltiplo de: " + numero);

				}

			}
			Console.ReadLine();
		}
	}
}

