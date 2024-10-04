using System;

namespace AbstractFactoryVehiculos;

public class AutomovilElectricidad : Automovil
{
    public AutomovilElectricidad(string modelo, string color, int potencia, double espacio) : base(modelo, color, potencia, espacio)
    {
    }
   
    public override void mostrarCaracteristicas()
    {
        Console.WriteLine(
          "Automovil electrico de modelo: " + modelo +
          " de color: " + color + " de potencia: " +
          potencia + " de espacio: " + espacio);
    }
}