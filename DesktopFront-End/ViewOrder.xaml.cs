using BusinessLayer.Models;
using BussinessenseCorpTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesktopFront_End
{
    /// <summary>
    /// Interaction logic for ViewOrder.xaml
    /// </summary>
    public partial class ViewOrder : Window
    {
        private IProductService _productService;
        private IOrderService _orderService;

        public ViewOrder(IProductService productService, IOrderService orderService)
        {
            InitializeComponent();

            _productService = productService;
            _orderService = orderService;

            Init();
        }

        private void Init()
        {
            LoadAllProducts();
        }

        private void LoadAllProducts()
        {
            List<Product> products = _productService.GetAll().OrderBy(p => p.Name).ToList() ;
            products.ForEach(p =>
            {
                productsList.Items.Add(p);
            });
        }

        private void orderbtn_Click(object sender, RoutedEventArgs e)
        {
            if(productsList.SelectedItems.Count > 0)
            {
                Order newOrder = new Order();
                foreach (var prod in productsList.SelectedItems)
                {
                    newOrder.Products.Add((Product)prod);
                }
                _orderService.Create(newOrder);
                Close();
            }
            else
            {
                MessageBox.Show("Please Select Products to order");
            }
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
