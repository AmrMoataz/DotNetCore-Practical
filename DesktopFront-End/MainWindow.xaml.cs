using BusinessLayer.Models;
using BussinessenseCorpTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopFront_End
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IProductService _productService;
        private IOrderService _orderService;
        public MainWindow(IProductService productService, IOrderService orderService)
        {
            InitializeComponent();
            _productService = productService;
            _orderService = orderService;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }

        private void LoadAllOrders()
        {
            List<Order> orders = _orderService.GetAll().OrderBy(o => o.Date).ToList() ;
            foreach (var ord in orders)
            {
                ordersList.Items.Add(ord);
            }
        }

        private void LoadAllProducts()
        {
            List<Product> products = _productService.GetAll().OrderBy(p => p.Name).ToList();
            foreach (var prod in products)
            {
                productsList.Items.Add(prod);
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Product product = (Product)productsList.SelectedItem;
            if (_productService.Delete(product.Id))
                productsList.Items.Remove(product);

            clearDetails();
        }

        private void clearDetails()
        {
            dtId.Text = "";
            dtName.Text = "";
            dtPrice.Text ="";
            dtQty.Text = "";
        }

        private void productsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             Product product = (Product)productsList.SelectedItem;
            if(product != null)
            {
                dtId.Text = product.Id.ToString();
                dtName.Text = product.Name;
                dtPrice.Text = product.Price.ToString();
                dtQty.Text = product.Qty.ToString();
            }
            
        }

        private void ordersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Order order = (Order)ordersList.SelectedItem;
            if(order != null)
            {
                FilterProducts(order);
                dtDate.Text = order.Date.ToString(); ;
                dtTotalPrice.Text = order.TotalPrice.ToString();
            }


        }

        private void FilterProducts(Order order)
        {
            clearDetails();
            clearOrderDetails();
            productsList.Items.Clear();

            order.Products.ForEach(p =>
            {
                productsList.Items.Add(p);
            });
        }

        private void clearOrderDetails()
        {
            dtDate.Text = "";
            dtTotalPrice.Text ="";
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewAddProduct viewAddProduct = new ViewAddProduct(_productService);
            viewAddProduct.ShowDialog();

            Init();
        }

        private void Init()
        {
            productsList.Items.Clear();
            ordersList.Items.Clear();
            LoadAllOrders();
            LoadAllProducts();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            Product product = (Product)productsList.SelectedItem;
           if(product != null)
            {
                ViewEditProduct viewEditProduct = new ViewEditProduct(_productService, product);
                viewEditProduct.ShowDialog();
                Init();
            }
        }

        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewOrder viewOrder = new ViewOrder(_productService, _orderService);
            viewOrder.ShowDialog();
            Init();
        }
    }
}
