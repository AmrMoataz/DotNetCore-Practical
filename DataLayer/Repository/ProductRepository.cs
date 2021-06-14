using DataLayer.Data.DBContext;
using DataLayer.Data.Models;
using DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class ProductRepository : IProductRepository
    {

        private DBMainContext _dbMainContext;
        public ProductRepository(DBMainContext dBMainContext)
        {
            _dbMainContext = dBMainContext;
        }
        public TBProducts AddProduct(TBProducts product)
        {
            product.Id = Guid.NewGuid();
            _dbMainContext.Products.Add(product);
            _dbMainContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(TBProducts product)
        {
            _dbMainContext.Products.Remove(product);
            _dbMainContext.SaveChanges();
        }

        public TBProducts EditProduct(TBProducts product)
        {
            TBProducts existingProduct = _dbMainContext.Products.Find(product.Id);
            if(existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Qty = product.Qty;
                _dbMainContext.Products.Update(existingProduct);
                _dbMainContext.SaveChanges();
            }

            return product;
        }

        public TBProducts GetProduct(Guid id)
        {
            return _dbMainContext.Products.Find(id);
        }

        public List<TBProducts> GetProducts()
        {
            return _dbMainContext.Products.ToList();
        }
    }
}
