using System;
using System.Collections.Generic;

namespace Ejercicio_02
{
    public abstract class Empleado
    {
        //Campos
        protected string nombre;
        protected int legajo;
        protected decimal sueldoBase;
        //Constructor
        public Empleado(string nombre, int legajo, decimal sueldoBase)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.sueldoBase = sueldoBase;
        }

        //Metodos

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Legajo: {legajo}");
            Console.WriteLine($"Sueldo: {CalcularSueldo()}");
        }

        public abstract decimal CalcularSueldo();

    }
    
    public class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(string nombre, int legajo, decimal sueldoBase)
        : base(nombre, legajo, sueldoBase)
        {
        }

        public override decimal CalcularSueldo()
        {
            return sueldoBase + (50000m / 12);
        }
    }
    

    public class EmpleadoPartTime : Empleado
    {
        private int horasTrabajadas;
        private decimal valorHora;

        public EmpleadoPartTime(string nombre, int legajo, int horas, decimal valorHora)
        : base(nombre, legajo, 0)
        {
            this.horasTrabajadas = horas;
            this.valorHora = valorHora;
        }
        public override decimal CalcularSueldo()
        {
            return horasTrabajadas * valorHora;
        }
    }

    public class EmpleadoContratado : Empleado
    {
        private DateTime fechaFinContrato;
        
        public EmpleadoContratado(string nombre, int legajo, decimal sueldoBase, DateTime fechaFin)
        : base(nombre, legajo, sueldoBase)
        {
            this.fechaFinContrato = fechaFin;
        }

        public override decimal CalcularSueldo()
        {
            return sueldoBase;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new EmpleadoTiempoCompleto("Ana", 1, 100000);
            Empleado e2 = new EmpleadoPartTime("Luis", 2, 80, 1000);
            Empleado e3 = new EmpleadoContratado("Sofia", 3, 90000, DateTime.Now.AddDays(30));

            e1.MostrarInfo();
            e2.MostrarInfo();
            e3.MostrarInfo();
        }
    }
}
