namespace Ejercicio_logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[20];
            int[] edades = new int[20];
            int contadorMayores = 0;

            Console.WriteLine("------- ENTRADA AL BOLICHE -------");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la persona {i + 1}:");
                nombres[i] = Console.ReadLine();
                Console.WriteLine($"Ingrese la edad de {nombres[i]}:");
                edades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n------- LISTA DE PERSONAS -------");

            for(int i = 0; i < 20; i++)
            {
                if (edades[i] > 20)
                {
                    Console.WriteLine(nombres[i] + " puede entrar al boliche");
                    contadorMayores++;
       
                }
                else
                {
                    Console.WriteLine(nombres[i] + " no puede pasar al boliche, debe regresar a su casa");
                    
                }
            }
            Console.WriteLine("\nNúmero total de personas que pueden entrar al boliche: " + contadorMayores);

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();

        }
    }
}
