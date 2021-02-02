using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmética_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            Console.WriteLine("Los números son: "+ a + " y " +b + "\nSu suma es: " + (a+b) +" \nLa resta es: " + (a - b) + "\nLa multiplicación es: "+ (a*b)+ "\nEl módulo es: " + (a%b));
            Console.ReadLine();
        }
    }
}
