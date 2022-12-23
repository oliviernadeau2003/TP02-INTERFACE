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

namespace TP2.Mockup_V
{
    /// <summary>
    /// Logique d'interaction pour MockupWindow_V.xaml
    /// https://www.deviantart.com/sirbrownie/art/Zelda-Fan-Game-Platformer-INV-Mockup-475829684
    /// </summary>
    public partial class MockupWindow_V : Window
    {
        public MockupWindow_V()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            feed.Children.Clear();

            IEnumerable<Object> item = App.Current.Items.Values;
            IEnumerable<armor> armorList = item.OfType<armor>();

            if (orderByQuantity.IsChecked == true)
            {
                armorList = armorList.OrderBy(l => l.quantite);
            }
            if (weight.IsChecked == true)
            {
                armorList = armorList.Where(l => l.weight < 10);
            }

            foreach (armor armor in armorList)
            {
                itemControl itemCp = new itemControl(armor);
                itemCp.Width = 50;
                feed.Children.Add(itemCp);
            }
        }

        private void Button_Click_Weapon(object sender, RoutedEventArgs e)
        {

            feed.Children.Clear();

            IEnumerable<Object> item = App.Current.Items.Values;

            IEnumerable<weapon> weaponList = item.OfType<weapon>();

            if (orderByQuantity.IsChecked == true)
            {
                weaponList = weaponList.OrderBy(l => l.quantite);
            }
            if (weight.IsChecked == true)
            {
                weaponList = weaponList.Where(l => l.weight < 10);
            }

   

            foreach (weapon weapon in weaponList)
            {
                itemControl itemCp = new itemControl(weapon);
                itemCp.Width = 50;
                feed.Children.Add(itemCp);
            }
        }

        private void Button_Click_Food(object sender, RoutedEventArgs e)
        {
            feed.Children.Clear();

            IEnumerable<Object> item = App.Current.Items.Values;

            IEnumerable<food> foodList = item.OfType<food>();

            if (orderByQuantity.IsChecked == true)
            {
                foodList = foodList.OrderBy(l => l.quantite);
            }
            if (weight.IsChecked == true)
            {
                foodList= foodList.Where(l => l.weight < 10);
            }



            foreach (food food in foodList)
            {
                itemControl itemCp = new itemControl(food);
                itemCp.Width = 50;
                feed.Children.Add(itemCp);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            feed.Children.Clear();

            IEnumerable<Object> item = App.Current.Items.Values;

            IEnumerable<potion> potionList = item.OfType<potion>();

            if (orderByQuantity.IsChecked == true)
            {
                potionList = potionList.OrderBy(l => l.quantite);
            }
            if (weight.IsChecked == true)
            {
                potionList = potionList.Where(l => l.weight < 10);
            }

            foreach (potion potion in potionList)
            {
                itemControl itemCp = new itemControl(potion);
                itemCp.Width = 50;
                feed.Children.Add(itemCp);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            feed.Children.Clear();
            IEnumerable<Object> item = App.Current.Items.Values;
          
            foreach (item items in item)
            {
                itemControl itemCp = new itemControl(items);
                itemCp.Width = 50;
                feed.Children.Add(itemCp);
            }
        }

     
    }
}
