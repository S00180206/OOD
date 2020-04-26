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

namespace IndividualProject_S00180206
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1Container db = new Model1Container();
        //List<Comic_FranchiseShows> AllComic_FranchiseShows;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from s in db.Shows
                        select s;
            lbxShows.ItemsSource = query.ToList();
        }

        private void RBShowName_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
