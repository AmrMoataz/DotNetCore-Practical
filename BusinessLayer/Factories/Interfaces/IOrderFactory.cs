using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Factories.Interfaces
{
    public interface IOrderFactory
    {
        
        Order Add(Order order);
        Order Edit(Order order);
        bool remove(Guid id);
    }
}
