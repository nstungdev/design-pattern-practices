using System;
using System.Collections.Generic;
using System.Text;

namespace VituralProxy
{
    public class ProductLoadingProxy : IProductLoading
    {
        ProductLoadingService _loadingService;
        public void LoadFromFile(string path)
        {
            if (_loadingService == null)
            {
                _loadingService = new ProductLoadingService();
                Console.WriteLine("A new instance is created");
            }
            _loadingService.LoadFromFile(path);
        }
    }
}
