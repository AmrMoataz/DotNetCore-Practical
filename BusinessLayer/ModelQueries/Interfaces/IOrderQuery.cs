using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ModelQueries.Interfaces
{
    public interface IOrderQuery
    {
        List<Order> GetAll();
        Order GetOne(Guid id);
    }
}
