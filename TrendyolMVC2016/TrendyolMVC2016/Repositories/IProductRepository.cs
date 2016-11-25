using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolMVC2016.Models;

namespace TrendyolMVC2016.Repositories
{
    public interface IProductRepository
    {
        Product FindProduct(int? id);
        List<Product> GetAllProducts();
        List<Product> GetAllActiveOrders();
        void AddProduct(Product product);
        void EditProduct(Product product);
    }
}
