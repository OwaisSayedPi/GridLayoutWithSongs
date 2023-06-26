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

namespace GridLayoutWithSongs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static List<Songs> GenerateSongList()
        {
            List<Songs> songs = new List<Songs>();
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Songs song = new Songs();
                song.SongID = i;
                song.SongRating = random.Next(5);                
                song.SongName = "AAAAAAAA";
                song.MaxRatingLimit = 5;
                songs.Add(song);
            }
            return songs;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Songs> songs = GenerateSongList();
            MainGrid.ItemsSource = songs;            
        }
    }
}
