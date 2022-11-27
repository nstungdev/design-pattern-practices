using System;
using System.Collections.Generic;
using System.Text;

namespace VituralProxy
{
    public class ProductLoadingService : IProductLoading
    {
        public void LoadFromFile(string path)
        {
            Console.WriteLine("Loaded successfuly from " + path);
        }
    }
}
