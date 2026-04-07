namespace Programa_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- SISTEMA DE REGISTRO DE ALUMNO ---");

            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Por favor, ingresa tu apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edad = Int32.Parse(Console.ReadLine());

            Console.Write("Ingresa tu DNI: ");
            int DNI = Int32.Parse(Console.ReadLine());

            Console.Write("Ingresa tu legajo: ");
            int legajo = Int32.Parse(Console.ReadLine());

            Console.Write("Por favor, ingresa tu carrera: ");
            string carrera = Console.ReadLine();

            Console.Write("Por favor, ingresa tu email: ");
            string email = Console.ReadLine();

            Console.Write("Por favor, ingresa tu celular: ");
            string celular = Console.ReadLine();

            Console.WriteLine("\n--- ALUMNO REGISTRADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Legajo: " + legajo);
            Console.WriteLine("Carrera: " + carrera);
            Console.WriteLine("E-mail: " + email);
            Console.WriteLine("Celular: " + celular);

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
        }
    }
}