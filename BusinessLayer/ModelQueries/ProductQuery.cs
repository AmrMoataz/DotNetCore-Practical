using BusinessLayer.ModelQueries.Interfaces;
using BusinessLayer.Models;
using DataLayer.Data.Models;
using DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ModelQueries
{
    public class ProductQuery : IProductQuery
    {
        private IProductRepository _productRepository;
        public ProductQuery(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public List<Product> GetAll()
        {
            List<TBProducts> tBProducts = _productRepository.GetProducts();
            List<Product> products = new List<Product>();
            foreach (var prod in tBProducts)
            {
                Product product = new Product();
                product.Name = prod.Name;
                product.Price = prod.Price;
                product.Id = prod.Id;
                product.Qty = prod.Qty;
                products.Add(product);
            }

            return products;
        }

        public Product GetOne(Guid id)
        {
            TBProducts tBProducts = _productRepository.GetProduct(id);
            Product product = new Product();
            product.Name = tBProducts.Name;
            product.Price = tBProducts.Price;
            product.Id = tBProducts.Id;
            product.Qty = tBProducts.Qty;
            return product;
        }
    }
}
