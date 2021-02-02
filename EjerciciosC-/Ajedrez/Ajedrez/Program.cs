using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el numero en horizontal (x)");
            int eje_x = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Introduce el numero en vertical (y)");
            int eje_y = System.Convert.ToInt32(System.Console.ReadLine());
            int auxiliar = 0;

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if ((Math.Abs(eje_x - x)) == (Math.Abs(eje_y - y)))
                    {
                        Console.Write(" * ");

                    }
                     else  if (y % 2 == 0)
                    {
                        if (x % 2 == 0)
                        {
                            Console.Write(" B ");
                        }
                        else
                        {
                            Console.Write(" N ");
                        }
                    }

                    else if (y%2 !=0)
                    {
                        if (x % 2 == 0)
                        {
                            Console.Write(" N ");
                        }
                        else
                        {
                            Console.Write(" B ");
                        }
                    }


                }
                Console.WriteLine();
                    
            }
            Console.ReadLine();
        }
    }
}
