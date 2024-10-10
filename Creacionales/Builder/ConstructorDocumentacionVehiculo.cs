using System;

namespace Builder;

public abstract class ConstructorDocumentacionVehiculo
{
    protected Documentacion documentacion;

    public abstract ConstructorDocumentacionVehiculo construyeSolicitudPedido(String
      nombreCliente);

    public abstract ConstructorDocumentacionVehiculo construyeSolicitudMatriculacion
      (String nombreSolicitante);

    public Documentacion resultado()
    {
        return documentacion;
    }
}
