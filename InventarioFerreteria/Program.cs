using InventarioFerreteria;

var productos = new List<Producto>();
int siguienteId = 1;

CrearProducto("Martillo de uña", 450.00m, 15);
CrearProducto("Destornillador estrella", 180.00m, 30);

Console.WriteLine($"Total de productos registrados: {productos.Count}");
ListarProductos();

ActualizarProducto(1, "Martillo de uña reforzado", 495.00m, 20);
ListarProductos();

void CrearProducto(string nombre, decimal precio, int stock)
{
    var nuevo = new Producto
    {
        Id = siguienteId++,
        Nombre = nombre,
        Precio = precio,
        Stock = stock
    };
    productos.Add(nuevo);
    Console.WriteLine($"[CREADO] ID: {nuevo.Id} | {nuevo.Nombre} | RD${nuevo.Precio} | Stock: {nuevo.Stock}");
}

void ListarProductos()
{
    Console.WriteLine("\n--- LISTA DE PRODUCTOS ---");

    if (productos.Count == 0)
    {
        Console.WriteLine("No hay productos registrados.");
        return;
    }

    foreach (var p in productos)
    {
        Console.WriteLine($"ID: {p.Id} | {p.Nombre} | RD${p.Precio} | Stock: {p.Stock}");
    }
}

void ActualizarProducto(int id, string nuevoNombre, decimal nuevoPrecio, int nuevoStock)
{
    Producto? encontrado = null;

    foreach (var p in productos)
    {
        if (p.Id == id)
        {
            encontrado = p;
            break;
        }
    }

    if (encontrado is null)
    {
        Console.WriteLine($"\n[AVISO] No se encontró un producto con ID {id}.");
        return;
    }

    encontrado.Nombre = nuevoNombre;
    encontrado.Precio = nuevoPrecio;
    encontrado.Stock = nuevoStock;

    Console.WriteLine($"\n[ACTUALIZADO] ID: {encontrado.Id} | {encontrado.Nombre} | RD${encontrado.Precio} | Stock: {encontrado.Stock}");
}