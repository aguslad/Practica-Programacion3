using System;
using System.Collections.Generic;

namespace Ejercicio_03
{
    // Interfaz
    public interface INotificador
    {
        void Enviar(string destinatario, string mensaje);
        int MensajesEnviados { get; }
    }

    public abstract class NotificadorBase : INotificador
    {
        protected int mensajesEnviados = 0;

        public int MensajesEnviados => mensajesEnviados;

        public void Enviar(string destinatario, string mensaje)
        {
            EnviarMensaje(destinatario, mensaje);
            mensajesEnviados++;
        }

        protected abstract void EnviarMensaje(string destinatario, string mensaje);

    }
    // Email
    public class NotificadorEmail : NotificadorBase
    {
        protected override void EnviarMensaje(string destinatario, string mensaje)
        {
            Console.WriteLine($"Email a {destinatario}: {mensaje}");
        }
    }

    // SMS
    public class NotificadorSMS : NotificadorBase
    {
        protected override void EnviarMensaje(string destinatario, string mensaje)
        {
            Console.WriteLine($"SMS a {destinatario}: {mensaje}");
        }
    }

    // Push
    public class NotificadorPush : NotificadorBase
    {
        protected override void EnviarMensaje(string destinatario, string mensaje)
        {
            Console.WriteLine($"Push a {destinatario}: {mensaje}");
        }
    }

    // Gestor
    public class GestorNotificaciones
    {
        private List<INotificador> notificadores;

        public GestorNotificaciones()
        {
            notificadores = new List<INotificador>();
        }

        public void AgregarNotificador(INotificador notificador)
        {
            notificadores.Add(notificador);
        }

        public void NotificarATodos(string destinatario, string mensaje)
        {
            foreach (var n in notificadores)
            {
                n.Enviar(destinatario, mensaje);
            }
        }

        public void MostrarReporte()
        {
            Console.WriteLine("\n Reporte de mensajes enviados:");

            foreach (var n in notificadores)
            {
                Console.WriteLine($"{n.GetType().Name}: {n.MensajesEnviados}");
            }
        }
    }

    // Main
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorNotificaciones gestor = new GestorNotificaciones();

            gestor.AgregarNotificador(new NotificadorEmail());
            gestor.AgregarNotificador(new NotificadorSMS());
            gestor.AgregarNotificador(new NotificadorPush());

            gestor.NotificarATodos("Agustina", "Hola! Este es un mensaje de prueba.");

            gestor.MostrarReporte();
        }
    }
}