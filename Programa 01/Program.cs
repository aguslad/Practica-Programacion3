namespace Programa_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre1 = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edad1 = Int32.Parse(Console.ReadLine());

            Console.Write("Ingresa tu estatura: ");
            double estatura = double.Parse(Console.ReadLine()); 

            Console.WriteLine("\n--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre1);
            Console.WriteLine("Edad el próximo año: " + (edad1 + 1));
            Console.WriteLine("Estatura: " + estatura + " metros");

            Console.WriteLine("--- SISTEMA DE REGISTRO DE ALUMNO ---");

            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre2 = Console.ReadLine();

            Console.Write("Por favor, ingresa tu apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edad2 = Int32.Parse(Console.ReadLine());

            Console.Write("Ingresa tu DNI: ");
            int DNI = Int32.Parse(Console.ReadLine());

            Console.Write("Ingresa tu legajo: ");
            int legajo = Int32.Parse(Console.ReadLine());

            Console.Write("Por favor, ingresa tu carrera: ");
            string carrera = Console.ReadLine();

            Console.WriteLine("\n--- ALUMNO REGISTRADO ---");
            Console.WriteLine("Nombre: " + nombre2);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad2);
            Console.WriteLine("Legajo: " + legajo);
            Console.WriteLine("Carrera: " + carrera);

            Console.WriteLine("--- SISTEMA DE REGISTRO DE PRODUCTO ---");
            Console.WriteLine("Por favor, ingresa el nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese precio del producto: ");
            decimal precioProducto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el código de barras del producto: ");
            int codigoBarras = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n--- PRODUCTO REGISTRADO ---");
            Console.WriteLine("Nombre del producto: " + nombreProducto);
            Console.WriteLine("Precio del producto: $" + precioProducto);
            Console.WriteLine("Código de barras: " + codigoBarras);

            Console.WriteLine("\n--- SISTEMA DE REGISTRO DE FACTURA ---");
            Console.WriteLine("Ingrese el número de factura: ");
            int numeroFactura = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del cliente: ");
            string nombreCliente = Console.ReadLine();

            Console.WriteLine("Ingrese el monto total de la factura: ");
            decimal montoTotal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n--- FACTURA REGISTRADA ---");
            Console.WriteLine("Número de factura: " + numeroFactura);
            Console.WriteLine("Nombre del cliente: " + nombreCliente);
            Console.WriteLine("Monto total: $" + montoTotal);

            Console.WriteLine("\n--- SISTEMA DE REGISTRO DE EMPLEADO ---");
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine();
            
            Console.WriteLine("Ingrese el apellido del empleado: ");
            string apellidoEmpleado = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del empleado: ");
            int edadEmpleado = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de legajo del empleado: ");
            int legajoEmpleado = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n--- EMPLEADO REGISTRADO ---");
            Console.WriteLine("Nombre del empleado: " + nombreEmpleado);
            Console.WriteLine("Apellido del empleado: " + apellidoEmpleado);
            Console.WriteLine("Edad del empleado: " + edadEmpleado);
            Console.WriteLine("Número de legajo del empleado: " + legajoEmpleado);


            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();

        }
    }
}