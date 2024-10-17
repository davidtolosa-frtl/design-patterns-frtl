using System;

namespace Observer;
public abstract class Sujeto
{
    protected List<Observador> observadores =
        new List<Observador>();

    public void agrega(Observador observador)
    {
        observadores.Add(observador);
    }

    public void suprime(Observador observador)
    {
        observadores.Remove(observador);
    }

    public void notifica()
    {
        foreach (Observador observador in observadores)
        {
            observador.actualiza();
        }
    }
}