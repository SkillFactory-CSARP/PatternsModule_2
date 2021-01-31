using System;

namespace PrototypeRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем точку
            ILocation location = new Point(30.245,40.954);
            // клонируем точку (получаем новую точку с теми же координатами)
            ILocation clonedLocation = location.Clone();
            
            location.GetInfo();
            clonedLocation.GetInfo();

            Console.WriteLine();
            
            // создаем место
            location = new Place("Улица Пушкина, дом Колотушкина");
            // клонируем место (получаем новое место по тому же адресу)
            // пример использования - нам надо обозначить новый магазин в том же самом торговом центре
            clonedLocation = location.Clone();
            
            location.GetInfo();
            clonedLocation.GetInfo();
        }
    }
}