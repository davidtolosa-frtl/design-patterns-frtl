using System;

namespace Builder;

public class ConstructorDocumentacionVehiculoPdf : ConstructorDocumentacionVehiculo
{
    public override ConstructorDocumentacionVehiculo construyeSolicitudMatriculacion(string nombreCliente)
    {
        string documento = $"<PDF>Solicitud de matriculación Cliente: {nombreCliente}</PDF>";
        documentacion.agregaDocumento(documento);

        return this;
    }

    public override ConstructorDocumentacionVehiculo construyeSolicitudPedido(string nombreCliente)
    {
        string documento = $"<PDF>Solicitud de pedido Cliente: {nombreCliente}</PDF>";
        documentacion.agregaDocumento(documento);

        return this;
    }
}
