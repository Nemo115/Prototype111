using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Plugin.Media.Abstractions;
using Plugin.Media;
using System.IO;
using SQLite;
using Prototype.data;

namespace Prototype
{
    public partial class PeoplePageCustomizePage : ContentView
    {
        public MediaFile profilePic;

        public PeoplePageCustomizePage()
        {
            InitializeComponent();
        }

        async void ChangeProfilePic_Clicked(System.Object sender, System.EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                return;
            }
            else
            {
                var mediaOption = new PickMediaOptions()
                {
                    PhotoSize = PhotoSize.Medium
                };
                profilePic = await CrossMedia.Current.PickPhotoAsync();
                if (profilePic == null)
                {
                    return;
                }

                profileImage.Source = ImageSource.FromStream(() => profilePic.GetStream());
            }
        }

        void SaveChangesButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var a = db.Table<RegistrationTable>().FirstOrDefault();

            a.ProfilePic = profilePic;
            a.ProfilePicture = profileImage;
        }
    }
}
