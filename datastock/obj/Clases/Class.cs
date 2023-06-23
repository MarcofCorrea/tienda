
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public int CantidadStock { get; set; }

}

//instancia 

Producto miProducto1 = new Producto();
Producto miProducto2 = new Producto();
Producto miProducto3 = new Producto();
Producto miProducto4 = new Producto();

//variables de productos

miProducto1.Nombre = "Abertura";
miProducto1.Precio = 10;
miProducto1.CantidadStock = 5;

miProducto2.Nombre = "Ventana";
miProducto2.Precio = 15;
miProducto2.CantidadStock = 10;

miProducto3.Nombre = "Marco";
miProducto3.Precio = 15;
miProducto3.CantidadStock = 10;

//acceso

Console.WriteLine("Nombre:" + miProducto1.Nombre);
Console.WriteLine("Precio:" + miProducto1.Precio);
Console.WriteLine("Cantidad en stock" + miProducto1.CantidadStock);










