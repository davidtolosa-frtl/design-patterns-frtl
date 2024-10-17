namespace Adapter;

public class DocumentoPdf : Documento
{
     protected ComponentePDF herramientaPdf = new ComponentePDF();   
   
  public void setContenido(String contenido)   
  {   
     herramientaPdf.pdfFijaContenido(contenido);   
  }   
   
  public void dibuja()   
  {   
    herramientaPdf.pdfPreparaVisualizacion();   
    herramientaPdf.pdfRefresca();   
    herramientaPdf.pdfFinalizaVisualizacion();   
  }   
   
  public void imprime()   
  {   
    herramientaPdf.pdfEnviaImpresora();   
  }   
}
