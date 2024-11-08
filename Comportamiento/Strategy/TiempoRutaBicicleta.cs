using System;

namespace Strategy;

public class TiempoRutaBicicleta : TiempoRutaStrategy
{
    public int calcularTiempoRuta(int distancia)
    {
       return distancia * 2;
    }
}
