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
using TP2.Mockup_O.Classes;

namespace TP2.Mockup_O
{
    /// <summary>
    /// Logique d'interaction pour ListViewUserControl.xaml
    /// </summary>
    public partial class ListViewUserControl : UserControl
    {
        private Product Product;
        private MockupWindow_O MockupWindow;

        public ListViewUserControl() { }

        public ListViewUserControl(Product product, MockupWindow_O mockupWindow)
        {
            InitializeComponent();

            Product = product;
            MockupWindow = mockupWindow;

            LoadImage();
            ProductName.Text = Product.Name;
            if (Product.State == App.States.Installing)
            {
                ProductDownloadProgressBar.Visibility = Visibility.Visible;
                ProductDownloadProgressBar.Value = (Double)new Random().Next(0,100);
                ProductState.Text = $"Installing {ProductDownloadProgressBar.Value}%";
            } else
            {
                ProductDownloadProgressBar.Visibility = Visibility.Collapsed;
                ProductState.Text = Product.State.ToString();
            }
            ProductSize.Text = Product.Size.ToString("#.##GB");
            Border.Opacity = (Product.State == App.States.Launch) ? Border.Opacity = 1 : Border.Opacity = 0.6;

        }

        private void Border_MouseEnter(object sender, MouseEventArgs e) => Border.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#056CE1");

        private void Border_MouseLeave(object sender, MouseEventArgs e) => Border.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#202020");

        private void LoadImage()
        {
            ProductImage.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Placeholder/Placeholder.png"));
            ProductImage.Width = 96;
            ProductImage.Height = 54;

            ProductInteractButtonImage.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/3Dots-Icon.png"));
            ProductInteractButtonImage.Width = 25;
        }
    }
}
