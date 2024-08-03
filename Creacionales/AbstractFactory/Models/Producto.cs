using System.Globalization;

namespace AbstractFactory;

public class Producto
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public override string ToString(){
        return $"{Id} | {Nombre, -20} | {Precio.ToString("C", new CultureInfo("es-AR"))}";
    }
}
