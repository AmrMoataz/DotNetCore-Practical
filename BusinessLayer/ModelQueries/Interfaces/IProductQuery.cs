using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ModelQueries.Interfaces
{
    public interface IProductQuery
    {
        List<Product> GetAll();
        Product GetOne(Guid id);
    }
}
