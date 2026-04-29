using System;
using System.Collections.Generic;

namespace Ejercicio_05
{
    public class Competidor
    {
        // Campos
        public string nombre;
        public int puntaje;
        public int tiempoResolucion; // en segundos
        public int penalizaciones;

        // Constructor
        public Competidor(string nombre, int puntaje, int tiempoResolucion, int penalizaciones)
        {
            this.nombre = nombre;
            this.puntaje = puntaje;
            this.tiempoResolucion = tiempoResolucion;
            this.penalizaciones = penalizaciones;
        }

        // Metodo CompararCon
        public int CompararCon(Competidor otro)
        {
            if (this.puntaje != otro.puntaje)
                return otro.puntaje - this.puntaje; // mayor puntaje primero

            if (this.tiempoResolucion != otro.tiempoResolucion)
                return this.tiempoResolucion - otro.tiempoResolucion; // menor tiempo primero

            return this.penalizaciones - otro.penalizaciones; // menos penalizaciones mejor
        }
    }

    public interface IAlgoritmoOrdenacion
    {
        void Ordenar(List<Competidor> lista);

    }

    public class BubbleSort : IAlgoritmoOrdenacion
    {
        public int Comparaciones { get; private set; } = 0;

        public void Ordenar(List<Competidor> lista)
        {
            int n = lista.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Comparaciones++;

                    if (lista[j].CompararCon(lista[j + 1]) > 0)
                    {
                        // intercambio
                        var temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }
    }

    public class SelectionSort : IAlgoritmoOrdenacion
    {
        public int Comparaciones { get; private set; } = 0;
        public void Ordenar(List<Competidor> lista)
        {
            int n = lista.Count;

            for (int i = 0; i < n; i++)
            {
                var mejor = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (lista[j].CompararCon(lista[mejor]) < 0)
                    {
                        mejor = j;
                    }
                }
                var temp = lista[i];
                lista[i] = lista[mejor];
                lista[mejor] = temp;
            }    
        }
    }
    public class InsertionSort : IAlgoritmoOrdenacion
    {
        public int Comparaciones { get; private set; } = 0;
        public void Ordenar(List<Competidor> lista)
        {
            int n = lista.Count;

            for (int i = 1; i < n; i++)
            {
                for (int j = i ; j > 0; j--)
                {
                    if (lista[j].CompararCon(lista[j - 1]) < 0)
                    {
                        var temp = lista[j];
                        lista[j] = lista[j - 1];
                        lista[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }

    public class Clasificador
    {
        private IAlgoritmoOrdenacion algoritmo;

        public Clasificador(IAlgoritmoOrdenacion algoritmo)
        {
            this.algoritmo = algoritmo;
        }

        public void Clasificar(List<Competidor> lista)
        {
            algoritmo.Ordenar(lista);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista original
            List<Competidor> original = new List<Competidor>
                {
                    new Competidor("Ana", 100, 300, 2),
                    new Competidor("Luis", 120, 280, 1),
                    new Competidor("Pedro", 100, 250, 3),
                    new Competidor("Maria", 120, 290, 0)

                };
        

                // Copias de la lista (para no modificar la original)
                List<Competidor> lista1 = new List<Competidor>(original);
                List<Competidor> lista2 = new List<Competidor>(original);
                List<Competidor> lista3 = new List<Competidor>(original);

                // Crear clasificadores con distintos algoritmos
                Clasificador c1 = new Clasificador(new BubbleSort());
                Clasificador c2 = new Clasificador(new SelectionSort());
                Clasificador c3 = new Clasificador(new InsertionSort());

                // Ordenar
                c1.Clasificar(lista1);
                c2.Clasificar(lista2);
                c3.Clasificar(lista3);

                // Mostrar resultados
                Console.WriteLine("\n=== Bubble Sort ===");
                Mostrar(lista1);

                Console.WriteLine("\n=== Selection Sort ===");
                Mostrar(lista2);

                Console.WriteLine("\n=== Insertion Sort ===");
                Mostrar(lista3);
         
        }

        static void Mostrar(List<Competidor> lista)
        {
            foreach (var c in lista)
            {
                Console.WriteLine($"{c.nombre} | Puntaje: {c.puntaje} | Tiempo: {c.tiempoResolucion} | Penalizaciones: {c.penalizaciones}");
            }
        }

    }
}
