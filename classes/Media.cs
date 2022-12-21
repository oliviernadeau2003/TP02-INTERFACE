using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TP2.classes
{
    public class Media
    {
        public int UserId { get; set; }
        public string Url { get; set; }
        public List<string> Tags { get; set; }

    }
}
