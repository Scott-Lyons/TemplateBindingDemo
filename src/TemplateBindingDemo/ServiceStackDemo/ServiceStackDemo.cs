using System.Collections.Generic;
using ServiceStack.Templates;

namespace TemplateBindingDemo.ServiceStackDemo
{
    public class ServiceStackDemo : IDemo
    {
        public string Run(Dictionary<string,object> arguments)
        {
            var template = TemplateManagement.Read("ServiceStackDemo\\template.html");

            var context = new TemplateContext().Init();
            
            var dynamicPage = context.OneTimePage(template);

            var output = new PageResult(dynamicPage)
            {
                Args = arguments
            }.Result;
            
            return output;
        }

        public string Run(object arguments)
        {
            throw new System.NotImplementedException();
        }
    }
}
