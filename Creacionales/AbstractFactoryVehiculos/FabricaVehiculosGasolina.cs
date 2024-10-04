namespace AbstractFactoryVehiculos;
public class FabricaVehiculosGasolina : FabricaVehiculos
{
    public Automovil CrearAutomovil(string modelo, string color, int potencia, double espacio)
    {
        return new AutomovilGasolina(modelo, color, potencia, espacio);
    }

    public Moto CrearMoto(string marca, int cilindrada)
    {
        return new MotoGasolina(marca, cilindrada);
    }
}
