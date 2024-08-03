namespace AbstractFactory;

public class EnMemoriaProductRepositoryAbstractFactory : IProductRepositoryAbstractFactory
{
    public IProductoReader CrearProductoReader()
    {
        return new EnMemoriaProductReader();
    }

    public IProductoWriter CrearProductoWriter()
    {
       return new EnMemoriaProductoWriter();
    }
}
