namespace PrototypeRealExample
{
    /// <summary>
    /// Общий интерфейс для объектов на карте
    /// </summary>
    interface ILocation
    {
        /// Метод для клонирования
        ILocation Clone();
        
        // Метод для получения информации об объекте
        void GetInfo();
    }
}