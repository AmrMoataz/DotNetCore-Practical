using BusinessLayer.Factories.Interfaces;
using BusinessLayer.Models;
using DataLayer.Data.Models;
using DataLayer.Repository;
using DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Factories
{
    public class ProductFactory : IProductFactory
    {
        private IProductRepository _productRepository;
        public ProductFactory(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Add(Product product)
        {
            TBProducts tbProduct = product.TBProduct; 
            tbProduct = _productRepository.AddProduct(tbProduct);
            product.Id = tbProduct.Id;
            return product;
        }

        public Product Edit(Product product)
        {
            TBProducts tBProduct = product.TBProduct;
            _productRepository.EditProduct(tBProduct);

            return product;
        } 

        public bool remove(Guid id)
        {
            try
            {
                TBProducts tBProducts = _productRepository.GetProduct(id);
                _productRepository.DeleteProduct(tBProducts);
                return true;
            }
            catch
            {
                return false; 
            }
        }
    }
}
