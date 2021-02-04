namespace BuilderTask
{
    /// <summary>
    /// Абстрактный класс строителя
    /// </summary>
    abstract class Conveyor
    {
        protected Product _product;
        
        public Product Product
        {
            get { return _product; }
        }
 
        // Методы для постройкии  сочтавных частей
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}