using System;

namespace AbstractFactoryEjercicio3;

public class TarjetaDebitoPlatinium : TarjetaDebito
{
	public override void MostrarDetalle()
	{
		// Implement the method logic here
		Console.WriteLine("Detalles de la Tarjeta Debito Platinium");
	}
}
