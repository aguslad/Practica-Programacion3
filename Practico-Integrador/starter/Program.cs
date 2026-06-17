using System;
using starter.Datos;

namespace starter
{
    class Program
    {
        static void Main(string[] args)
        {
            string? opcion = null;

            if (args.Length > 0)
            {
                opcion = args[0].ToLower();
            }
            else
            {
                Console.WriteLine("Seleccione el motor:");
                Console.WriteLine("1 - PostgreSQL");
                Console.WriteLine("2 - SQL Server");
                Console.WriteLine("3 - MySQL");
                Console.Write("Opción: ");
                opcion = Console.ReadLine()?.ToLower();
            }

            Motor motor;

            switch (opcion)
            {
                case "1":
                case "postgres":
                case "postgresql":
                    motor = Motor.PostgreSql;
                    break;
                case "2":
                case "sqlserver":
                case "mssql":
                    motor = Motor.SqlServer;
                    break;
                case "3":
                case "mysql":
                    motor = Motor.MySql;
                    break;
                default:
                    Console.WriteLine($"Opción '{opcion}' no válida.");
                    return;
                    break;
            }

            Console.WriteLine($"\nMotor elegido: {motor}");

            IAccesoDatos accesoDatos = FabricaDeMotor.Crear(motor);

            accesoDatos.CrearEstructura();
            accesoDatos.InsertarDatosPrueba();
            accesoDatos.EjecutarOperaciones();
            accesoDatos.DemostrarRollback();
        }
    }
}