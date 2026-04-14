namespace Array_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 1: FUNDAMENTOS DE ARREGLOS ---");

            Console.WriteLine("--- ARRAY NÚMEROS PARES ---");

            int[] numerosPares = new int [3];

            numerosPares[0] = 2;
            numerosPares [1] = 4;
            numerosPares[2] = 6;

            Console.WriteLine("El índice 0 en el Array de números pares es: " + numerosPares[0]);
            Console.WriteLine("El índice 1 en el Array de números pares es: " + numerosPares[1]);
            Console.WriteLine("El índice 2 en el Array de números pares es: " + numerosPares[2]);

            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine("--- ARRAY NÚMEROS IMPARES ---");

            int[] numerosImpares = new int[3];

            numerosImpares[0] = 1;
            numerosImpares[1] = 3;
            numerosImpares[2] = 5;

            Console.WriteLine("El índice 0 en el Array de números impares es: " + numerosImpares[0]);
            Console.WriteLine("El índice 1 en el Array de números impares es: " + numerosImpares[1]);
            Console.WriteLine("El índice 2 en el Array de números impares es: " + numerosImpares[2]);

            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine("--- ARRAY NÚMEROS IGUALES ---");

            int[] numerosIguales = new int[3];

            numerosIguales[0] = 7;
            numerosIguales[1] = 7;
            numerosIguales[2] = 7;

            Console.WriteLine("El índice 0 en el Array de números iguales es: " + numerosIguales[0]);
            Console.WriteLine("El índice 1 en el Array de números iguales es: " + numerosIguales[1]);
            Console.WriteLine("El índice 2 en el Array de números iguales es: " + numerosIguales[2]);

            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine("--- ARRAY NÚMEROS ALEATORIOS ---");

            int[] numerosAleatorios = new int[3];

            numerosAleatorios[0] = 8;
            numerosAleatorios[1] = 2;
            numerosAleatorios[2] = 5;

            Console.WriteLine("El índice 0 en el Array de números aleatorios es: " + numerosAleatorios[0]);
            Console.WriteLine("El índice 1 en el Array de números aleatorios es: " + numerosAleatorios[1]);
            Console.WriteLine("El índice 2 en el Array de números aleatorios es: " + numerosAleatorios[2]);

            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine("--- ARRAY NÚMERO CAPICÚA ---");

            int[] numeroCapicua = new int[3];

            numeroCapicua[0] = 2;
            numeroCapicua[1] = 8;
            numeroCapicua[2] = 2;

            Console.WriteLine("El índice 0 en el Array de número capicúa es: " + numeroCapicua[0]);
            Console.WriteLine("El índice 1 en el Array de número capicúa es: " + numeroCapicua[1]);
            Console.WriteLine("El índice 2 en el Array de número capicúa es: " + numeroCapicua[2]);


            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();

        }
    }
}