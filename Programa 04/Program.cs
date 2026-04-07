namespace Programa_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            string nombre = "Agustina";
            string apellido = "Ladines";
            Console.WriteLine("   Nombre y apellido: " + nombre + " " + apellido);

            // Carácter único (char) - Comillas simples ''
            char inicialNombre = 'A';
            char inicialApellido = 'L';
            Console.WriteLine("   Inicial nombre: '" + inicialNombre + "'");
            Console.WriteLine("   Inicial apellido: '" + inicialApellido + "'");


            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}
