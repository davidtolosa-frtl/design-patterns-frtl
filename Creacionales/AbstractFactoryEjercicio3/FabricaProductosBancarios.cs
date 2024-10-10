using System;

namespace AbstractFactoryEjercicio3;

public interface FabricaProductosBancarios
{
    CajaAhorro CrearCajaAhorro();
    TarjetaDebito CrearTarjetaDebito();
    TarjetaCredito CrearTarjetaCredito();
}
