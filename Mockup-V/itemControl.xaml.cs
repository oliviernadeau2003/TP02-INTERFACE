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

namespace TP2.Mockup_V
{
    /// <summary>
    /// Logique d'interaction pour itemControl.xaml
    /// </summary>
    public partial class itemControl : UserControl
    {
        private item Item;
        public itemControl(item item)
        {
            InitializeComponent();
            Item = item;
            Uri link = new Uri("../Assets/items/" + item.img, UriKind.Relative);
            ImageProduct.Source = new BitmapImage(link);
            quantite.Text = item.quantite.ToString();
        }
    }
}
