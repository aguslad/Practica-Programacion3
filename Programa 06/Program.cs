namespace Programa_06;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
        Console.WriteLine("--- SISTEMA GAME MASTER PRO ---");
        const string NOMBRE_APP_GAME = "GameMaster Pro";
        const string VERSION_GAME = "v1.0.2";
        const int EDAD_MINIMAG = 18;

        Console.WriteLine("=== " + NOMBRE_APP_GAME + " (" + VERSION_GAME + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMAG + " años.");

        const int EDAD_CLIENTE = 20;
        const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMAG;

        Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
        Console.WriteLine("Edad mínima: " + EDAD_MINIMAG);
        Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP_GAME);
        Console.WriteLine("Constante VERSION = " + VERSION_GAME);

        Console.WriteLine("--- SISTEMA CINECONTROL ---");
        const string NOMBRE_APP_CINE = "CineControl";
        const string VERSION_CINE = "v2.1.0";
        const int EDAD_MINIMAC = 13;
        const string CIUDAD = "Tucumán";
        const string FORMATO_SALA = "3D";

        Console.WriteLine("=== " + NOMBRE_APP_CINE + " (" + VERSION_CINE + ") ===");
        Console.WriteLine("Cargando políticas de acceso...");
        Console.WriteLine("Restricción: Película apta para mayores de " + EDAD_MINIMAC + " años.");
        Console.WriteLine("Ubicación: " + CIUDAD);
        Console.WriteLine("Formato de sala: " + FORMATO_SALA);

        const int EDAD_ESPECTADOR = 15;
        const bool PUEDE_VER_PELICULA = EDAD_ESPECTADOR >= EDAD_MINIMAC;

        Console.WriteLine("\nVerificando espectador de " + EDAD_ESPECTADOR + " años...");
        Console.WriteLine("Edad mínima requerida: " + EDAD_MINIMAC);
        Console.WriteLine("¿Puede ver la película?: " + PUEDE_VER_PELICULA);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP_CINE);
        Console.WriteLine("Constante VERSION = " + VERSION_CINE);

        Console.WriteLine("--- SISTEMA BANCO SEGURO ---");

        const string NOMBRE_APP_BANCO = "Banco Seguro";
        const string VERSION_BANCO = "v2.8";
        const double SALDO_MINIMO = 1000;

        Console.WriteLine("=== " + NOMBRE_APP_BANCO + " (" + VERSION_BANCO + ") ===");
        Console.WriteLine("Verificando cuentas...");
        Console.WriteLine("Saldo mínimo requerido: $" + SALDO_MINIMO);

        const double SALDO_CLIENTE = 800;
        const bool CUENTA_ACTIVA = SALDO_CLIENTE >= SALDO_MINIMO;

        Console.WriteLine("\nVerificando cliente con saldo $" + SALDO_CLIENTE + "...");
        Console.WriteLine("Saldo mínimo: $" + SALDO_MINIMO);
        Console.WriteLine("¿Cuenta activa?: " + CUENTA_ACTIVA);

        Console.WriteLine("Constante BANCO = " + NOMBRE_APP_BANCO);
        Console.WriteLine("Constante VERSION = " + VERSION_BANCO);

        Console.ReadLine();

        Console.WriteLine("--- SISTEMA GYMPASS ---");

        const string NOMBRE_APP_GYM = "GymPass";
        const string VERSION_GYM = "v3.0";
        const int EDAD_MINIMA = 15;

        Console.WriteLine("=== " + NOMBRE_APP_GYM + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando rutinas...");
        Console.WriteLine("Edad mínima recomendada: " + EDAD_MINIMA + " años.");

        const int EDAD_USUARIO = 18;
        const bool PUEDE_ENTRENAR = EDAD_USUARIO >= EDAD_MINIMA;

        Console.WriteLine("\nVerificando usuario de " + EDAD_USUARIO + " años...");
        Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
        Console.WriteLine("Acceso permitido: " + PUEDE_ENTRENAR);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP_GYM);
        Console.WriteLine("Constante VERSION = " + VERSION_GYM);

        Console.WriteLine("--- SISTEMA MINECRAFT ---");

        const string NOMBRE_JUEGO = "Minecraft";
        const string VERSION = "v1.20";
        const int EDAD_MINIMA = 10;

        Console.WriteLine("=== " + NOMBRE_JUEGO + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando mundo...");
        Console.WriteLine("Edad recomendada: " + EDAD_MINIMA + " años.");

        const int EDAD_JUGADOR = 12;
        const bool PUEDE_JUGAR = EDAD_JUGADOR >= EDAD_MINIMA;

        Console.WriteLine("\nVerificando jugador de " + EDAD_JUGADOR + " años...");
        Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
        Console.WriteLine("¿Puede jugar?: " + PUEDE_JUGAR);

        const int DIAMANTES = 5;
        const int COSTO_ESPADA = 3;
        const bool PUEDE_CRAFTEAR = DIAMANTES >= COSTO_ESPADA;

        Console.WriteLine("\nDiamantes del jugador: " + DIAMANTES);
        Console.WriteLine("Costo de espada: " + COSTO_ESPADA);
        Console.WriteLine("¿Puede craftear espada?: " + PUEDE_CRAFTEAR);

        Console.WriteLine("Constante NOMBRE_JUEGO = " + NOMBRE_JUEGO);
        Console.WriteLine("Constante VERSION = " + VERSION);

    }
}