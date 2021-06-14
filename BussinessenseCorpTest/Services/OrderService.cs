using BusinessLayer.Factories.Interfaces;
using BusinessLayer.ModelQueries.Interfaces;
using BusinessLayer.Models;
using BussinessenseCorpTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessenseCorpTest.Services
{
    public class OrderService : IOrderService
    {
        private IOrderFactory _orderFactory;
        private IOrderQuery _orderQuery;

        public OrderService(IOrderFactory orderFactory, IOrderQuery orderQuery)
        {
            _orderFactory = orderFactory;
            _orderQuery = orderQuery;
        }

        public Order Create(Order order)
        {
            if(validateInput(order))
                return _orderFactory.Add(order);
            return null;
        }

        private bool validateInput(Order order)
        {
            bool result = true;
            order.Products.ForEach(p =>
            {
                if (p.Id == null)
                    result = false;
            });

            return result;
        }

        public bool Delete(Guid id)
        {
            return _orderFactory.remove(id);
        }

        public List<Order> GetAll()
        {
            return _orderQuery.GetAll();
        }

        public Order GetOne(Guid id)
        {
            return _orderQuery.GetOne(id);
        }

         
    }
}
