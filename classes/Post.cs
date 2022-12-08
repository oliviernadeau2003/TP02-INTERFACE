using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.classes
{
    public class Post
    {
        public int UserId { get; set; }   // UserId ??
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }  //  DateTime ??
        public string Visibility { get; set; }

        public List<Comment> Comments { get; set; }


        public List<int> Like { get; set; }
        public List<int> Love { get; set; }
        public List<int> Sad { get; set; }
        public List<int> Angry { get; set; }
        public int Score { get; set; }  //  Value?        


    }
}
