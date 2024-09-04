using RepasoObjetosPract;

var suelto = new Suelto();
var pack = new Pack();

suelto.Precio = 100;
suelto.Medida = 5;

pack.Precio = 1000;
pack.Cantidad = 2;


Producto[] listProducto = { suelto, pack };

float total = 0;
foreach (var x in listProducto)
{
    total += x.CalcularPrecio();
    Console.WriteLine(x.CalcularPrecio());
}

Console.WriteLine("TOTAL:  "+total);    
