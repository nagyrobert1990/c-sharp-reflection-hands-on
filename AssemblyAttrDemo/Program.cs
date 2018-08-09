using System;
using System.Reflection;

namespace AssemblyAttrDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly a = Assembly.GetExecutingAssembly();
            Type attrType = typeof(AssemblyDescriptionAttribute);
            object[] attrs = a.GetCustomAttributes(attrType, false);

            if (attrs.Length > 0)
            {
                AssemblyDescriptionAttribute desc = (AssemblyDescriptionAttribute)attrs[0];
                Console.WriteLine($"Description is: {desc.Description}");
            }
        }
    }
}
