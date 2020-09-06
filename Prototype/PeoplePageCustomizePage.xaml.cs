using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Plugin.Media.Abstractions;
using Plugin.Media;

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
                    PhotoSize = PhotoSize.Medium;
                }
            }
        }
    }
}
