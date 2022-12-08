using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TP2.classes
{
    public class Comment
    {

        public int UserId { get; set; }
        public string Text { get; set; }    //  Content plutôt ??
        public string Image { get; set; }   // Optional

        public List<int> Like { get; set; }
        public List<int> Love { get; set; }
        public List<int> Sad { get; set; }
        public List<int> Angry { get; set; }

    }
}
