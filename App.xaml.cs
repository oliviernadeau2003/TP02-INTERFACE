using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.Generic;
using TP2.classes;

namespace TP2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current { get { return (App)Application.Current; } }

        Dictionary<int,Car> Cars = new Dictionary<int, Car>()
        {
            { 1, new Car(){Id=1,Titre="",Description="",Fabricants="Honda",Price=1000,Marque="civic",Annee=2001,Odometre=350} }
        };
      
    }
}
