namespace BuilderRealExample
{
    /// <summary>
    /// Движок шаблонизатора
    /// </summary>
    class TemplateEngine
    {
        /// <summary>
        /// Метод поэтапной генерации шаблона рассылки
        /// </summary>
        public Template GenerateTemplate(TemplateBuilder templateBuilder)
        {
            templateBuilder.CreateTemplate();
            
            templateBuilder.BuildHeader();
            templateBuilder.BuildBody();
            templateBuilder.BuildFooter();
            
            return templateBuilder.Template;
        }
    }
}