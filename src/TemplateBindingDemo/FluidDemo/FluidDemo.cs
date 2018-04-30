using System;
using System.Collections.Generic;
using Fluid;

namespace TemplateBindingDemo.FluidDemo
{
    public class FluidDemo : IDemo
    {
        public string Run(Dictionary<string, object> arguments)
        {
            throw new System.NotImplementedException();
        }

        public string Run(object arguments)
        {
            var source = TemplateManagement.Read("FluidDemo\\template.html");

            if (!FluidTemplate.TryParse(source, out var template)) throw new Exception();

            var context = new TemplateContext();
            context.MemberAccessStrategy.Register(arguments.GetType());
            context.SetValue("p", arguments);

            return template.Render(context);

        }
    }
}
