using System;
using System.Text;

namespace BuilderTask
{
    class Program
    {
        /// <summary>
        /// Клиентский код
        /// </summary>
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Объект завода, который будет занииматься производством
            var carPlant = new CarPlant();

            // производство скутеров
            Conveyor builder = new ScooterConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            // производство автомобилей
            builder = new CarConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            // производство мотоциклов
            builder = new MotoConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();
        }
    }
}