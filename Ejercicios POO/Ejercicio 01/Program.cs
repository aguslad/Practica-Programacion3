using System;
using System.Collections.Generic;

namespace Ejercicio_01
{
    public enum TipoCuenta
    {
        Ahorro,
        Corriente
    }

    public class CuentaBancaria
    {
        // Campos privados
        private decimal _saldo;
        private readonly List<string> _historial;
        private readonly TipoCuenta _tipo;

        // Propiedades públicas (solo lectura)
        public decimal Saldo => _saldo;
        public TipoCuenta Tipo => _tipo;
        public IReadOnlyList<string> Historial => _historial.AsReadOnly();

        // Constructor
        public CuentaBancaria(TipoCuenta tipo, decimal saldoInicial = 0)
        {
            if (saldoInicial < 0)
                throw new ArgumentException("El saldo inicial no puede ser negativo.");

            _tipo = tipo;
            _saldo = saldoInicial;
            _historial = new List<string>();

            Registrar("Cuenta creada con saldo inicial: " + saldoInicial);
        }

        // Depositar dinero
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero.");

            _saldo += monto;
            Registrar("Depósito: +" + monto + " | Saldo: " + _saldo);
        }

        // Retirar dinero
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero.");

            if (monto > _saldo)
                throw new InvalidOperationException("Saldo insuficiente.");

            _saldo -= monto;
            Registrar("Retiro: -" + monto + " | Saldo: " + _saldo);
        }

        // Aplicar interés
        public void AplicarInteresMensual()
        {
            decimal interes = 0;

            if (_tipo == TipoCuenta.Ahorro)
                interes = _saldo * 0.03m;

            _saldo += interes;
            Registrar("Interés: +" + interes + " | Saldo: " + _saldo);
        }

        // Método privado para registrar movimientos
        private void Registrar(string mensaje)
        {
            _historial.Add(DateTime.Now + ": " + mensaje);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una cuenta
            CuentaBancaria cuenta = new CuentaBancaria(TipoCuenta.Ahorro, 1000);

            // Operaciones
            cuenta.Depositar(500);
            cuenta.Retirar(200);
            cuenta.AplicarInteresMensual();

            // Mostrar saldo
            Console.WriteLine("Saldo actual: " + cuenta.Saldo);

            // Mostrar historial
            Console.WriteLine("\nHistorial:");
            foreach (var item in cuenta.Historial)
            {
                Console.WriteLine(item);
            }
        }
    }
}