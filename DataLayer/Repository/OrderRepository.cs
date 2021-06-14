using DataLayer.Data.DBContext;
using DataLayer.Data.Models;
using DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private DBMainContext _dbMainContext;
        public OrderRepository(DBMainContext dBMainContext)
        {
            _dbMainContext = dBMainContext;
        }
        public TBOrders AddOrder(TBOrders order, List<TBProducts> products)
        {
            order.Id = Guid.NewGuid();
            _dbMainContext.Orders.Add(order);
            order.Products.AddRange(products);
            _dbMainContext.SaveChanges();

            return order;
        }

        public void DeleteOrder(TBOrders order)
        {
            _dbMainContext.Orders.Remove(order);
            _dbMainContext.SaveChanges();
        }

        public TBOrders EditOrder(TBOrders order)
        {
            var existingOrder = _dbMainContext.Orders.Find(order.Id);
            if(existingOrder != null)
            {
                existingOrder.Date = order.Date;
                existingOrder.TotalPrice = order.TotalPrice;
                existingOrder.Products = order.Products;
                _dbMainContext.Orders.Update(existingOrder);
                _dbMainContext.SaveChanges();
            }
            return order;
        }

        public TBOrders GetOrder(Guid id)
        {
            return _dbMainContext.Orders.Find(id);
        }

        public List<TBOrders> GetOrders()
        {
            return _dbMainContext.Orders.ToList();
        }
    }
}
