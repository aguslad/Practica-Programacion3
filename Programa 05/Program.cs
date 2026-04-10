namespace Programa_05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 4: VALORES LÓGICOS (SÍ / NO) ---");

        bool pagoConfirmado = true;
        bool compraRealizada = true;
        bool clienteRegistrado = false;
        bool stockActualizado = true;
        bool envioProgramado = true;

        Console.WriteLine("6. TIPO LÓGICO (bool):");
        Console.WriteLine("   Solo puede ser 'true' o 'false'.");
        Console.WriteLine("   ¿El pago fue realizado?: " + pagoConfirmado);
        Console.WriteLine("   ¿La compra se realizó con éxito?: " + compraRealizada);
        Console.WriteLine("   ¿El cliente está registrado?: " + clienteRegistrado);
        Console.WriteLine("   ¿El stock se actualizó correctamente?: " + stockActualizado);
        Console.WriteLine("   ¿El envío está programado?: " + envioProgramado);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

    }
}