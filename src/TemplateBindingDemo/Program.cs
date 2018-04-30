using System;
using System.Collections.Generic;

namespace TemplateBindingDemo
{
    internal class Program
    {
        static void Main()
        {


            var demoRunner = new DemoRunner();
            demoRunner.Run(new ServiceStackDemo.ServiceStackDemo(), ValueManagement.ToDictionary());
            demoRunner.Run(new HandlebarsDemo.HandlebarsDemo(), ValueManagement.ToDictionary());
            demoRunner.Run(new RazorLightDemo.RazorLightDemo(), ValueManagement.ToObject());
            demoRunner.Run(new FluidDemo.FluidDemo(), ValueManagement.ToObject());

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
