using System;

namespace TemplateBindingDemo
{
    public class DemoRunner
    {
        public const int RunCount = 1000;

        public void Run<T>(T demo, dynamic arguments) where T : IDemo
        {
            var startTime = DateTime.Now;

            for (var i = 0; i < RunCount; i++)
                demo.Run(arguments);

            var endTime = DateTime.Now;

            OutputTime(demo.GetType().Name, startTime, endTime);
            //Console.WriteLine(demo.Run(arguments));
        }

        //public void Run<T>(T demo, object arguments) where T : IDemo
        //{
        //    var startTime = DateTime.Now;

        //    //for(var i = 0; i < RunCount; i++)
        //    //    demo.Run(arguments);

        //    var endTime = DateTime.Now;

        //    OutputTime(demo.GetType().Name, startTime, endTime);
        //    Console.WriteLine(demo.Run(arguments));
        //}

        private static void OutputTime(string testName, DateTime start, DateTime end)
        {
            Console.WriteLine($"{testName} took: {(end - start).TotalMilliseconds} milliseconds to compile {RunCount} templates");
        }
    }
}
