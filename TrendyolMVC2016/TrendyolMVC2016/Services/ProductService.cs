using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrendyolMVC2016.Models;
using TrendyolMVC2016.Repositories;

namespace TrendyolMVC2016.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _IProductRepository;
        public ProductService(IProductRepository IProductRepository)
        {
            this._IProductRepository = IProductRepository;
        }

        public void AddProduct(Product product)
        {
            product = SetProductStatusActive(product);
            _IProductRepository.AddProduct(product);
        }
        public Product SetProductStatusActive(Product product)
        {
            product.Status = 1;
            return product;
        }
        public Product SetProductStatusDisabled(Product product)
        {
            product.Status = 0;
            return product;
        }

        public void EditProduct(Product product)
        {
            _IProductRepository.EditProduct(product);
        }

        public Product FindProduct(int? id)
        {
            return _IProductRepository.FindProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _IProductRepository.GetAllProducts();
        }

        public void DisableProduct(Product product)
        {
            product = SetProductStatusDisabled(product);
            _IProductRepository.EditProduct(product);
        }

        public List<Product> GetAllActiveProducts()
        {
            return _IProductRepository.GetAllActiveOrders();
        }
    }
}