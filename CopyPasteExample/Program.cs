using System;

namespace CopyPasteExample
{
    public class Program
    {
        public static void Main()
        {
         
        }

        public void SetType<T>(Car car)
        {
           
        }

        public void SetAudiType(Car car)
        {
            car.Type = CarType.Audi;
        }
        
        public void SetBMwType(Car car)
        {
            car.Type = CarType.Audi;
        }
    }

    public class Car
    {
        public CarType Type { get; set; }
    }
    
    public enum CarType
    {
        BMW,
        Audi
    }
}
