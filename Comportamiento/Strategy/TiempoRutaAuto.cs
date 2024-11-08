using System;

namespace Strategy;

public class TiempoRutaAuto : TiempoRutaStrategy
{
    public int calcularTiempoRuta(int distancia)
    {
        return distancia * 1;
    }
}
