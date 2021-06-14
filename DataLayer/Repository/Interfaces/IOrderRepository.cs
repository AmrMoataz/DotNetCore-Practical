using DataLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Interfaces
{
    public interface IOrderRepository
    {
        List<TBOrders> GetOrders();
        TBOrders GetOrder(Guid id);
        TBOrders AddOrder(TBOrders order, List<TBProducts> products);
        TBOrders EditOrder(TBOrders order);
        void DeleteOrder(TBOrders order);
    }
}
