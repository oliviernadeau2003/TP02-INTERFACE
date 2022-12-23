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
            OfferType.Items.Add("Cars");
            OfferType.Items.Add("Appliances");
            OfferType.Items.Add("Proprety rental");
            OfferType.SelectedIndex = 0;
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
            visibilityHandler();
            rechercheCar();
        }   

        private void search_Click(object sender, RoutedEventArgs e)
        {


            find();

        }
        private void find()
        {
            Feed.Children.Clear();
            if (OfferType.SelectedValue == "Cars")
            {
                rechercheCar();
            }
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

            foreach (Car car in cars)
            {
                Market_UserControl marketCP = new Market_UserControl(car);
                marketCP.Width = 200;
                Feed.Children.Add(marketCP);
            }
        }

        private void OfferType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            visibilityHandler();
        }

        private void visibilityHandler()
        {
            if (OfferType.SelectedValue == "Cars")
            {
                maker.Visibility = Visibility.Visible;
                Brand.Visibility = Visibility.Visible;
                mileageMax.Visibility = Visibility.Visible;
                mileageMin.Visibility = Visibility.Visible;
                mil.Visibility = Visibility.Visible;
                mil2.Visibility = Visibility.Visible;
                year.Visibility = Visibility.Visible;
                year2.Visibility = Visibility.Visible;
                yearMax.Visibility = Visibility.Visible;
                yearMin.Visibility = Visibility.Visible;
                makerText.Visibility = Visibility.Visible;
                brandText.Visibility = Visibility.Visible;

                appliance.Visibility = Visibility.Collapsed;
                applianceBrand.Visibility = Visibility.Collapsed;
                applianceBrandText.Visibility = Visibility.Collapsed;
                applianceText.Visibility = Visibility.Collapsed;

                proprety.Visibility = Visibility.Collapsed;
                propretyText.Visibility = Visibility.Collapsed;
                roomstext.Visibility = Visibility.Collapsed;
                Rooms.Visibility = Visibility.Collapsed;
                bathroomText.Visibility = Visibility.Collapsed;
                bath.Visibility = Visibility.Collapsed;
            }
            else if(OfferType.SelectedValue == "Appliances")
            {
                maker.Visibility = Visibility.Collapsed;
                Brand.Visibility = Visibility.Collapsed;
                mileageMax.Visibility = Visibility.Collapsed;
                mileageMin.Visibility = Visibility.Collapsed;
                mil.Visibility = Visibility.Collapsed;
                mil2.Visibility = Visibility.Collapsed;
                year.Visibility = Visibility.Collapsed;
                year2.Visibility = Visibility.Collapsed;
                yearMax.Visibility = Visibility.Collapsed;
                yearMin.Visibility = Visibility.Collapsed;
                makerText.Visibility = Visibility.Collapsed;
                brandText.Visibility = Visibility.Collapsed;

                appliance.Visibility = Visibility.Visible;
                applianceBrand.Visibility = Visibility.Visible;
                applianceBrandText.Visibility = Visibility.Visible;
                applianceText.Visibility = Visibility.Visible;

                proprety.Visibility = Visibility.Collapsed;
                propretyText.Visibility = Visibility.Collapsed;
                roomstext.Visibility = Visibility.Collapsed;
                Rooms.Visibility = Visibility.Collapsed;
                bathroomText.Visibility = Visibility.Collapsed;
                bath.Visibility = Visibility.Collapsed;
            }
            else
            {
                proprety.Visibility = Visibility.Visible;
                propretyText.Visibility = Visibility.Visible;
                roomstext.Visibility = Visibility.Visible;
                Rooms.Visibility = Visibility.Visible;
                bathroomText.Visibility = Visibility.Visible;
                bath.Visibility = Visibility.Visible;

                maker.Visibility = Visibility.Collapsed;
                Brand.Visibility = Visibility.Collapsed;
                mileageMax.Visibility = Visibility.Collapsed;
                mileageMin.Visibility = Visibility.Collapsed;
                mil.Visibility = Visibility.Collapsed;
                mil2.Visibility = Visibility.Collapsed;
                year.Visibility = Visibility.Collapsed;
                year2.Visibility = Visibility.Collapsed;
                yearMax.Visibility = Visibility.Collapsed;
                yearMin.Visibility = Visibility.Collapsed;
                makerText.Visibility = Visibility.Collapsed;
                brandText.Visibility = Visibility.Collapsed;

                appliance.Visibility = Visibility.Collapsed;
                applianceBrand.Visibility = Visibility.Collapsed;
                applianceBrandText.Visibility = Visibility.Collapsed;
                applianceText.Visibility = Visibility.Collapsed;
            }

            find();
        }
    }
}
