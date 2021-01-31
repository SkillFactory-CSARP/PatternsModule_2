namespace StrategyRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
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