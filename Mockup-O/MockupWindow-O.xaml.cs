
//https://cdn2.unrealengine.com/Diesel%2Fblog%2Fseptember-store-feature-update%2Fegs-library-listview-1529x951-6752ab6bc5d45b6dc2971959ec5ee018becea251.png

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using TP2.classes;
using TP2.Mockup_O.Classes;

namespace TP2.Mockup_O
{


    public partial class MockupWindow_O : Window
    {

        private List<Button> Navigations_Buttons;

        public MockupWindow_O()
        {

            InitializeComponent();
            moUser moUser = App.Current.moUsers[0];
            App.Current.moCurrentUser = moUser;
            App.Current.moCurrentUserId = App.Current.Users.FirstOrDefault(x => x.Value == App.Current.CurrentUser).Key;

            LoadIcons();
            LoadFilters();
            SetOpacity();
            Navigations_Buttons = LoadButton_list();
            RadioButtonListView.IsChecked = true;
            UserButton.Content = App.Current.moCurrentUser.Username;


            // Events Calls
            RadioButtonCoverView.Checked += RadioButtonCoverView_Checked;
            RadioButtonListView.Checked += RadioButtonListView_Checked;

            LoadGames();
        }

        // Events Functions

        private void ComboBoxOrderByList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void ComboBoxGenreList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void SearhBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void RadioButtonListView_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonListView.Opacity = 1;
            RadioButtonCoverView.Opacity = 0.5;
        }

        private void RadioButtonCoverView_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonCoverView.Opacity = 1;
            RadioButtonListView.Opacity = 0.5;
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
            //Window.GetWindow(this).DragMove();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
            ChangeOpacity(sender, e);
        }

        private void WindowStateButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized)
                this.WindowState = WindowState.Maximized;
            else
                this.WindowState = WindowState.Normal;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // ------------------------

        private void Update()
        {
            ProductsList?.Children.Clear();
            LoadGames();
        }


        private void LoadIcons()
        {
            Logo.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Epic_Games_logo.svg"));
            Logo.Width = 55;


            HomeIcon.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Home-Icon.png"));
            HomeIcon.Width = 35;

            StoreIcon.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Store-Icon.png"));
            StoreIcon.Width = 25;

            LibraryIcon.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Library-Icon.png"));
            LibraryIcon.Width = 35;

            FriendsIcon.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Friends-Icon.png"));
            FriendsIcon.Width = 25;

            UnrealEngineIcon.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Unreal-Engine-Icon.png"));
            UnrealEngineIcon.Width = 35;


            DownloadsIcon.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Downloads-Icon.png"));
            DownloadsIcon.Width = 25;

            SettingsIcon.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Settings-Icon.png"));
            SettingsIcon.Width = 25;

            UserIcon.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/User-Icon.png"));
            UserIcon.Width = 25;


            CoverView.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Library-Icon.png"));
            CoverView.Width = 30;

            ListView.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/List-Icon.png"));
            ListView.Width = 25;

            SearchIcon.Source = new BitmapImage(
            new Uri($"pack://application:,,,/TP2;component/Mockup-O/Assets/Icons/Search-Icon.png"));
            SearchIcon.Width = 25;

        }

        private void LoadFilters()
        {
            ComboBoxGenreList.Items.Add("All");
            foreach (var Genre in Enum.GetNames(typeof(App.ProductGenres)))
                ComboBoxGenreList.Items.Add(EnumParsing(Genre));
            foreach (var OrderBy in Enum.GetNames(typeof(App.OrderBy)))
                ComboBoxOrderByList.Items.Add(EnumParsing(OrderBy));

            ComboBoxGenreList.SelectedIndex = 0;
            ComboBoxOrderByList.SelectedIndex = 0;
        }

        private string EnumParsing(string @enum) => @enum.Replace('_', ' ');
        private App.ProductGenres StringParsingToEnum(string @enum) => (App.ProductGenres)Enum.Parse(typeof(App.ProductGenres), @enum.Replace(' ', '_'));

        private void SetOpacity()
        {
            RadioButtonCoverView.Opacity = 0.5;
            RadioButtonListView.Opacity = 1;

            HomeButton.Opacity = 0.5;
            StoreButton.Opacity = 0.5;
            LibraryButton.Opacity = 1;
            FriendsButton.Opacity = 0.5;
            UnrealEngineButton.Opacity = 0.5;

            DownloadButton.Opacity = 0.5;
            SettingsButton.Opacity = 0.5;
            UserButton.Opacity = 0.5;
        }

        private void ChangeOpacity(object sender, RoutedEventArgs e)
        {
            Button? Clicked_Button = sender as Button;
            Clicked_Button.Opacity = 1;
            foreach (Button button in Navigations_Buttons)
                if (button.Content != Clicked_Button.Content)
                    button.Opacity = 0.5;
        }

        private List<Button> LoadButton_list() => new() { HomeButton, StoreButton, LibraryButton, FriendsButton, UnrealEngineButton/*, DownloadButton, SettingsButton, UserButton*/ };

        private void LoadGames()
        {
            IEnumerable<Product> products = App.Current.Products.Values;

            products = Search(products);
            products = FilterByOrder(products);
            products = FilterByGenres(products);

            foreach (Product product in products)
            {
                ListViewUserControl listViewUserControl = new ListViewUserControl(product, this);
                ProductsList?.Children.Add(listViewUserControl);
            }
        }

        private IEnumerable<Product> FilterByOrder(IEnumerable<Product> products)
        {
            if (ComboBoxOrderByList.SelectedItem?.ToString() == EnumParsing(App.OrderBy.Alphabetical_A_Z.ToString()))
                products = products.OrderBy(x => x.Name).ThenBy(x => x.Size);
            if (ComboBoxOrderByList.SelectedItem?.ToString() == EnumParsing(App.OrderBy.Alphabetical_Z_A.ToString()))
                products = products.OrderByDescending(x => x.Name).ThenByDescending(x => x.Size); ;
            if (ComboBoxOrderByList.SelectedItem?.ToString() == EnumParsing(App.OrderBy.Size_ASC.ToString()))
                products = products.OrderBy(x => x.Size).ThenBy(x => x.Name);
            if (ComboBoxOrderByList.SelectedItem?.ToString() == EnumParsing(App.OrderBy.Size_DESC.ToString()))
                products = products.OrderByDescending(x => x.Size).ThenByDescending(x => x.Name);

            return products;
        }

        private IEnumerable<Product> FilterByGenres(IEnumerable<Product> products)
        {
            if (ComboBoxGenreList.SelectedItem is not null && ComboBoxGenreList.SelectedItem.ToString() != "All")
            {
                App.ProductGenres SelectedGenre = StringParsingToEnum(ComboBoxGenreList.SelectedItem?.ToString());
                products = products.Where(x => x.Genres.Contains(SelectedGenre));
            }
            return products;
        }

        private IEnumerable<Product> Search(IEnumerable<Product> products)
        {

            return products;
        }

    }
}
