using System;

namespace Strategy;

public class Navegador
{
    TiempoRutaStrategy tiempoRutaStrategy;

    public void setTiempoRutaStrategy(TiempoRutaStrategy tiempoRutaStrategy)
    {
        this.tiempoRutaStrategy = tiempoRutaStrategy;
    }

    public int calcularTiempoRuta(int distancia)
    {
        return tiempoRutaStrategy.calcularTiempoRuta(distancia);
    }
}
