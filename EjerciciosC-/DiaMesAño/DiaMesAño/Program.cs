using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaMesAño
{
    class Program
    {
        public static void ComprobacionMesAnio(int mes, int year)
        {
            if ((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12)) 
            {
                Console.WriteLine("el mes " + mes + " del año " + year + "tiene 31 dias");
            }
            else if ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))
            {
                Console.WriteLine("el mes " + mes + " del año " + year + "tiene 30 dias");

            }
            else if (mes == 2)
            {
                if ( ( (year%4==0) && (year%100 !=0)) ||  (year %400==0))
                {
                    Console.WriteLine("el mes " + mes + " del año " + year + "tiene 29 dias");

                }
                else
                {
                    Console.WriteLine("el mes " + mes + " del año " + year + " tiene 28 dias");

                }

            }
        }
        static void Main(string[] args)
        {
            int mes=0;
            int years = 0;
            Console.WriteLine("Bienvenido al programa DiaMesAño");
            Console.WriteLine("Por favor, introduzca el mes ( en numero)");
            mes = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Ahora, introduzca el año: ");
            years = System.Convert.ToInt32(System.Console.ReadLine());

            ComprobacionMesAnio(mes, years);
            Console.ReadLine();



        }
    }
}
