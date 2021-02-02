using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacionObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaAhorro cuenta = new CuentaAhorro("gr76786","Christian", -67, "10%", 45);
            cuenta.estado();
            Console.ReadLine();

            
        }
    }
}
