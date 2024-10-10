using System;

namespace AbstractFactoryEjercicio3;

public class TarjetaCreditoPlatinium : TarjetaCredito
{
	public override void MostrarDetalle()
	{
		// Implement the method here
		Console.WriteLine("Detalles de la tarjeta de crédito Platinium.");
	}
}
