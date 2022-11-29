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
using System.Windows.Shapes;
using TP2.classes;

namespace TP2
{
    /// <summary>
    /// Logique d'interaction pour MarketplaceWindow.xaml
    /// </summary>
    public partial class MarketplaceWindow : Window
    {
        public MarketplaceWindow()
        {
            InitializeComponent();
            OfferType.SelectedIndex = 0;
            foreach(var auto in App.Current.Cars)
            {
                StackPanel newStackPanel = new StackPanel();
                TextBlock nom = new TextBlock();
                Image image = new Image();
                BitmapImage bitImage = new BitmapImage( new Uri("Assets/Offers/Cars/"+ auto.Value.Image,UriKind.Relative));
                image.Source = bitImage;
                image.Width = 150;
                image.Height = 150;
                nom.Text = auto.Value.Marque;
                newStackPanel.Width = 160;
                newStackPanel.Height = 220;
                SolidColorBrush gris = new SolidColorBrush();
                gris.Color = Color.FromRgb(90, 90, 90);
                newStackPanel.Background = gris;
                newStackPanel.Children.Add(image);
                newStackPanel.Children.Add(nom);
                Feed.Children.Add(newStackPanel);
            }
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void recherche()
        {

        }

        private void OfferType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
