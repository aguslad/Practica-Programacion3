namespace Programa_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 1: NÚMEROS ENTEROS ---");

            int numProducto = 55455;
            int cantidad = 100;
            int stockMinimo = 50;
            int stockMaximo = 200;
            int codigoBarras = 123456789;

            Console.WriteLine("El número de producto es: " + numProducto);
            Console.WriteLine("La cantidad disponible es: " + cantidad);
            Console.WriteLine("El stock mínimo es: " + stockMinimo);
            Console.WriteLine("El stock máximo es: " + stockMaximo);
            Console.WriteLine("El código de barras es: " + codigoBarras);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}