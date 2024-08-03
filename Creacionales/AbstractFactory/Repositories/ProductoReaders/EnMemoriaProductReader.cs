
namespace AbstractFactory;

public class EnMemoriaProductReader : IProductoReader
{
    public Producto GetPorId(Guid id)
    {
        return new Producto
        {
            Id = id,
            Nombre = "Monitor",
            Precio = 30000
        };
    }
}
