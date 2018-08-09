using System;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.dll";

            // Load a specific Assembly
            Assembly a = Assembly.LoadFile(path);
            ShowAssemblyInfo(a);

            // Get our Assembly
            Assembly ourAssembly = Assembly.GetExecutingAssembly();
            ShowAssemblyInfo(ourAssembly);

            Console.Read();
        }

        static void ShowAssemblyInfo(Assembly a)
        {
            Console.WriteLine(a.FullName);
            Console.WriteLine("From GAC? {0}", a.GlobalAssemblyCache);
            Console.WriteLine("Path: {0}", a.Location);
            Console.WriteLine("Version: {0}", a.ImageRuntimeVersion);

            // Show Modules
            foreach (Module m in a.GetModules())
            {
                Console.WriteLine(" Mod: {0}", m.Name);
            }

            Console.WriteLine();
        }
    }
}
