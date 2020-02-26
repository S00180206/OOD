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
        List<Comic_FranchiseShows> AllComic_Franchise=new List<Comic_FranchiseShows>();
        List<Comic_FranchiseShows> selectedComic_Franchise=new List<Comic_FranchiseShows>();
        List<Comic_FranchiseShows> filteredComic_Franchise=new List<Comic_FranchiseShows>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Comic_FranchiseShows f1 = new Comic_FranchiseShows("Daredevil",);
            Comic_FranchiseShows f2 = new Comic_FranchiseShows("the walking dead",);
            Comic_FranchiseShows f3 = new Comic_FranchiseShows("Arrow",);
            Comic_FranchiseShows f4 = new Comic_FranchiseShows("Agents of sheild",);
            Comic_FranchiseShows f5 = new Comic_FranchiseShows("",);
            Comic_FranchiseShows f6 = new Comic_FranchiseShows("",);

            AllComic_Franchise.Add(f1);
            AllComic_Franchise.Add(f2);
            AllComic_Franchise.Add(f3);
            AllComic_Franchise.Add(f4);
            AllComic_Franchise.Add(f5);
            AllComic_Franchise.Add(f6);
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            Comic_FranchiseShows selectedComic_Franchise=
        }
    }
}
