namespace BuilderTask
{
    /// <summary>
    ///  Конвейер мотоциклов
    /// </summary>
    class MotoConveyor : Conveyor
    {
        public MotoConveyor()
        {
            _product = new Product("Мотоцикл");
        }
 
        public override void BuildFrame()
        {
            _product["frame"] = "Рама мотоцикла";
        }
 
        public override void BuildEngine()
        {
            _product["engine"] = "70 л.с.";
        }
 
        public override void BuildWheels()
        {
            _product["wheels"] = "2";
        }
 
        public override void BuildDoors()
        {
            _product["doors"] = "0";
        }
    }
}