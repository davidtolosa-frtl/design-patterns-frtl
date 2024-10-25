using System;

namespace Decorator;

public class LogoDecorador : Decorador
{
    public LogoDecorador(ComponenteGraficoVehiculo componente)
        : base(componente)
    {
    }

    protected void visualizaLogo()
    {
        Console.WriteLine("Logo del vehículo");
    }

    public override void visualiza()
    {
        base.visualiza();
        this.visualizaLogo();
    }
}
