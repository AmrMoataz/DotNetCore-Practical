using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessenseCorpTest.Services.Interfaces
{
    public interface IProductService
    {
        Product Create(Product product);
        List<Product> GetAll();
        Product GetOne(Guid id);
        Product Update(Guid id, Product product);
        bool Delete(Guid id);

    }
}
