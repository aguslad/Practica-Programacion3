namespace Programa_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            double largoProducto = 10.85;
            double anchoProducto = 5.50;
            double altoProducto = 2.25;
            double pesoProducto = 0.75;
            double volumenProducto = largoProducto * anchoProducto * altoProducto;
            Console.WriteLine("   El largo del producto es: " + largoProducto + " centimetros");
            Console.WriteLine("   El ancho del producto es: " + anchoProducto + " centimetros");
            Console.WriteLine("   El alto del producto es: " + altoProducto + " centimetros");
            Console.WriteLine("   El peso del producto es: " + pesoProducto + " gramos");
            Console.WriteLine("   El volumen del producto es: " + Math.Round(volumenProducto,2));

            decimal precioProducto = 80000m;
            decimal descuentoProducto = 0.15m;
            decimal precioConDescuento = precioProducto * descuentoProducto;
            decimal precioFinal = precioConDescuento;
            decimal ivaProducto = precioFinal * 0.21m;
            Console.WriteLine("   El valor del producto es: $" + precioProducto);
            Console.WriteLine("   El descuento aplicado es: " + (descuentoProducto * 100) + "%");
            Console.WriteLine("   El precio con descuento es: $" + Math.Round(precioConDescuento,2));
            Console.WriteLine("   El precio final del producto es: $" + Math.Round(precioFinal,2));
            Console.WriteLine("   El precio final con IVA es: $" + Math.Round((precioFinal + ivaProducto),2));
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

        }
    }
}
