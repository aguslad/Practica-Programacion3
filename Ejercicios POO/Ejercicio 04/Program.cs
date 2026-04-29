using System;
using System.Collections.Generic;

namespace Ejercicio_04
{
    public abstract class Producto
    {
        // Campos
        public int codigo;
        public string nombre;
        public decimal precio;
        public int stock;

        // Constructor
        public Producto(int codigo, string nombre, decimal precio, int stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        // Método abstracto para obtener la descripción del producto
        public abstract string ObtenerDescripcion();
    }

    public class ProductoElectronico : Producto
    {
        public int garantiaMeses;

        // Constructor
        public ProductoElectronico(int codigo, string nombre, decimal precio, int stock, int garantiaMeses)
        : base(codigo, nombre, precio, stock)
        {
            this.garantiaMeses = garantiaMeses;
        }

        public override string ObtenerDescripcion()
        {
            return $"Producto: {nombre} (Código: {codigo})\n" +
                   $"Precio: ${precio}\n" +
                   $"Stock: {stock} unidades\n" +
                   $"Garantía: {garantiaMeses} meses";
        }
    }

    public class ProductoAlimento : Producto
    {
        public DateTime fechaVencimiento;

        public ProductoAlimento(int codigo, string nombre, decimal precio, int stock, DateTime fechaVencimiento)
        : base(codigo, nombre, precio, stock)
        {
            this.fechaVencimiento = fechaVencimiento;
        }

        public override string ObtenerDescripcion()
        {
           return $"Producto: {nombre} (Código: {codigo})\n" +
           $"Precio: ${precio}\n" +
           $"Stock: {stock} unidades\n" +
           $"Fecha de Vencimiento: {fechaVencimiento.ToShortDateString()}";
        }
    }

    public class ProductoRopa : Producto 
    {
        public string talla;
        public string color;

        public ProductoRopa(int codigo, string nombre, decimal precio, int stock, string talla, string color)
        : base(codigo, nombre, precio, stock)
        {
            this.talla = talla;
            this.color = color;
        }

        public override string ObtenerDescripcion()
        {
           return $"Producto: {nombre} (Código: {codigo})\n" +
           $"Precio: ${precio}\n" +
           $"Stock: {stock} unidades\n" +
           $"Talla: {talla}\n" +
           $"Color: {color}";
        }

    }

    public class Inventario<T> where T : Producto
    {
        private List<T> productos;
        public Inventario()
        {
            productos = new List<T>();
        }

        // Metodos
        public void Agregar(T producto)
        {
            foreach (var p in productos)
            {
                if (p.codigo == producto.codigo)
                {
                    Console.WriteLine("Producto duplicado");
                    return;
                }
            }
            productos.Add(producto);
        }

        public void BuscarPorNombre(string nombre)
        {
            foreach(var p in productos)
            {
                if (p.nombre.ToLower().Contains(nombre.ToLower()))
                {
                    Console.WriteLine(p.ObtenerDescripcion());
                }
            }
            
        }
        public void FiltrarPorStockMinimo(int stockMinimo)
        {
            foreach (var p in productos)
            {
                if (p.stock >= stockMinimo)
                {
                    Console.WriteLine(p.ObtenerDescripcion());
                }
            }
        }

        public decimal CalcularValorTotal()
        {
            decimal total = 0;

            foreach (var p in productos)
            {
                total += p.precio * p.stock;
            }

            return total;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear inventario (puede guardar cualquier tipo de Producto)
            Inventario<Producto> inventario = new Inventario<Producto>();

            // Crear productos

            ProductoElectronico p1 = new ProductoElectronico(1, "Celular", 200000, 5, 12);

            ProductoAlimento p2 = new ProductoAlimento(2, "Leche", 1500, 20, DateTime.Now.AddDays(10));

            ProductoRopa p3 = new ProductoRopa(3, "Remera", 8000, 10, "M", "Negro");

            // Agregar al inventario
            inventario.Agregar(p1);
            inventario.Agregar(p2);
            inventario.Agregar(p3);

            // Buscar por nombre
            Console.WriteLine("Buscar 'le':");
            inventario.BuscarPorNombre("le");

            // Filtrar por stock mínimo
            Console.WriteLine("\nStock mayor o igual a 10:");
            inventario.FiltrarPorStockMinimo(10);

            // Calcular valor total
            decimal total = inventario.CalcularValorTotal();
            Console.WriteLine($"\nValor total del inventario: ${total}");
        }
    }
}
