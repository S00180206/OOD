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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var quary = from c in db.Categories
                        join p in db.Products on c.CategoryName equals p.Category.CategoryName
                        orderby c.CategoryName
                        select new { Category = c.CategoryName, Product = p.ProductName };

            var results = quary.ToList();

            Ex1DvgDisplay.ItemsSource = results;

            Ex1TblCount.Text = results.Count.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var quary = from p in db.Products
                        orderby p.Category.CategoryName, p.ProductName
                        select new { Category = p.Category.CategoryName, Product = p.ProductName };

            var results = quary.ToList();

            Ex2DvgDisplay.ItemsSource = results;

            Ex2TblCount.Text = results.Count.ToString();
        }
    }
}
