using System;
using System.Text;

namespace PatternsModule_2
{
    /// <summary>
    /// Общий интерфейс для клонирования похожих объектов
    /// </summary>
    abstract class Prototype
    {
        protected int Id;
        
        // Метод- конструктор
        public Prototype(int id)
        {
            Id = id;
        }
        
        // Метод для клонирования самого себя
        public abstract Prototype Clone();
    }
    
    /// <summary>
    ///  Первая конкретная реализация клонированного объекта
    /// </summary>
    class ClassOne : Prototype
    {
        public ClassOne(int id) : base(id)
        { }
        
        public override Prototype Clone()
        {
            return new ClassOne(Id);
        }
    }
 
    /// <summary>
    /// Вторая конкретная реализация клонированного объекта
    /// </summary>
    class ClassTwo : Prototype
    {
        public ClassTwo(int id) : base(id)
        { }
        
        public override Prototype Clone()
        {
            return new ClassTwo(Id);
        }
    }
    
    /// <summary>
    /// Клиентский код, использующий прототип
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //  создаем первый конкретный объект по прототипу 
            Prototype prototype = new ClassOne(1);
            // Клонируем
            Prototype clone = prototype.Clone();
            
            //  создаем второй конкретный объект по прототипу 
            prototype = new ClassTwo(2);
            // Клонируем
            clone = prototype.Clone();
        }
    }
}
