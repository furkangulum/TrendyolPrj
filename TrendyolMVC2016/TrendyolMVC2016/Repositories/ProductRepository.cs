using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrendyolMVC2016.Models;

namespace TrendyolMVC2016.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private TrendyolContext _TrendyolDB;
        public ProductRepository(TrendyolContext TrendyolContext)
        {
            this._TrendyolDB = TrendyolContext;
        }

        public void AddProduct(Product product)
        {
            _TrendyolDB.Products.Add(product);
            _TrendyolDB.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            _TrendyolDB.Entry(product).State = EntityState.Modified;
            _TrendyolDB.SaveChanges();
        }

        public Product FindProduct(int? id)
        {
            return _TrendyolDB.Products.Find(id);
        }

        public List<Product> GetAllActiveOrders()
        {
            return _TrendyolDB.Products.Where(x=>x.Status==1).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return _TrendyolDB.Products.ToList();
        }
    }
}