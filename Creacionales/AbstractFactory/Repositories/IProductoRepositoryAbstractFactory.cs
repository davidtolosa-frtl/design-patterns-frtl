namespace AbstractFactory;

public interface IProductRepositoryAbstractFactory
{
    IProductoReader CrearProductoReader();
    IProductoWriter CrearProductoWriter();
}
