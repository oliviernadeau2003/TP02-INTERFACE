using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows;

namespace TP2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current { get { return (App)Application.Current; } }
    }
}
