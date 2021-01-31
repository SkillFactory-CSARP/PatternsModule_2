using System;

namespace CommandTask
{
    /// <summary>
    ///  Клиентский код
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            Gate gate = new Gate();
            
            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();
        }
    }
 
    /// <summary>
    /// Общий интерфейс команд
    /// </summary>
    interface IAction
    {
        void Run();
        void Undo();
    }
 
    /// <summary>
    /// Получатель команд
    /// </summary>
    class Gate
    { 
        public void Open()
        {
            Console.WriteLine("Открываем ворота");
        }
 
        public void Close()
        {
            Console.WriteLine("Закрываем ворота");
        }
    }
 
    /// <summary>
    /// Команда открытия ворот
    /// </summary>
    class GateOpenAction : IAction
    {
        Gate _gate;
        public GateOpenAction(Gate gateSet)
        {
            _gate = gateSet;
        }
        public void Run()
        {
            _gate.Open();
        }
        public void Undo()
        {
            _gate.Close();
        }
    }
 
    /// <summary>
    /// Отправитель команд
    /// </summary>
    class Pult
    {
        IAction _action;
 
        /// <summary>
        ///  Инициализация команды
        /// </summary>
        public void SetAction(IAction action)
        {
            _action = action;
        }
 
        public void OpenButton()
        {
            // запуск команды
            _action.Run();
        }
        
        public void CloseButton()
        {
            // отмена команды
            _action.Undo();
        }
    }
}