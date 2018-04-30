using System;
using System.Collections.Generic;
using RazorLight;

namespace TemplateBindingDemo.RazorLightDemo
{
    public class RazorLightDemo : IDemo
    {
        private readonly RazorLightEngine _razorLightEngine;
        private readonly string _template;
        
        public string Run(Dictionary<string, object> arguments)
        {
            throw new NotImplementedException();
        }

        public RazorLightDemo()
        {
            _razorLightEngine = new RazorLightEngineBuilder()
                .UseMemoryCachingProvider()
                .Build();

            _template = TemplateManagement.Read("RazorLightDemo\\template.html");
        }

        public string Run(dynamic arguments)
        {
            var output = _razorLightEngine.CompileRenderAsync("key", _template, arguments).Result;
            return output;
        }
    }
}
