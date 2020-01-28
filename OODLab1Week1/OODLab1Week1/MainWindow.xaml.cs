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

namespace OODLab1Week1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random r = new Random();
        List<Band> BandLists = new List<Band>();
        List<Band> selectedBand = new List<Band>();
        int selectedBands, selectedGenre/*, selectedAlbum*/;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Band b1 = new Band("Foo fighters",1994,"David Grohl, taylor hawkins, chris shiflett",Band.BandGenre.rock);
            Band b2 = new Band("Linkin Park",1996,"chester bennington, mile shinoda, joe Hahn ", Band.BandGenre.rock);
            Band b3 = new Band("Arctic Monkeys",2002,"Alex turner, matt helders, jamie cook", Band.BandGenre.indie);
            Band b4 = new Band("Arcade Fire",2001, "win butler , regine Chassagne, william butler", Band.BandGenre.indie);
            Band b5 = new Band("The Beatles",1957, "John Lennon, Paul McCartney, Ringo Starr, George Harrison", Band.BandGenre.pop);
            Band b6 = new Band("ABBA",1972, "agnetha faltskog, ann-fir lyngstad, bjorn ulvaeus", Band.BandGenre.pop);

            BandLists.Add(b1);
            BandLists.Add(b2);
            BandLists.Add(b3);
            BandLists.Add(b4);
            BandLists.Add(b5);
            BandLists.Add(b6);


        }
        private DateTime GetRandomDate(DateTime startDate, DateTime endDate)
        {

            TimeSpan t = endDate - startDate;
            int releaseYear = t.Days;
            DateTime newYear = startDate.AddDays(r.Next(releaseYear));
            return newYear;
        }

        private void cbGenreband_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var b in selectedBand)
            {
                BandLists.Add(b);
            }

            selectedBand.Clear();

            selectedGenre = 0;
            selectedBands = 0;
            selectedGenre = 0;
            //selectedAlbum = 0;
           // RefreshDisplay();
        }
    }
}
