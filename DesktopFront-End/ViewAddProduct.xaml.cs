using BusinessLayer.Models;
using BussinessenseCorpTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ViewAddProduct.xaml
    /// </summary>
    public partial class ViewAddProduct : Window
    {
        private IProductService _productService;
        
        public ViewAddProduct(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product();
            newProduct.Name = nametxt.Text;
            newProduct.Price = double.Parse(pricetxt.Text);
            newProduct.Qty = int.Parse(qtytxt.Text);

            _productService.Create(newProduct);
            Close();
        }

        private void pricetxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void qtytxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
    }
}
