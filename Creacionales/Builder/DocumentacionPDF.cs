using System;

namespace Builder;

public class DocumentacionPDF : Documentacion
{
	public override void agregaDocumento(string documento)
	{
		 if (documento.StartsWith("<PDF>"))
            contenido.Add(documento);
	}

    public override void imprime()
    {
        Console.WriteLine("Documentación PDF");
        foreach (string s in contenido)
        {
            Console.WriteLine(s);
        }
    }

}
