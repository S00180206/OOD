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

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            var quary1 = (from detail in db.Order_Details
                          where detail.ProductID == 7
                          select detail);

            var quary2 = (from detail in db.Order_Details
                          where detail.ProductID == 7
                          select detail.UnitPrice * detail.Quantity);

            int numberOfOrders = quary1.Count();
            decimal totalValue = quary2.Sum();
            decimal averageValue = quary2.Average();

            Ex3TblkDetails.Text = string.Format("Total number of {0}\nValue of numbers {1:C}\nAverage number value {2:C}",
                numberOfOrders, totalValue, averageValue);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            var quary = from customer in db.Customers
                        orderby customer.Orders.Count >= 20
                        select new
                        {
                            Name=customer.CompanyName,
                            OrderCount = customer.Orders.Count
                        
                        };

            Ex4DvgDisplay.ItemSource = quary.ToList();

        }


        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            var quary = from customer in db.Customers
                        orderby customer.Orders.Count < 3
                        select new
                        {
                            Company=customer.CompanyName,
                            City = customer.City,
                            Region=customer.Region,
                            OrderCount = customer.Orders.Count
                        };

            Ex5DvgDisplay5.ItemSource = quary.ToList();

        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            var quary = from customer in db.Customers
                        orderby customer.CompanyName
                        select customer.CompanyName;

            Ex6LbxEx6Customers.ItemSource = quary.ToList();

        }
        private void lbxEx6Customers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string company = (string)Ex6LbxEx6Customers.SelectedItem;

            if(company !=null)
            {
                var quary = (from detail in db.Order_Details
                            orderby detail.Order.Customer.CumpanyName == company
                            select detail.UnitPrice * detail.Quantity).Sum();

                Ex6tblkEx6OrderSummary.Text = string.Format("Total for supplier {0}\n\n{1:C}", company, quary);
            }
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            var quary = from p in db.Products
                        group p by p.Category.CategoryName into g
                        orderby g.Count() descending
                        select new
                        { 
                            Category = g.Key,
                            Count=g.Count()

                        };

            Ex7DvgDisplay.ItemSource = quary.ToList();

        }
    }
}
