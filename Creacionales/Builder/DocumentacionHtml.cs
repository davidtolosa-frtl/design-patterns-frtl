using System;

namespace Builder;

public class DocumentacionHtml : Documentacion
{
    public override void agregaDocumento(string documento)
    {
        if (documento.StartsWith("<HTML>"))
            contenido.Add(documento);
    }

    public override void imprime()
    {
        Console.WriteLine("Documentacion HTML");
        foreach (var documento in contenido)
        {
            Console.WriteLine(documento);
        }
    }
}
