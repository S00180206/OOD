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
using System.IO;
using Newtonsoft.Json;

namespace IndividualProject_S00180206
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //data base of the show tables
        ComicShowsEntities db = new ComicShowsEntities();
        //List<Comic_FranchiseShows> AllComic_FranchiseShows;
        

        public MainWindow()
        {
            InitializeComponent();
        }
        //name of the show query
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            
            var query = from s in db.Shows
                        select s;
            lbxShows.ItemsSource = query.ToList();
        }

       
        // showing info of the show, its image, release and description
        private void lbxShows_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Show SelectedShow = lbxShows.SelectedItem as Show;
            if (SelectedShow!=null)
            {
                //display info of show
                string showText = $"show Name: {SelectedShow.Name}\nrelease{SelectedShow.Release}" +
                    $"\nShowDescription: {SelectedShow.ShowDiscription.Description}";
                tblkShowInfo.Text = showText;
                //display image
                imgShow.Source = new BitmapImage(new Uri($"/Images/{SelectedShow.ShowImage}",UriKind.Relative));
                
            }

        }
        //JSON showing info of the Shows
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Show selectedShow = lbxShows.SelectedItem as Show;
            if(selectedShow!=null)
            {
                
                string showdata = JsonConvert.SerializeObject(selectedShow, Formatting.Indented, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                using (StreamWriter sw = new StreamWriter(@"C:\temp\data.json"))
                {
                    sw.Write(showdata);
                    sw.Close();
                }
            }

            
        }

        //decendind query
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var query = from s in db.Shows
                        group s by s.Id into g
                        join c in db.ShowDiscriptions on g.Key equals c.NumberOfSeasons
                        orderby g.Count() descending
                        select new
                        {
                            Shows = c.Shows,
                            NumberOfSeasons=c.NumberOfSeasons,
                            ViewerCount=c.Shows.Count
                        };
            DvgDisplay.ItemsSource = query.ToList().Take(5);

        }
    }
}
