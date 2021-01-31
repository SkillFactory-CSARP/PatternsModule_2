using System;

namespace PrototypeRealExample
{
    /// <summary>
    /// Известное мето на карте
    /// </summary>
    class Place : ILocation
    {
        string Address;
        
        public Place(string address)
        {
            Address = address;
        }
 
        // Метод для клонирования
        public ILocation Clone()
        {
            return new Place(Address);
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"Новый объект по адресу {Address}. ");
        }
    }
}