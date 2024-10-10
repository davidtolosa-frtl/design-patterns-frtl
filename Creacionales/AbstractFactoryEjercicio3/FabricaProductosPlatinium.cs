using System;

namespace AbstractFactoryEjercicio3;

public class FabricaProductosPlatinium : FabricaProductosBancarios
{
	public CajaAhorro CrearCajaAhorro()
	{
		// Implement the method logic here
		return new CajaAhorroPlatinium();
	}

	public TarjetaDebito CrearTarjetaDebito()
	{
		// Implement the method logic here
		return new TarjetaDebitoPlatinium();
	}

	public TarjetaCredito CrearTarjetaCredito()
	{
		// Implement the method logic here
		return new TarjetaCreditoPlatinium();
	}
}