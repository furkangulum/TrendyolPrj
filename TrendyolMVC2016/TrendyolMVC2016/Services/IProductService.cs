using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolMVC2016.Models;

namespace TrendyolMVC2016.Services
{
    public interface IProductService
    {
        Product FindProduct(int? id);
        List<Product> GetAllProducts();
        List<Product> GetAllActiveProducts();
        void AddProduct(Product product);
        void EditProduct(Product product);
        void DisableProduct(Product product);
    }

}
