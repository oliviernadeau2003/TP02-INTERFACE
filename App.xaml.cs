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

        public Dictionary<int,Car> Cars = new Dictionary<int, Car>()
        {
            { 1, new Car(){Id=1, Image="car1.jpg",Titre="",Description="",Fabricants="Honda",Price=1000,Marque="civic",Annee=2001,Odometre=350} },
            {2, new Car(){Id=2, Image="car2.jpg",Titre="",Description="", Price=6000   ,Fabricants=" Honda "  ,Marque="Accord  " ,Annee= 2014    ,Odometre =170} },
            {3, new Car(){Id=3, Image="car3.jpg",Titre="",Description="", Price=5000   ,Fabricants=" Toyota"  ,Marque="Camry   " ,Annee= 2015    ,Odometre =200} },
            {4, new Car(){Id=4, Image="car4.jpg",Titre="",Description="", Price=8000   ,Fabricants=" Nissan"  ,Marque="Leaf    " ,Annee= 2013    ,Odometre =210} },
            {5, new Car(){Id=5, Image="car5.jpg",Titre="",Description="", Price=10000  ,Fabricants=" Toyota"  ,Marque="Yaris   " ,Annee= 2021    ,Odometre =20} },
            {6, new Car(){Id=6, Image="car6.jpg",Titre="",Description="", Price= 1000  ,Fabricants="  Honda"  ,Marque=" Civic  " ,Annee=  2001   ,Odometre = 350} },
            {7, new Car(){Id=7, Image="car7.jpg",Titre="",Description="", Price= 6000  ,Fabricants="  Honda"  ,Marque=" Civic  " ,Annee=  2011   ,Odometre = 140} },
            {8, new Car(){Id=8, Image="car8.jpg",Titre="",Description="", Price=20000  ,Fabricants=" Toyota"  ,Marque="Camry   " ,Annee= 2021    ,Odometre =10} },
            {9, new Car(){Id=9, Image="car9.jpg",Titre="",Description="", Price=7000   ,Fabricants=" Nissan"  ,Marque="Infiniti" ,Annee= 2015,    Odometre =150} },
            {10, new Car(){Id=10, Image="car10.jpg",Titre="",Description="", Price=9000   ,Fabricants=" Nissan"  ,Marque="Infiniti" ,Annee=2016,    Odometre = 170} },
            {11, new Car(){Id=11, Image="car11.jpg",Titre="",Description="", Price=12000  ,Fabricants=" Honda "  ,Marque="Accord  " ,Annee= 2018    ,Odometre =90} },
            {12, new Car(){Id=12, Image="car12.jpg",Titre="",Description="", Price=5000   ,Fabricants=" Toyota"  ,Marque="Yaris   " ,Annee= 2013    ,Odometre =210} },
            {13, new Car(){Id=13, Image="car13.jpg",Titre="",Description="", Price=2000   ,Fabricants=" Nissan"  ,Marque="Altima  " ,Annee= 2003    ,Odometre =320 } }

        };
      
    }
}
