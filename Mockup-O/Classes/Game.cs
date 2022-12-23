using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Mockup_O.Classes
{
    public class Game : Product
    {
        public string Developper { get; set; }
        public string Publisher { get; set; }
        public string Director { get; set; }
        public List<string> Programmers { get; set; }
        public List<string> Artists { get; set; }
        public List<string> Writters { get; set; }
        public List<string> Composers { get; set; }
        public string? Series { get; set; }
        public string Engine { get; set; }
        public string ReleaseDate { get; set; }
        public List<string> Modes { get; set; }

    }
}
