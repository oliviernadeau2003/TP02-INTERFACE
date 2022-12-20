using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TP2.classes;

namespace TP2
{
    /// <summary>
    /// Logique d'interaction pour WallWindow.xaml
    /// </summary>
    public partial class WallWindow : Window
    {
        public WallWindow()
        {

            User user = App.Current.Users[1];
            App.Current.CurrentUser = user;
            App.Current.CurrentUserId = App.Current.Users.FirstOrDefault(x => x.Value == App.Current.CurrentUser).Key;

            InitializeComponent();
            LoadLoggedUserList();
            LoadViewPostOfList();

            // Click Events
            ComboBoxLoggedAs.SelectionChanged += ComboBoxLoggedAs_SelectionChanged;
            ComboBoxUserList.SelectionChanged += ComboBoxUserList_SelectionChanged;

            RadioButtonSortByDate.Checked += RadioButtonSortByDate_Checked;
            RadioButtonSortByPopularity.Checked += RadioButtonSortByPopularity_Checked;

            Update();
        }

        private void RadioButtonSortByPopularity_Checked(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void RadioButtonSortByDate_Checked(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void ComboBoxLoggedAs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User SelectedUser = (User)ComboBoxLoggedAs.SelectedItem;
            App.Current.CurrentUser = SelectedUser;
            App.Current.CurrentUserId = App.Current.Users.FirstOrDefault(x => x.Value == App.Current.CurrentUser).Key;

            Update();
        }

        private void ComboBoxUserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void LoadLoggedUserList()
        {
            foreach (var user in App.Current.Users.Values)
            {
                ComboBoxLoggedAs.Items.Add(user);
            }
        }

        private void LoadFriendsList()
        {
            List<int> FriendsId = App.Current.CurrentUser.FriendsIds;
            foreach (var friendId in FriendsId)
            {
                ListBoxFriendsList.Items.Add(App.Current.Users.FirstOrDefault(x => x.Key == friendId).Value);
            }
        }

        private void LoadViewPostOfList()
        {
            ComboBoxUserList.Items.Add("All users");
            ComboBoxUserList.Items.Add("Friends");
            foreach (var user in App.Current.Users.Values)
            {
                ComboBoxUserList.Items.Add(user);
            }
        }

        private void LoadFeed()
        {
            IEnumerable<Post> posts = App.Current.Posts.Values;
            List<int> FriendsId = App.Current.CurrentUser.FriendsIds;

            if ((bool)RadioButtonSortByDate.IsChecked)
            {
                posts = posts.OrderByDescending(x => x.Date);
            }
            else
            {
                posts= posts.OrderByDescending(x => x.Score);
            }

            if (ComboBoxUserList.SelectedItem == "Friends")
            {
                posts = posts.Where(x => FriendsId.Contains(x.UserId));
            } else if (ComboBoxUserList.SelectedItem != "All users")
            {
                int SelectedUserId = App.Current.Users.FirstOrDefault(x => x.Value == (User)ComboBoxUserList.SelectedItem).Key;
                posts = posts.Where(x => x.UserId == SelectedUserId);
            }


            foreach (var post in posts)
            {
                Wall_UserControl userControl = new(post, this);
                Feed.Children.Add(userControl);
            }

        }

        private void Update()
        {
            ListBoxFriendsList.Items.Clear();
            Feed.Children.Clear();

            UserProfilePicture.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Assets/Users/user{App.Current.CurrentUserId}.jpg"));
            UserName.Text = $"{App.Current.CurrentUser.FirstName} {App.Current.CurrentUser.LastName}";

            LoadFriendsList();
            LoadFeed();
        }
    }
}
