using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Mockup_O.Classes
{
    public class Engine : Product
    {
        public string PrimaryLanguage { get; set; }
        public List<string> Developpers { get; set; }
        public string Middleware { get; set; }
        public List<string> Platforms { get; set; }
        public string License { get; set; }
        public List<string> NotableGames { get; set; }
        public double Version { get; set; }

    }
}
