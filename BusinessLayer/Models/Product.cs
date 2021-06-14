using BusinessLayer.Factories.Interfaces;
using DataLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Models
{
    public class Product
    { 
        public Product()
        {

        } 

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        List<Order> Orders { get; set; } = new List<Order>();

        public TBProducts TBProduct
        {
            get
            {
                TBProducts tBProducts = new TBProducts();
                tBProducts.Name = Name;
                tBProducts.Price = Price;
                tBProducts.Qty = Qty;
                tBProducts.Id = Id;
                return tBProducts;
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }


    }
}
