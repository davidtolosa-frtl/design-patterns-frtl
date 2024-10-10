using System;

namespace AbstractFactoryEjercicio3;

public class FabricaProductosClassic : FabricaProductosBancarios
{
	public CajaAhorro CrearCajaAhorro()
	{
		// Implement the method logic here
		return new CajaAhorroClassic();
	}

	public TarjetaDebito CrearTarjetaDebito()
	{
		// Implement the method logic here
		return new TarjetaDebitoClassic();
	}

	public TarjetaCredito CrearTarjetaCredito()
	{
		// Implement the method logic here
		return new TarjetaCreditoClassic();
	}
}
