namespace Array_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 2: INICIALIZACIÓN DIRECTA Y FOREACH ---");

            Console.WriteLine("--- ARRAY DE VERDURAS ---");

            string[] verduras = { "Lechuga", "Rucula", "Zanahoria", "Cebolla" };

            Console.WriteLine("Lista de verduras usando un bucle foreach: ");

            foreach (string verdura in verduras)
            {
                Console.WriteLine("- " + verdura);
            }

            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine("--- ARRAY DE ANIMALES ---");

            string[] animales = { "Perro", "Gato", "Pájaro", "Conejo" };

            Console.WriteLine("Lista de animales usando un bucle foreach: ");

            foreach (string animal in animales)
            {
                Console.WriteLine("- " + animal);
            }

            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine("--- ARRAY DE PLANETAS ---");

            string[] planetas = { "Mercurio", "Venus", "Tierra", "Marte" };

            Console.WriteLine("Lista de planetas usando un bucle foreach: ");

            foreach (string planeta in planetas)
            {
                Console.WriteLine("- " + planeta);
            }

            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine("--- ARRAY DE MESES ---");

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril" };

            Console.WriteLine("Lista de meses usando un bucle foreach: ");

            foreach (string mes in meses)
            {
                Console.WriteLine("- " + mes);
            }

            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine("--- ARRAY DE COLORES ---");

            string[] colores = { "Rojo", "Azul", "Verde", "Amarillo" };

            Console.WriteLine("Lista de colores usando un bucle foreach: ");

            foreach (string color in colores)
            {
                Console.WriteLine("- " + color);
            }


            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();

        }
    }

}
