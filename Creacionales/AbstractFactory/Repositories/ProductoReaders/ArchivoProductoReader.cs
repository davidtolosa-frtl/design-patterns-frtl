
using System.Text.Json;

namespace AbstractFactory;

public class ArchivoProductoReader : IProductoReader
{
    private readonly ICollection<Producto> _productos;
    public ArchivoProductoReader(string nombreArchivo)
    {
        try
        {
            string productosJson = File.ReadAllText(nombreArchivo);
            _productos = JsonSerializer.Deserialize<ICollection<Producto>>(productosJson);  
        }
        catch (FileNotFoundException)
        {
            _productos = new List<Producto>();
        }
    }

    public Producto GetPorId(Guid id)
    {
        Producto producto = _productos.FirstOrDefault(p => p.Id == id);

        if(producto == null){
            throw new Exception("El producto no existe");
        }

        return producto;
    }
}
