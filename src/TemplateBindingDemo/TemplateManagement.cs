using System.IO;

namespace TemplateBindingDemo
{
    public static class TemplateManagement
    {
        public static string Read(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            using (var file = new StreamReader(stream))
            {
                return file.ReadToEnd();
            }
        }
    }
}
