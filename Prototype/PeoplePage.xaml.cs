using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SQLite;
using Prototype.data;
using System.IO;

namespace Prototype
{
    public partial class PeoplePage : ContentView
    {
        public PeoplePage()
        {
            InitializeComponent();
            BindingContext = new PeoplePages();
            sync();
        }

        private async void sync()
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            //var myquery = db.Table<RegistrationTable>().Where(u => u.UserName.Equals(UsernameInput.Text) && u.Password.Equals(PasswordInput.Text)).FirstOrDefault();

            var a = db.Table<RegistrationTable>().FirstOrDefault();
            string user = a.UserName;

            UserName1.Text = user;
        }

        void PPSwiped(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Up:

                    ProfileBar.TranslateTo(0, -60);

                    ProfileBar.FadeTo(0, 150);
                    break;
                case SwipeDirection.Down:

                    ProfileBar.TranslateTo(0, 0);

                    ProfileBar.FadeTo(1, 150);
                    break;
            }
        }
        void changeScenes()
        {
            if (ProfileBar.IsVisible == false && ProfileBar.InputTransparent == true && CustomizeView.IsVisible == true && CustomizeView.InputTransparent == false)
            {
                ProfileBar.IsVisible = true;
                ProfileBar.InputTransparent = false;

                CustomizeView.IsVisible = false;
                CustomizeView.InputTransparent = true;
            }
            else if (ProfileBar.IsVisible == true && ProfileBar.InputTransparent == false && CustomizeView.IsVisible == false && CustomizeView.InputTransparent == true)
            {
                ProfileBar.IsVisible = false;
                ProfileBar.InputTransparent = true;

                CustomizeView.IsVisible = true;
                CustomizeView.InputTransparent = false;
            }
        }
        void ProfileSettings_Clicked(System.Object sender, System.EventArgs e)
        {
            changeScenes();

            BindingContext = new PeoplePageCustomize();
        }

        void BackButton_Clicked(System.Object sender, System.EventArgs e)
        {
            changeScenes();

            BindingContext = new PeoplePages();
        }
    }

    public class DisPeoplePage
    {
        public DisPeoplePage()
        {
            ViewList = new List<View>()
            {
                new PeoplePage()
            };
        }

        public IList<View> ViewList { get; set; }
    }

    public class PeoplePages
    {
        public PeoplePages()
        {
            PPList = new List<View>()
            {
                new PeoplePagePosts(), new PeoplePageActivity()
            };
        }

        public IList<View> PPList { get; set; }
    }

    public class PeoplePageCustomize
    {
        public PeoplePageCustomize()
        {
            PPList = new List<View>()
            {
                new PeoplePageCustomizePage()
            };
        }

        public IList<View> PPList { get; set; }
    }
}
