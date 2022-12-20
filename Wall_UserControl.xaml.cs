using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TP2.classes;

namespace TP2
{
    /// <summary>
    /// Logique d'interaction pour Wall_UserControl.xaml
    /// </summary>
    public partial class Wall_UserControl : UserControl
    {
        private Post Post;
        private WallWindow WallWindow;
        private int CurrentUserId;

        public Wall_UserControl(Post post, WallWindow wallWindow)
        {
            InitializeComponent();
            Post = post;
            WallWindow = wallWindow;
            List<User> UsersList = App.Current.Users.Values.ToList();
            App.Current.CurrentUserId = App.Current.Users.FirstOrDefault(x => x.Value == App.Current.CurrentUser).Key;

            //----------

            UserProfilePicture.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Assets/Users/user{post.UserId}.jpg"));

            UserName.Text = UsersList[post.UserId - 1].FirstName + " " + UsersList[post.UserId - 1].LastName;

            DateTime PostDate = DateTime.Parse(post.Date);
            TimeSincePost.Text = $"{(DateTime.Now.Date - PostDate.Date).Days}d";

            PostContent.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Assets/Posts/{post.Image}"));

            Title.Text = post.Title;

            DateTime postDate = DateTime.Parse(post.Date);
            Date.Text = $"{postDate:MMMM} {postDate.Day} at {postDate.Hour}:{postDate.Minute.ToString("00")}";

            Description.Text = post.Description;

            //----- Reactions ------

            nbOfLike.Text = $"{Post.Like.Count()}";
            nbOfLove.Text = $"{Post.Love.Count()}";
            nbOfSad.Text = $"{Post.Sad.Count()}";
            nbOfAngry.Text = $"{Post.Angry.Count()}";

            //----------

            // Click Events

            ButtonLike.Click += ButtonLike_Click;
            ButtonLove.Click += ButtonLove_Click;
            ButtonSad.Click += ButtonSad_Click;
            ButtonAngry.Click += ButtonAngry_Click;

        }
        private void ButtonLike_Click(object sender, RoutedEventArgs e)
        {
            if (Post.Like.Contains(CurrentUserId))
                Post.Like.Remove(CurrentUserId);
            else
                Post.Like.Add(CurrentUserId);

            if (Post.Love.Contains(CurrentUserId))
                Post.Love.Remove(CurrentUserId);

            if (Post.Sad.Contains(CurrentUserId))
                Post.Sad.Remove(CurrentUserId);

            if (Post.Angry.Contains(CurrentUserId))
                Post.Angry.Remove(CurrentUserId);

            nbOfLike.Text = $"{Post.Like.Count()}";
            nbOfLove.Text = $"{Post.Love.Count()}";
            nbOfSad.Text = $"{Post.Sad.Count()}";
            nbOfAngry.Text = $"{Post.Angry.Count()}";
        }
        private void ButtonLove_Click(object sender, RoutedEventArgs e)
        {
            if (Post.Love.Contains(CurrentUserId))
                Post.Love.Remove(CurrentUserId);
            else
                Post.Love.Add(CurrentUserId);

            if (Post.Like.Contains(CurrentUserId))
                Post.Like.Remove(CurrentUserId);

            if (Post.Sad.Contains(CurrentUserId))
                Post.Sad.Remove(CurrentUserId);

            if (Post.Angry.Contains(CurrentUserId))
                Post.Angry.Remove(CurrentUserId);

            nbOfLike.Text = $"{Post.Like.Count()}";
            nbOfLove.Text = $"{Post.Love.Count()}";
            nbOfSad.Text = $"{Post.Sad.Count()}";
            nbOfAngry.Text = $"{Post.Angry.Count()}";
        }
        private void ButtonSad_Click(object sender, RoutedEventArgs e)
        {
            if (Post.Sad.Contains(CurrentUserId))
                Post.Sad.Remove(CurrentUserId);
            else
                Post.Sad.Add(CurrentUserId);

            if (Post.Like.Contains(CurrentUserId))
                Post.Like.Remove(CurrentUserId);

            if (Post.Love.Contains(CurrentUserId))
                Post.Love.Remove(CurrentUserId);

            if (Post.Angry.Contains(CurrentUserId))
                Post.Angry.Remove(CurrentUserId);

            nbOfLike.Text = $"{Post.Like.Count()}";
            nbOfLove.Text = $"{Post.Love.Count()}";
            nbOfSad.Text = $"{Post.Sad.Count()}";
            nbOfAngry.Text = $"{Post.Angry.Count()}";
        }

        private void ButtonAngry_Click(object sender, RoutedEventArgs e)
        {
            if (Post.Angry.Contains(CurrentUserId))
                Post.Angry.Remove(CurrentUserId);
            else
                Post.Angry.Add(CurrentUserId);

            if (Post.Like.Contains(CurrentUserId))
                Post.Like.Remove(CurrentUserId);

            if (Post.Love.Contains(CurrentUserId))
                Post.Love.Remove(CurrentUserId);

            if (Post.Sad.Contains(CurrentUserId))
                Post.Sad.Remove(CurrentUserId);

            nbOfLike.Text = $"{Post.Like.Count()}";
            nbOfLove.Text = $"{Post.Love.Count()}";
            nbOfSad.Text = $"{Post.Sad.Count()}";
            nbOfAngry.Text = $"{Post.Angry.Count()}";
        }

    }
}
