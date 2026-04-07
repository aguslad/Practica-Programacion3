namespace Programa_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            double largoProducto = 10.85;
            Console.WriteLine("   El largo del producto es: " + largoProducto + " centimetros");

            decimal precioProducto = 8999.99m;
            Console.WriteLine("   El valor del producto es: $" + precioProducto);
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

        }
    }
}
