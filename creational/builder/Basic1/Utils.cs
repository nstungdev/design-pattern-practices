using System;
using System.Collections.Generic;
using System.Text;

namespace Basic1
{
    public static class Utils
    {
        public static void PrintGamingInfo(this object src)
        {
            var sourceType = src.GetType();
            var props = sourceType.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            Console.WriteLine("------------------------------------");
            foreach (var p in props)
            {
                Console.WriteLine($"{p.Name}: {p.GetValue(src)}");
            }
        }
    }
}
