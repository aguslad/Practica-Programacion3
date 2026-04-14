namespace Array_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 3: USO DE .LENGTH Y BUCLE FOR ---");

            Console.WriteLine("--- ARRAY DE VERDURAS ---");

            string[] verduras = { "Lechuga", "Rucula", "Zanahoria", "Cebolla" };

            int cantidadVerduras = verduras.Length;

            Console.WriteLine("Cantidad de verduras en el Array: " + cantidadVerduras);

            for (int i = 0; i < verduras.Length; i++)
            {
                Console.WriteLine("Índice " + i + " la verdura es: " + verduras[i]);
            }

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("--- ARRAY DE ANIMALES ---");

            string[] animales = { "Perro", "Gato", "Pájaro", "Conejo" };

            int cantidadAnimales = animales.Length;

            Console.WriteLine("Cantidad de animales en el Array: " + cantidadAnimales);

            for (int i = 0; i < animales.Length; i++)
            {
                Console.WriteLine("Índice " + i + " el animal es: " + animales[i]);
            }

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("--- ARRAY DE PLANETAS ---");

            string[] planetas = { "Mercurio", "Venus", "Tierra", "Marte" };

            int cantidadPlanetas = planetas.Length;

            Console.WriteLine("Cantidad de planetas en el Array: " + cantidadPlanetas);

            for (int i = 0; i < planetas.Length; i++)
            {
                Console.WriteLine("Índice " + i + " el planeta es: " + planetas[i]);
            }

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("--- ARRAY DE MESES ---");

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril" };

            int cantidadMeses = meses.Length;

            Console.WriteLine("Cantidad de meses en el Array: " + cantidadMeses);

            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("Índice " + i + " el mes es: " + meses[i]);
            }

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("--- ARRAY DE COLORES ---");

            string[] colores = { "Rojo", "Azul", "Verde", "Amarillo" };

            int cantidadColores = colores.Length;

            Console.WriteLine("La cantidad de colores en el Array: " + cantidadColores);

            for (int i = 0; i < colores.Length; i++)
            {
                Console.WriteLine("Índice " + i + " el color es: " + colores[i]);
            }

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();


        }
    }
}