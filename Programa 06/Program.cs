namespace Programa_06;

class Program
{
    static void Main(string[] args)
    {
        const string NOMBRE_APP = "CineControl";
        const string VERSION = "v2.1.0";
        const int EDAD_MINIMA = 13;
        const string CIUDAD = "Tucumán";
        const string FORMATO_SALA = "3D";

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando políticas de acceso...");
        Console.WriteLine("Restricción: Película apta para mayores de " + EDAD_MINIMA + " años.");
        Console.WriteLine("Ubicación: " + CIUDAD);
        Console.WriteLine("Formato de sala: " + FORMATO_SALA);

        const int EDAD_ESPECTADOR = 15;
        const bool PUEDE_VER_PELICULA = EDAD_ESPECTADOR >= EDAD_MINIMA;

        Console.WriteLine("\nVerificando espectador de " + EDAD_ESPECTADOR + " años...");
        Console.WriteLine("Edad mínima requerida: " + EDAD_MINIMA);
        Console.WriteLine("¿Puede ver la película?: " + PUEDE_VER_PELICULA);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);

        Console.ReadLine();

    }
}