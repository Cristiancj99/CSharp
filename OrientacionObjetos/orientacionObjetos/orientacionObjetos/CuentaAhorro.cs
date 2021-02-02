using System;

namespace orientacionObjetos
{
    internal class CuentaAhorro : CuentaBancaria
    {
		private int cuotaMantenimiento;

		public int CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }

		public CuentaAhorro(String numeroCuenta, String nombre, int saldo, String porcentaje, int mantenimiento)
		{
			this.NumCuenta = numeroCuenta;
			this.Nombre = nombre;
			this.Saldo = saldo;
			this.TipoInteres = porcentaje;
			this.CuotaMantenimiento = mantenimiento;
		}


		public void estado()
		{
            base.estado();
			Console.WriteLine("cuota de mantenimiento " + this.CuotaMantenimiento);
		}
	}
}