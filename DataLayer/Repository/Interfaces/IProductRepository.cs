using DataLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Interfaces
{
    public interface IProductRepository
    {
        List<TBProducts> GetProducts();
        TBProducts GetProduct(Guid id);
        TBProducts AddProduct(TBProducts product);
        TBProducts EditProduct(TBProducts product);
        void DeleteProduct(TBProducts product);

    }
}
