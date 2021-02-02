using System;

public class cuentaBancaria
{
	private String numCuenta;
	private String nombre;
	private int saldo;
	private String tipoInteres;

	public cuentaBancaria()
	{
	}

    public string NumCuenta { get => numCuenta; set => numCuenta = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Saldo { get => saldo; set => saldo = value; }
    public string TipoInteres { get => tipoInteres; set => tipoInteres = value; }

	public void estado()
    {
		Console.WriteLine("Numero de cuenta: " + this.NumCuenta + " Nombre: " + this.Nombre + " Saldo" + this.Saldo + " Tipo de interes: " + this.TipoInteres);
    }
}
