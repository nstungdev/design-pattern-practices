using System;

namespace VituralProxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // context: The gaming store will load many files to show data in the web, so I have a solution
            //          is only want to see data then we load data from file.
            Console.WriteLine("Hello World!");

            var proxy = new ProductLoadingProxy();
            ShowData(proxy, "D:\\Data\\Laptops\\data.csv");

            ShowData(proxy, "D:\\Data\\Laptops\\nana.csv");
            ShowData(proxy, "D:\\Data\\Laptops\\bundle.csv");
            Console.ReadKey();
        }

        static void ShowData(IProductLoading productLoading, string path)
        {
            productLoading.LoadFromFile(path);
        }
    }
}
