using BusinessLayer.Factories.Interfaces;
using DataLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Models
{
    public class Order
    {
        private IOrderFactory _orderFactory;

        

        public Order()
        {

        }
         

        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public TBOrders tBOrder
        {
            get
            {
                TBOrders tBOrder = new TBOrders();
                tBOrder.Id = Id;
                tBOrder.Date = Date;
                tBOrder.TotalPrice = TotalPrice;
                //Products.ForEach(p =>
                //{
                //    tBOrder.Products.Add(p.TBProduct);
                //});
                return tBOrder;
            }
        }

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
