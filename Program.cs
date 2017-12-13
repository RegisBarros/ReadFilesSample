using System;
using System.IO;

namespace ReadFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(directory, "Myfiles/template.html");

            string template = File.ReadAllText(filePath);

            Console.WriteLine(template);
        }
    }
}
