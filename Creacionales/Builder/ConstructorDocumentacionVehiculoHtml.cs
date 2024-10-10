using System;

namespace Builder;

public class ConstructorDocumentacionVehiculoHtml : ConstructorDocumentacionVehiculo
{
    public ConstructorDocumentacionVehiculoHtml()
    {
        documentacion = new DocumentacionHtml();
    }

    public override ConstructorDocumentacionVehiculo construyeSolicitudMatriculacion(string nombreCliente)
    {
         String documento;   
        documento =  "<HTML>Solicitud de matriculacion Solicitante: " +   
        nombreCliente + "</HTML>";   
        documentacion.agregaDocumento(documento);

        return this;
    }

    public override ConstructorDocumentacionVehiculo construyeSolicitudPedido(string nombreCliente)
    {
        String documento;
        documento = "<HTML>Solicitud de pedido Cliente: " +
          nombreCliente + "</HTML>";
        documentacion.agregaDocumento(documento);

        return this;
    }
}
