using System;

namespace PrototypeTask
{
    class Program
    {
        /// <summary>
        ///  Клиентский код
        /// </summary>
        static void Main()
        {
            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();
            
            BaseClass clone = myObject.Clone();
            clone.GetId();
            
            myObject = new ImplementationTwo(2);
            myObject.GetId();
            
            clone = myObject.Clone();
            clone.GetId();
        }
    }
 
    /// <summary>
    /// Базовый класс прототип
    /// </summary>
    abstract class BaseClass
    {
        public int Id { get; }
        public BaseClass(int id)
        {
            Id = id;
        }

        //  Метод для получения свойства обзекта
        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {Id}");
        }
        
        // метод для клонирования
        public abstract BaseClass Clone();
    }
 
    /// <summary>
    /// Первая реализация прототипа
    /// </summary>
    class ImplementationOne : BaseClass
    {
        public ImplementationOne(int id) : base(id)
        { }
        
        public override BaseClass Clone()
        {
            return new ImplementationOne(Id);
        }
    }
 
    /// <summary>
    /// Первая реализация прототипа
    /// </summary>
    class ImplementationTwo : BaseClass
    {
        public ImplementationTwo(int id) : base(id)
        { }
        
        public override BaseClass Clone()
        {
            return new ImplementationTwo(Id);
        }
    }
}