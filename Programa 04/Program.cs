namespace Programa_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            string nombre = "Agustina";
            string segundoNombre = "Oriana";
            string apellido = "Ladines";
            string carrera = "Programación";
            string universidad = "Universidad Tecnológica Nacional - Facultad Regional Tucumán";

            Console.WriteLine("   Nombre: " + nombre);
            Console.WriteLine("   Segundo nombre: " + segundoNombre);
            Console.WriteLine("   Apellido: " + apellido);
            Console.WriteLine("   Carrera: " + carrera);
            Console.WriteLine("   Universidad: " + universidad);

            char inicialNombre = 'A';
            char inicialSegundoNombre = 'O';
            char inicialApellido = 'L';
            char inicialCarrera = 'P';
            char inicialUniversidad = 'U';
            Console.WriteLine("   Inicial nombre: '" + inicialNombre + "'");
            Console.WriteLine("   Inicial segundo nombre: '" + inicialSegundoNombre + "'");
            Console.WriteLine("   Inicial apellido: '" + inicialApellido + "'");
            Console.WriteLine("   Inicial carrera: '" + inicialCarrera + "'");
            Console.WriteLine("   Inicial universidad: '" + inicialUniversidad + "'");


            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}
