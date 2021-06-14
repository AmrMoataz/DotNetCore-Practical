using BusinessLayer.Factories.Interfaces;
using BusinessLayer.ModelQueries.Interfaces;
using BusinessLayer.Models;
using DataLayer.Data.Models;
using DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Factories
{
    public class OrderFactory : IOrderFactory
    {
        private IOrderRepository _orderRepository;
        private IProductRepository _productRepository;

        public OrderFactory(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public Order Add(Order order)
        {
            order.Date = DateTime.Now;
            order.TotalPrice = 0;
            order.Products.ForEach(p =>
            {
                order.TotalPrice += p.Price;
            });

            List<TBProducts> tBProducts = GetOrderProductsData(order.Products);

            TBOrders tbOrder = order.tBOrder;
           tbOrder = _orderRepository.AddOrder(tbOrder, tBProducts);
            order.Id = tbOrder.Id;
            return order;
        }

        private List<TBProducts> GetOrderProductsData(List<Product> products)
        {
            List<TBProducts> list = new List<TBProducts>();
            foreach (var prod in products)
            {
                TBProducts tbProduct = _productRepository.GetProduct(prod.Id);
                list.Add(tbProduct);
            }
            return list;
        }

        public Order Edit(Order order)
        {
            TBOrders tBOrder = order.tBOrder;
            _orderRepository.EditOrder(tBOrder);
            return order;
        }

      

        public bool remove(Guid id)
        {
            try
            {
                TBOrders tBOrders = _orderRepository.GetOrder(id);
                _orderRepository.DeleteOrder(tBOrders);
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
