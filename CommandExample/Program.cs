using System;
using System.Text;
using System.Threading.Channels;

namespace CommandExample
{
    
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
    
    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class CommandOne : Command
    {
        Receiver receiver;
        
        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }
        
        // Выполнить
        public override void Run()
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
        }
 
        // Отменить
        public override void Cancel()
        {}
    }
 
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        public void Operation()
        {
            Console.WriteLine("Процесс запущен");
        }
    }
    
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        Command _command;
        
        public void SetCommand(Command command)
        {
            _command = command;
        }
        
        // Выполнить
        public void Run()
        {
            _command.Run();
        }
        
        // Отменить
        public void Cancel()
        {
            _command.Cancel();
        }
    }
    
    
    /// <summary>
    /// Клиентский код
    /// </summary>
    class Program
    {  
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // создадим отправителя 
            var sender = new Sender();
            
            // создадим получателя 
            var receiver = new Receiver();
            
            // создадим команду 
            var commandOne = new CommandOne(receiver);
                
            // инициализация команды
            sender.SetCommand(commandOne);
            
            //  выполнение
            sender.Run();
        }
    }
}