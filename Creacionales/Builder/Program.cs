using Builder;

Vendedor vendedor = new Vendedor(new ConstructorDocumentacionVehiculoHtml());   
Documentacion documentacion = vendedor.Construye("Martin");
documentacion.imprime();
