using System.Text.Json;

namespace AbstractFactory;

public class ArchivoProductoWriter : IProductoWriter
{
    private readonly ICollection<Producto> _productos;

    public ArchivoProductoWriter(string nombreArchivo)
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

    public Producto Save(Producto producto)
    {
        producto.Id = Guid.NewGuid();
        _productos.Add(producto);

        string productosJson = JsonSerializer.Serialize(_productos);
        File.WriteAllText("productos.json", productosJson); 

        return producto;        
    }
}
