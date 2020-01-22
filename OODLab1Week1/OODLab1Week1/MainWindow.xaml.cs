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
        List<Band> BandLists = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Band band1 = new Band("Foo fighters",1994,"David Grohl, taylor hawkins, chris shiflett",Band.BandGenre.rock);
            Band band2 = new Band("Linkin Park",1996,"chester bennington, mile shinoda, joe Hahn ", Band.BandGenre.rock);
            Band band3 = new Band("Arctic Monkeys",2002,"Alex turner, matt helders, jamie cook", Band.BandGenre.indie);
            Band band4 = new Band("Arcade Fire",2001, "win butler , regine Chassagne, william butler", Band.BandGenre.indie);
            Band band5 = new Band("The Beatles",1957, "John Lennon, Paul McCartney, Ringo Starr, George Harrison", Band.BandGenre.pop);
            Band band6 = new Band("ABBA",1972, "agnetha faltskog, ann-fir lyngstad, bjorn ulvaeus", Band.BandGenre.pop);

            BandLists.Add(band1);
            BandLists.Add(band2);
            BandLists.Add(band3);
            BandLists.Add(band4);
            BandLists.Add(band5);
            BandLists.Add(band6);
        }
    }
}
