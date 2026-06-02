using System;
using System.Collections.Generic;

namespace Ejercicio_06
{
    public abstract class Tablero
    {
        protected int[,] matriz;

        public abstract int ObtenerValor(int fila, int columna);
    }

    public class TableroSecuencial : Tablero
    {
        public TableroSecuencial()
        {
            matriz = new int[5, 5];
            int valor = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = valor++;
                }
            }
        }

        public override int ObtenerValor(int fila, int columna)
        {
            return matriz[fila, columna];
        }
    }

    public class TableroPersonalizado : Tablero
    {
        public TableroPersonalizado(int[,] valores)
        {
            matriz = valores;
        }

        public override int ObtenerValor(int fila, int columna)
        {
            return matriz[fila, columna];
        }

    }
    public class Caballo
    {
        protected int fila;
        protected int columna;

        public Caballo(int fila, int columna)
        {
            this.fila = fila;
            this.columna = columna;
        }

        public List<(int fila, int columna)> ObtenerMovimientosValidos()
        {
            var movimientos = new List<(int, int)>();

            int[,] posibles = new int[,]
            {
                { 1, 2 }, { 1, -2 },
                { -1, 2 }, { -1, -2 },
                { 2, 1 }, { 2, -1 },
                { -2, 1 }, { -2, -1 }
            };

            for (int i = 0; i < 8; i++)
            {
                int nuevaFila = fila + posibles[i, 0];
                int nuevaColumna = columna + posibles[i, 1];

                // validar límites del tablero 5x5
                if (nuevaFila >= 0 && nuevaFila < 5 &&
                    nuevaColumna >= 0 && nuevaColumna < 5)
                {
                    movimientos.Add((nuevaFila, nuevaColumna));
                }
            }

            return movimientos;
        }
    }

    public interface IFiltroDeSerie
    {
        bool Cumple(List<int> serie);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
