using System;

namespace StrategyExample
{
    /// <summary>
    /// Общий интерфейс некоего алгоритма
    /// </summary>
    public interface IStrategy
    {
        void Algorithm();
    }
 
    /// <summary>
    /// Первая реализация алгоритма
    /// </summary>
    public class StrategyOne : IStrategy
    {
        public void Algorithm()
        {}
    }
 
    /// <summary>
    /// Вторая реализация алгоритма
    /// </summary>
    public class StrategyTwo : IStrategy
    {
        public void Algorithm()
        {}
    }
 
    /// <summary>
    /// Клиентский код
    /// </summary>
    public class Client
    {
        public IStrategy ClientStrategy { get; set; }
 
        public Client(IStrategy strategy)
        {
            ClientStrategy = strategy;
        }
 
        // Ds 
        public void ExecuteAlgorithm()
        {
            ClientStrategy.Algorithm();
        }
    }
}