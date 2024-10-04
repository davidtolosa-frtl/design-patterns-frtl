namespace AbstractFactoryVehiculos;

public class FabricaVehiculosElectricidad : FabricaVehiculos
{
    public Automovil CrearAutomovil(string modelo, string color, int potencia, double espacio)
    {
        return new AutomovilElectricidad(modelo, color,potencia, espacio);
    }

    public Moto CrearMoto(string marca, int cilindrada)
    {
        return new MotoElectricidad(marca, cilindrada);
    }
}
