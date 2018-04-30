using System.Collections.Generic;

namespace TemplateBindingDemo
{
    public static class ValueManagement
    {
        public static Dictionary<string, object> ToDictionary()
        {
            return new Dictionary<string, object>
            {
                {"name", "Mr Harry Potter"},
                {"Address_Line_1", "The cupboard under the stairs" },
                {"Address_Line_2", "4 Privet Drive" },
                {"Town_City", "Little Whinging" },
                {"County", "Surrey" },
                {"Body", "Hello, your latest bill is now ready to view online." }
            };
        }

        public static object ToObject()
        {
            return new 
            {
                name = "Mr Harry Potter",
                Address_Line_1 = "The cupboard under the stairs",
                Address_Line_2 = "4 Privet Drive",
                Town_City = "Little Whinging",
                County = "Surrey",
                Body = "Hello, your latest bill is now ready to view online."
            };
        }
    }
}
