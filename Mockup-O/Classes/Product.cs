using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Mockup_O.Classes
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Size { get; set; }
        public App.States State { get; set; }

        public List<App.ProductGenres> Genres = new List<App.ProductGenres>();
        public List<string> ImageList { get; set; }
    }
}
