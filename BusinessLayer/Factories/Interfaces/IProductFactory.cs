using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Factories.Interfaces
{
    public interface IProductFactory
    {
       
        Product Add(Product product);
        Product Edit(Product product);
        bool remove(Guid id);
    }
}
