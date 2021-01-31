using System;

namespace StrategyRealExample
{
    /// <summary>
    ///  Реализация газового отопления
    /// </summary>
    class GasHeater : IHeater
    {
        public void Heat()
        {
            Console.WriteLine("Нагрев газом");
        }
    }
}