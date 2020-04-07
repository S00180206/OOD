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

namespace OODLab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1Container db = new Model1Container();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from b in db.Bands
                        select b;

            lbxBands.ItemsSource = query.ToList();
        }

        private void lbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine which band was selected
            Band selectedBand = lbxBands.SelectedItem as Band;
            

            //check for null
            if (selectedBand != null)
            {
                //display band info
                string bandText = $"Year formed: {selectedBand.Year_Formed}\nMemebers: {selectedBand.Members}";
                tblkBandinfo.Text = bandText;

                //display band image
                imgBand.Source = new BitmapImage(new Uri($"/images/{selectedBand.BandImage}", UriKind.Relative));

                //display albums
                lbxAlbums.ItemsSource = selectedBand.Albums;
            }

            Album selectedAlbum = lbxAlbums.SelectedItem as Album;

            if (selectedAlbum != null)
            {                
                //display band image
                imgAlbum.Source = new BitmapImage(new Uri($"/images/{selectedAlbum.AlbumImage}", UriKind.Relative));

                //display albums
                lbxAlbums.ItemsSource = selectedAlbum.AlbumImage;
            }
        }
    }
}
