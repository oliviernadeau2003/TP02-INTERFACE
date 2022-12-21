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
        public int Score { get { return GetScrore(); } }

        private int GetScrore()
        {
            int Score = 0;
            Score += Like.Count() * 3;
            Score += Love.Count() * 5;
            Score += Sad.Count();
            Score += Angry.Count();
            return Score;
        }

        public void ChangeVisibility(string visibility)
        {
            Visibility = visibility;
        }

        public void AddComment(int userId, string content, string image = "")
        {
            Comment newComment = new() { UserId = userId, Text = content, Image = image };
            Comments.Add(newComment);
        }

        public void React() { }     // Ca se ferait pas plutot dans le userControl/Modele du comment ??
        

    }
}
