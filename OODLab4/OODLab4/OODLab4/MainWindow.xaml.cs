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

namespace OODLab4
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //populate stock level listbox
            lbxStock.ItemsSource = Enum.GetNames(typeof(StockLevel));

            //populate the suppliers listbox using anonymous type
            var query1 = from s in db.Suppliers
                         orderby s.CompanyName
                       select new
                       {
                           SupplierName = s.CompanyName,
                           SupplierID = s.SupplierID,
                           Country = s.Country
                       };

            lbxSuppliers.ItemsSource = query1.ToList();

            //populate the countries list
            var query2 = query1
                .OrderBy(s => s.Country)
                .Select(s => s.Country);

            var countries = query2.ToList();

            lbxCountry.ItemsSource = countries.Distinct();
        }

        private void lbxStock_SlectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var query = from p in db.Products
                        where p.UnitsInStock < 50
                        orderby p.ProductName
                        select p.ProductName;

            string selected = lbxStock.SelectedItem as string;

            switch(selected)
            {
                case "Low":
                    //do nothing as a query sorted from the above
                    break;
                case "Normal":
                    query = from p in db.Products
                            where p.UnitsInStock < 50 && p.UnitsInStock<=100
                            orderby p.ProductName
                            select p.ProductName;
                    break;
                case"OverStocked":
                    query = from p in db.Products
                            where p.UnitsInStock > 100
                            orderby p.ProductName
                            select p.ProductName;
                    break;

                    
            }
            //update the product list
            lbxProduct.ItemsSource = query.ToList();
        }
        private void lbxSupplier_SlectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //using the selection value path
            int supplierID = Convert.ToInt32(lbxSuppliers.SelectedValue);

            var query = from p in db.Products
                        where p.SupplierID == supplierID
                        orderby p.ProductName
                        select p.ProductName;

            //update product list
            lbxProduct.ItemsSource = query.ToList();
        }
        private void lbxCountry_SlectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string country = (string)(lbxCountry.SelectedValue);

            var query = from p in db.Products
                        where p.Supplier.Country == country
                        orderby p.ProductName
                        select p.ProductName;

            lbxProduct.ItemsSource = query.ToList();
        }

    }//end

    public enum StockLevel { Low, Normal, Overstocked};
}
