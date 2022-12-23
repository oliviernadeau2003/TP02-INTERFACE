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

            item = item.OfType<armor>();

            foreach (armor armor in item)
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

            item = item.OfType<weapon>();

            foreach (weapon weapon in item)
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

            item = item.OfType<food>();

            foreach (food food in item)
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

            item = item.OfType<potion>();

            foreach (potion potion in item)
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
