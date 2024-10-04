namespace AbstractFactoryVehiculos;

public interface FabricaVehiculos
{
    Automovil CrearAutomovil(String modelo, String color, int potencia, double espacio);

    Moto CrearMoto(string marca, int cilindrada);
}
