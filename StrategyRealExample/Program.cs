using System;
using System.Text;

namespace StrategyRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Подключаем котел на газу
            var boiler = new Boiler(30, "Bosch", new GasHeater());
            // Запускаем
            boiler.Start();
            
            // газ закончился. Переключаемся на электричество
            boiler.Heater = new ElectricHeater();
            // Запускаем
            boiler.Start();
        }
    }
}