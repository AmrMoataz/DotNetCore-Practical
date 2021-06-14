using BusinessLayer.ModelQueries.Interfaces;
using BusinessLayer.Models;
using DataLayer.Data.Models;
using DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ModelQueries
{
    public class OrderQuery : IOrderQuery
    {
        private IOrderRepository _orderRepository;

        public OrderQuery(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAll()
        {
            List<TBOrders> tBOrders = _orderRepository.GetOrders();
            List<Order> orders = new List<Order>();
            foreach (var tbOrd in tBOrders)
            {
                Order order = new Order();
                order.Date = tbOrd.Date;
                order.Id = tbOrd.Id;
                order.TotalPrice = tbOrd.TotalPrice;
                tbOrd.Products.ForEach(p =>
                {
                    Product product = new Product();
                    product.Name = p.Name;
                    product.Price = p.Price;
                    product.Id = p.Id;
                    product.Qty = p.Qty;
                    order.Products.Add(product);
                });
                orders.Add(order);
            }

            return orders;
        }

        public Order GetOne(Guid id)
        {
            TBOrders tbOrd = _orderRepository.GetOrder(id);
            Order order = new Order();
            order.Date = tbOrd.Date;
            order.Id = tbOrd.Id;
            order.TotalPrice = tbOrd.TotalPrice;
            tbOrd.Products.ForEach(p =>
            {
                Product product = new Product();
                product.Name = p.Name;
                product.Price = p.Price;
                product.Id = p.Id;
                product.Qty = p.Qty;
                order.Products.Add(product);
            });
            return order;
        }
    }
}
