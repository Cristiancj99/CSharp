using System;

namespace Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero = 0;
			int factor = 1;
			Console.WriteLine("bienvenido al programa para calcular el número factorial de un número");
			Console.WriteLine("introduce el nḿero deseado: ");
			numero= System.Convert.ToInt32(System.Console.ReadLine());
			

			if (numero < 0)
			{ // si el número es negativo su factorial es 0.

				Console.WriteLine(" El número factorial de " + numero + " es 0.");
			}

			else if (numero == 0)
			{ // si el número es 0 su factorial es 1.
				Console.WriteLine(" El número factorial de " + numero + " es 1 ");
			}

			else if (numero >= 1)
			{ // proceso para calcularel factorial.

				for (int progresion = 1; progresion <= numero; progresion = progresion + 1)
				{
					factor = factor * progresion;
				}

				Console.WriteLine(" El número factorial de " + numero + " es " + factor);
			}
		}
	}
		
}
