using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessenseCorpTest.Services.Interfaces
{
    public interface IOrderService
    {
        Order Create(Order order);
        List<Order> GetAll();
        Order GetOne(Guid id); 
        bool Delete(Guid id);
    }
}
