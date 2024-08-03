namespace AbstractFactory;

public class ProductoService
{
    private readonly IProductRepositoryAbstractFactory _productoRepositoryAbstractFactory;
    private readonly IProductoReader _productoReader;
    private readonly IProductoWriter _productoWriter;

    public ProductoService(IProductRepositoryAbstractFactory productRepositoryAbstractFactory)
    {
        _productoRepositoryAbstractFactory = productRepositoryAbstractFactory;
        _productoReader = _productoRepositoryAbstractFactory.CrearProductoReader();
        _productoWriter = _productoRepositoryAbstractFactory.CrearProductoWriter();
    }

    public Producto GetPorId(Guid id){
        return _productoReader.GetPorId(id);
    }

    public Producto Save(Producto producto)
    {
        return _productoWriter.Save(producto);
    }
}
