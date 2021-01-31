using System;

namespace StrategyRealExample
{
    /// <summary>
    /// Реадизация электрического отопления
    /// </summary>
    class ElectricHeater : IHeater
    {
        public void Heat()
        {
            Console.WriteLine("Нагрев электричеством");
        }
    }
}