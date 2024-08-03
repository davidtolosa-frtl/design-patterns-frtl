namespace AbstractFactory;

public class EnMemoriaProductoWriter : IProductoWriter
{
    public Producto Save(Producto producto)
    {
        producto.Id = Guid.NewGuid();
        return producto;
    }
}
