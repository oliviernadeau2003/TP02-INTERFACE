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

namespace TP2
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

        private void Wall_Button_Click(object sender, RoutedEventArgs e)
        {
            Window WallWindow = new WallWindow();
            WallWindow.Show();
        }

        private void Marketplace_Button_Click(object sender, RoutedEventArgs e)
        {
            Window MarketplaceWindow = new MarketplaceWindow();
            MarketplaceWindow.Show();
        }
    }
}
