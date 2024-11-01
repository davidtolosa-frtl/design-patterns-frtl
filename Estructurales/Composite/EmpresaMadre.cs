using System;

namespace Composite;

public class EmpresaMadre : Empresa
{
    protected List<Empresa> filiales = new List<Empresa>();

    public override bool agregaFilial(Empresa filial)
    {
        filiales.Add(filial);
        return true;
    }

    public override double calculaCosteMantenimiento()
    {
        double coste = 0.0;
        foreach (Empresa filial in filiales)
            coste = coste + filial.calculaCosteMantenimiento();
        return coste + nVehiculos * costeUnitarioVehiculo;
    }
}