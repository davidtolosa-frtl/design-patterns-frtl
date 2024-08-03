namespace AbstractFactory;

public interface IProductoReader
{
    Producto GetPorId(Guid id);
}
