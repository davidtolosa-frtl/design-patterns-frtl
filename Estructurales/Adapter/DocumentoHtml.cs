using System;

namespace Adapter;

public class DocumentoHtml : Documento
{
    protected String contenido;

    public void setContenido(String contenido)
    {
        this.contenido = contenido;
    }

    public void dibuja()
    {
        Console.WriteLine("Dibuja el documento HTML: " +
          contenido);
    }

    public void imprime()
    {
        Console.WriteLine("Imprime el documento HTML: " +
          contenido);
    }
}