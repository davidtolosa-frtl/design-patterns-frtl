using System;

namespace Builder;

  
public abstract class Documentacion   
{   
    protected List<String> contenido = new List<string>();   
   
    public abstract void agregaDocumento(String documento);   
    public abstract void imprime();   
}