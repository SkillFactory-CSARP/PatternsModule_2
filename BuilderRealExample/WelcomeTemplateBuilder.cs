namespace BuilderRealExample
{
    /// <summary>
    /// Строитель для создания приветственной рассылки
    /// </summary>
    class WelcomeTemplateBuilder : TemplateBuilder
    {
        public override void BuildHeader()
        {
            Template.Header = new Header { Text = "Здравствуйте!" };
        }
 
        public override void BuildBody()
        {
            Template.Body = new Body { Text  =  "Спасибо за регистрацию а нашем приложении" };
        }
 
        public override void BuildFooter()
        {
            // не используется
        }
    }
}