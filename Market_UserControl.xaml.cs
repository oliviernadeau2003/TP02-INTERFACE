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
using TP2.classes;

namespace TP2
{
    /// <summary>
    /// Logique d'interaction pour Market_UserControl.xaml
    /// </summary>
    public partial class Market_UserControl : UserControl
    {
        private Car Car;
        public Market_UserControl(Car car)
        {
            InitializeComponent();
            Car = car;
            Uri link = new Uri("../Assets/Offers/Cars/" + Car.Image, UriKind.Relative);
            ImageProduct.Source = new BitmapImage(link);
            TextBlockPrice.Text = Car.Price.ToString();
            TextBlockName.Text = Car.Annee+" "+Car.Fabricants+" "+Car.Marque;
            TextBlockDate.Text = Car.Date;
            TextBlockKm.Text = Car.Odometre.ToString()+" km";
        }
    }
}
