namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
        Console.WriteLine("--- SISTEMA FACTURACIÓN ---");
        const decimal TASA_IVA = 0.21m;
        const bool MODO_PRUEBA = false; 
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 1500.50m;
        decimal impuestoCalculado = precioBase * TASA_IVA;
        decimal total = precioBase + impuestoCalculado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);


        Console.WriteLine("--- SISTEMA CINECONTROL ---");
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


        Console.WriteLine("--- SISTEMA TIENDA DE ROPA ---");

        const decimal DESCUENTO_ROPA = 0.15m;
        const bool PROMO_ROPA = true;
        const char MONEDA_ROPA = '$';

        Console.WriteLine("--- Detalle de compra ---");

        decimal precioRemera = 5000m;
        decimal descRemera = PROMO_ROPA ? precioRemera * DESCUENTO_ROPA : 0;
        decimal totalRemera = precioRemera - descRemera;

        Console.WriteLine("Precio: " + MONEDA_ROPA + precioRemera);
        Console.WriteLine("Descuento: " + MONEDA_ROPA + descRemera);
        Console.WriteLine("Total: " + MONEDA_ROPA + totalRemera);


        Console.WriteLine("--- TIENDA CELULARES ---");

        const decimal IVA_CELULAR = 0.21m;
        const bool GARANTIA_ACTIVA = true;
        const char MONEDA_CEL = '$';

        Console.WriteLine("--- Detalle de compra ---");

        decimal precioCelular = 120000m;
        decimal impuestoCel = precioCelular * IVA_CELULAR;
        decimal totalCelular = precioCelular + impuestoCel;

        Console.WriteLine("Precio base: " + MONEDA_CEL + precioCelular);
        Console.WriteLine("IVA: " + MONEDA_CEL + impuestoCel);
        Console.WriteLine("Total: " + MONEDA_CEL + totalCelular);
        Console.ReadLine();


        Console.WriteLine("--- CÁLCULO DE PERÍMETRO ---");

        const char UNIDAD = 'm';
        const int FACTOR_PERIMETRO = 2;

        Console.WriteLine("--- OPERACIONES ---");
        decimal baseRectangulo = 5.5m;
        decimal alturaRectangulo = 3.2m;

        decimal perimetroRectangulo = FACTOR_PERIMETRO * (baseRectangulo + alturaRectangulo);

        Console.WriteLine("\nDatos de la figura:");
        Console.WriteLine("Base: " + baseRectangulo + " " + UNIDAD);
        Console.WriteLine("Altura: " + alturaRectangulo + " " + UNIDAD);

        Console.WriteLine("\nResultado:");
        Console.WriteLine("Perímetro: " + perimetroRectangulo + " " + UNIDAD);


    }
}
