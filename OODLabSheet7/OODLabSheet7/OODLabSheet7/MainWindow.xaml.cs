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

namespace OODLabSheet7
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        group c by c.Country into g
                        orderby g.Count() descending
                        select new
                        {
                            Country = g.Key,
                            Count = g.Count()
                        };

            dvgDisplay.ItemsSource = query.ToList();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        where c.Country == "Italy"
                        orderby c.CompanyName
                        select c;

            E2dvgDisplay.ItemsSource = query.ToList().Distinct();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Products
                        where (p.UnitsInStock - p.UnitsOnOrder > 0)
                        select new
                        {
                            Product = p.ProductName,
                            Available = p.UnitsInStock - p.UnitsOnOrder
                        };

            E3dvgDisplay.ItemsSource = query.ToList();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            var query = from od in db.Order_Details
                        orderby od.Product.ProductName
                        where od.Discount > 0
                        select new
                        {
                            ProductName = od.Product.ProductName,
                            DiscountGiven = od.Discount,
                            OrderID = od.OrderID
                        };

            E4dvgDisplay.ItemsSource = query.ToList();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            var query = from o in db.Orders
                        select o.Freight;
            //var query2=db.orders.Sum(o=>o.Freight);-could use this
            E5tblkResult.Text = string.Format("The total value for freight for all order is {0:C}", query.Sum());
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Products
                        orderby p.Category.CategoryName, p.UnitPrice descending
                        select new
                        {
                            p.CategoryID,
                            p.Category.CategoryName,
                            p.ProductName,
                            p.UnitPrice
                        };
            var results = query.ToList();

            E6dvgDisplay.ItemsSource = results;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            var query = from o in db.Orders
                        group o by o.CustomerID into g
                        orderby g.Count() descending
                        select new
                        {
                            CustomerID = g.Key,
                            NumberOfOrders = g.Count()
                        };
            E7dvgDisplay.ItemsSource = query.ToList().Take(10);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            var query = from o in db.Orders
                        group o by o.CustomerID into g
                        join c in db.Customers on g.Key equals c.CustomerID
                        orderby g.Count() descending
                        select new
                        {
                            CustomerID=g.Key,
                            CumpantName=c.CompanyName,
                            NumberOfOrders=c.Orders.Count
                        };
            E8dvgDisplay.ItemsSource = query.ToList().Take(10);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        where c.Orders.Count == 0
                        orderby c.Orders.Count
                        select new
                        {
                            CompanyID = c.CustomerID,
                            CompanyName = c.CompanyName,
                            NumbersOfOrders = c.Orders.Count
                        };
            E9dvgDisplay.ItemsSource = query.ToList();
        }
    }
}
