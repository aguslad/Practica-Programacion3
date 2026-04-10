namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        const string NOMBRE_CINE = "CineControl";
        const string NOMBRE_PELICULA = "Super Mario Galaxy: La Película";
        const string TIPO_FUNCION = "3D";

        const decimal TASA_IVA = 0.21m;
        const bool MODO_PRUEBA = false;
        const decimal precioBase = 11000m;
        const char SIMBOLO_PESO = '$';
        const decimal DESCUENTO_ESTUDIANTE = 0.15m;

        const int NUMERO_FACTURA = 1001;
        const string NOMBRE_CLIENTE = "Lautaro Lorca";
        const string HORARIO_FUNCION = "20:30";
        const int SALA = 5;

        decimal descuento = precioBase * DESCUENTO_ESTUDIANTE;
        decimal precioConDescuento = precioBase - descuento;
        decimal impuestoCalculado = precioConDescuento * TASA_IVA;
        decimal total = precioConDescuento + impuestoCalculado;

        Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        Console.WriteLine("Cine: " + NOMBRE_CINE);
        Console.WriteLine("Película: " + NOMBRE_PELICULA);
        Console.WriteLine("Tipo de función: " + TIPO_FUNCION);
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Número de factura: " + NUMERO_FACTURA);
        Console.WriteLine("Cliente: " + NOMBRE_CLIENTE);
        Console.WriteLine("Horario de función: " + HORARIO_FUNCION);
        Console.WriteLine("Sala: " + SALA);
        Console.WriteLine("Precio entrada + IVA: " + SIMBOLO_PESO + Math.Round((precioBase + impuestoCalculado),2));
        Console.WriteLine("Descuento aplicado: " + SIMBOLO_PESO + Math.Round(descuento,2));
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + Math.Round(total,2));
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + Math.Round(impuestoCalculado,2));
     
        Console.ReadLine();

    }
}
