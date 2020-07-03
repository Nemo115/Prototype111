﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            //SearchView.IsVisible = false;

            BindingContext = new Pages();
        }

        
        
        
        void FriendsButton_Clicked(System.Object sender, System.EventArgs e)
        {
            FriendsButton.ImageSource =  ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.FriendsIcon.friendiconBOLD2x.jpg");

            Achievements.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.TrophyIcons.trophyicon2x.jpg");
            Home.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.HomeIcons.HomeIcon2x.jpg");
            Create.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.UploadIcons.uploadicon2x.jpg");
            Search.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.SearchIcons.searchicon2x.jpg");

            BindingContext = new PeoplePage();
        }

        void Achievements_Clicked(System.Object sender, System.EventArgs e)
        {
            Achievements.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.TrophyIcons.trophyiconBOLD2x.jpg");

            Home.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.HomeIcons.HomeIcon2x.jpg");
            Create.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.UploadIcons.uploadicon2x.jpg");
            Search.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.SearchIcons.searchicon2x.jpg");
            FriendsButton.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.FriendsIcon.friendIcon2x.jpg");

            BindingContext = new AchievementsPage();
        }

        void Home_Clicked(System.Object sender, System.EventArgs e)
        {
            Home.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.HomeIcons.HomeIconBOLD2x.jpg");

            Achievements.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.TrophyIcons.trophyicon2x.jpg");
            Create.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.UploadIcons.uploadicon2x.jpg");
            Search.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.SearchIcons.searchicon2x.jpg");
            FriendsButton.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.FriendsIcon.friendIcon2x.jpg");

            BindingContext = new Pages();
        }

        void Create_Clicked(System.Object sender, System.EventArgs e)
        {
            Create.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.UploadIcons.uploadiconBOLD2x.jpg");

            Achievements.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.TrophyIcons.trophyicon2x.jpg");
            Home.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.HomeIcons.HomeIcon2x.jpg");
            Search.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.SearchIcons.searchicon2x.jpg");
            FriendsButton.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.FriendsIcon.friendIcon2x.jpg");

            BindingContext = new SendUpload();
            ViewX.ItemsSource = SUList;

            NavigationBar.IsVisible = false;
        }

        void Search_Clicked(System.Object sender, System.EventArgs e)
        {
            Search.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.SearchIcons.searchiconBOLD2x.jpg");

            Achievements.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.TrophyIcons.trophyicon2x.jpg");
            Home.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.HomeIcons.HomeIcon2x.jpg");
            Create.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.UploadIcons.uploadicon2x.jpg");
            FriendsButton.ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.RemoteBar.FriendsIcon.friendIcon2x.jpg");

            BindingContext = new SearchView();
        }

        

        void Swiped(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Up:
                    RemoteBar.TranslateTo(0, 70);
                    NavigationBar.TranslateTo(0, -60);
                    RemoteBar.FadeTo(0, 150);
                    NavigationBar.FadeTo(0, 150);
                    break;
                case SwipeDirection.Down:
                    RemoteBar.TranslateTo(0,0);
                    NavigationBar.TranslateTo(0,0);
                    RemoteBar.FadeTo(1, 150);
                    NavigationBar.FadeTo(1, 150);
                    break;
            }
        }
    }
}