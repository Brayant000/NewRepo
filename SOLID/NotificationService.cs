using System;

namespace SOLID_Principle
{
    interface INotifier
    {
        void Send(string recipient, string message);
    }

    class EmailNotifier : INotifier
    {
        public void Send(string email, string message)
        {
            Console.WriteLine($"Enviando Email a {email}: {message}");
        }
    }

    class SMSNotifier : INotifier
    {
        public void Send(string phoneNumber, string message)
        {
            Console.WriteLine($"Enviando SMS a {phoneNumber}: {message}");
        }
    }

    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Registrando notificación: {message}");
        }
    }

    class NotificationService
    {
        private readonly INotifier _notifier;
        private readonly Logger _logger;

        public NotificationService(INotifier notifier, Logger logger)
        {
            _notifier = notifier;
            _logger = logger;
        }

        public void Notify(string recipient, string message)
        {
            _notifier.Send(recipient, message);
            _logger.Log(message);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Seleccione el tipo de notificación:");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. SMS");
            int option = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mensaje: ");
            string message = Console.ReadLine();

            INotifier notifier;
            string recipient;

            if (option == 1)
            {
                Console.Write("Ingrese el correo electrónico: ");
                recipient = Console.ReadLine();
                notifier = new EmailNotifier();
            }
            else if (option == 2)
            {
                Console.Write("Ingrese el número de teléfono: ");
                recipient = Console.ReadLine();
                notifier = new SMSNotifier();
            }
            else
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            NotificationService service = new NotificationService(notifier, new Logger());
            service.Notify(recipient, message);
        }
    }
}
