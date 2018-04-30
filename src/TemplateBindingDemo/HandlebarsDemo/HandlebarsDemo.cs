using System.Collections.Generic;
using HandlebarsDotNet;

namespace TemplateBindingDemo.HandlebarsDemo
{
    public class HandlebarsDemo : IDemo
    {
        public string Run(Dictionary<string, object> arguments)
        {
            var template = TemplateManagement.Read("HandlebarsDemo\\template.html");

            var compiledTemplate = Handlebars.Compile(template);
            
            return compiledTemplate(arguments);
        }

        public string Run(object arguments)
        {
            throw new System.NotImplementedException();
        }
    }
}
