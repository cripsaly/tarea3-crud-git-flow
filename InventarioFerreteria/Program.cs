using InventarioFerreteria;

var productos = new List<Producto>();
int siguienteId = 1;

CrearProducto("Martillo de uña", 450.00m, 15);
CrearProducto("Destornillador estrella", 180.00m, 30);

Console.WriteLine($"Total de productos registrados: {productos.Count}");

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