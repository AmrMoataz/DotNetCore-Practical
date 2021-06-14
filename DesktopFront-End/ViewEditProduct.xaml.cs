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
    /// Interaction logic for ViewEditProduct.xaml
    /// </summary>
    public partial class ViewEditProduct : Window
    {
        private IProductService _productService;
        private Product _product;

        public ViewEditProduct(IProductService productService, Product product)
        {
            InitializeComponent();
            _productService = productService;
            _product = product;
            Init();
        }

        private void Init()
        {
            nametxt.Text = _product.Name;
            pricetxt.Text = _product.Price.ToString();
            qtytxt.Text = _product.Qty.ToString();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            _product.Name = nametxt.Text;
            _product.Price = double.Parse(pricetxt.Text);
            _product.Qty = int.Parse(qtytxt.Text);

            _productService.Update(_product.Id, _product);
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
