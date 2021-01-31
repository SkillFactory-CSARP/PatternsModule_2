using System;

namespace BuilderRealExample
{
    /// <summary>
    /// Клиентский код 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // содаем движок шаблонизатора
            TemplateEngine templateEngine = new TemplateEngine();
            
            // создаем шаблонизатор для приветственной рассылки
            TemplateBuilder builder = new WelcomeTemplateBuilder();
            // генерируем  приветственное письо с текстом
            Template greetingsTemplate = templateEngine.GenerateTemplate(builder);
            Console.WriteLine(greetingsTemplate.ToString());
            
            
            // переопределяем шаблонизатор для рассылки с номером заказа
            builder = new OrderTemplateBuilder();
            // генерируем  письмо  с номером заказа
            Template orderTemplate = templateEngine.GenerateTemplate(builder);
            Console.WriteLine(orderTemplate.ToString());
        }
    }
}