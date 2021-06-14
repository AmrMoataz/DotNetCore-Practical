using BusinessLayer.Factories.Interfaces;
using BusinessLayer.ModelQueries.Interfaces;
using BusinessLayer.Models;
using BussinessenseCorpTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessenseCorpTest.Services
{
    public class ProductService : IProductService
    {
        private IProductFactory _productFactory;
        private IProductQuery _productQuery;

        public ProductService(IProductFactory productFactory, IProductQuery productQuery)
        {
            _productFactory = productFactory;
            _productQuery = productQuery;
        }
        public Product Create(Product product)
        {
            return _productFactory.Add(product);
        }

        public bool Delete(Guid id)
        {
           return  _productFactory.remove(id);
        }

        public List<Product> GetAll()
        {
            return _productQuery.GetAll();
        }

        public Product GetOne(Guid id)
        {
            return _productQuery.GetOne(id);
        }

        public Product Update(Guid id, Product product)
        {
            product.Id = id;
            return _productFactory.Edit(product);
        }
    }
}
