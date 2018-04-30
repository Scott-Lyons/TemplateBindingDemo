using System.Collections.Generic;

namespace TemplateBindingDemo
{
    public interface IDemo
    {
        string Run(Dictionary<string, object> arguments);
        string Run(object arguments);
    }
}
