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
            maker.Items.Add("All");
            maker.Items.Add("Nissan");
            maker.Items.Add("Toyota");
            maker.Items.Add("Honda");
            Brand.Items.Add("Leaf");
            Brand.Items.Add("Yaris");
            Brand.Items.Add("Civic");
            Brand.Items.Add("Camry");
            Brand.Items.Add("Infinity");
            Brand.Items.Add("Accord");
            Brand.Items.Add("Altima");
            Brand.Items.Add("All");
            rechercheCar();
        }   

        private void search_Click(object sender, RoutedEventArgs e)
        {
            
            rechercheCar();

        }

        private void rechercheCar()
        {
            IEnumerable<Car> cars = App.Current.Cars.Values;

            if(int.TryParse(priceMin.Text,out int minPrice)){
                cars = cars.Where(x => x.Price > minPrice);
            }

            if (int.TryParse(priceMax.Text, out int maxPrice)){
                cars = cars.Where(x => x.Price < maxPrice);
            }
            if (maker.SelectedValue == "Nissan")
            {
                cars = cars.Where(x => x.Fabricants=="Nissan");
            }
            if (maker.SelectedValue == "Toyota")
            {
                cars = cars.Where(x => x.Fabricants == "Toyota");
            }
            if (maker.SelectedValue == "Honda")
            {
                cars = cars.Where(x => x.Fabricants == "Honda");
            }
            if(Brand.SelectedValue == "Leaf")
            {
                cars = cars.Where(x => x.Marque == "Leaf");
            }
            if (Brand.SelectedValue == "Yaris")
            {
                cars = cars.Where(x => x.Marque == "Yaris");
            }
            if (Brand.SelectedValue == "Civic")
            {
                cars = cars.Where(x => x.Marque == "Civic");
            }
            if (Brand.SelectedValue == "Camry")
            {
                cars = cars.Where(x => x.Marque == "Camry");
            }
            if (Brand.SelectedValue == "Infinity")
            {
                cars = cars.Where(x => x.Marque == "Infinity");
            }
            if (Brand.SelectedValue == "Accord")
            {
                cars = cars.Where(x => x.Marque == "Accord");
            }
            if (Brand.SelectedValue == "Altima")
            {
                cars = cars.Where(x => x.Marque == "Altima");
            }

            if (int.TryParse(yearMin.Text, out int minYear))
            {
                cars = cars.Where(x => x.Annee > minYear);
            }

            if (int.TryParse(yearMax.Text, out int maxYear))
            {
                cars = cars.Where(x => x.Annee < maxYear);
            }

            if (int.TryParse(mileageMin.Text, out int minMil))
            {
                cars = cars.Where(x => x.Odometre > minMil);
            }

            if (int.TryParse(mileageMax.Text, out int maxMil))
            {
                cars = cars.Where(x => x.Odometre < maxMil);
            }

            if (date.IsChecked==true)
            {
                cars.OrderBy(x => x.Date);
            }

            if (price.IsChecked == true)
            {
                cars.OrderBy(x => x.Price);
            }

            Feed.Children.Clear();

            foreach (Car car in cars)
            {
                Market_UserControl marketCP = new Market_UserControl(car);
                marketCP.Width = 200;
                Feed.Children.Add(marketCP);
            }
        }

        private void OfferType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
