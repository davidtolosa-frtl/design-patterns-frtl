using AbstractFactory;

string NOMBRE_ARCHIVO = "productos.json";

IProductRepositoryAbstractFactory productRepository = new ArchivoProductoRepositoryAbstractFactory(NOMBRE_ARCHIVO);
//IProductRepositoryAbstractFactory productRepository = new EnMemoriaProductRepositoryAbstractFactory();
ProductoService service = new ProductoService(productRepository);

//Leer producto
try
{
    Producto producto = service.GetPorId(new Guid("ae9139e2-78bb-4319-9354-69caa35ef877"));
    Console.WriteLine(producto);
}
catch (Exception)
{
    Console.WriteLine("El Producto no existe");
}

//Guardar producto
try
{
    Producto productoGuardado = service.Save(new Producto()
    {
        Nombre = "Notebook",
        Precio = 500000
    });

    Console.WriteLine(productoGuardado);
}
catch (Exception)
{
    Console.WriteLine("Error al guardar el Producto");
}