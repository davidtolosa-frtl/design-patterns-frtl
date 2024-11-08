using System;

namespace Strategy;

public class TiempoRutaCaminata : TiempoRutaStrategy
{
    public int calcularTiempoRuta(int distancia)
    {
        return distancia * 10;
    }
}