namespace AbstractFactoryVehiculos;

public class AutomovilGasolina : Automovil
{
    public AutomovilGasolina(string modelo, string color, int potencia, double espacio) : base(modelo, color, potencia, espacio)
    {
    }

    public override void mostrarCaracteristicas()
    {
        Console.WriteLine(
      "Automovil de gasolina de modelo: " + modelo +
      " de color: " + color + " de potencia: " +
      potencia + " de espacio: " + espacio);
    }
}