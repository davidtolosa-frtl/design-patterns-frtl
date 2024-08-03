namespace AbstractFactory;

public class ArchivoProductoRepositoryAbstractFactory : IProductRepositoryAbstractFactory
{
    private readonly string _nombreArchivo;

    public ArchivoProductoRepositoryAbstractFactory(string nombreArchivo)
    {
        _nombreArchivo = nombreArchivo;
    }
    public IProductoReader CrearProductoReader()
    {
        return new ArchivoProductoReader(_nombreArchivo);
    }

    public IProductoWriter CrearProductoWriter()
    {
        return new ArchivoProductoWriter(_nombreArchivo);
    }
}
