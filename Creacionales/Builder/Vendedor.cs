using System;

namespace Builder;

public class Vendedor
{
    private ConstructorDocumentacionVehiculo _constructor;

    public Vendedor(ConstructorDocumentacionVehiculo constructor)
    {
        _constructor = constructor;
    }

    public Documentacion Construye(string nombreCliente)
    {
        _constructor.construyeSolicitudPedido(nombreCliente);
        _constructor.construyeSolicitudMatriculacion(nombreCliente);
        return _constructor.resultado();
    }
}
