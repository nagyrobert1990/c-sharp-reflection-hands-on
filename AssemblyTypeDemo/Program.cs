using System;
using System.Reflection;

namespace AssemblyTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.ServiceProcess.dll";

            // Using BindingFlags to only get declared and instance members
            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

            // Load the Assembly from the path
            Assembly theAssembly = Assembly.LoadFrom(path);
            Console.WriteLine(theAssembly.FullName);
            Type[] types = theAssembly.GetTypes();

            foreach (Type t in types)
            {
                Console.WriteLine($" Type: {t.Name}");
                MemberInfo[] members = t.GetMembers(flags);

                foreach (MemberInfo member in members)
                {
                    Console.WriteLine($" {member.MemberType}: {member.Name}");
                }
            }

            Console.Read();
        }
    }
}
