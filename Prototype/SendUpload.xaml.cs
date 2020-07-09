using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class SendUpload : ContentView
    {
        int i = 0;
        bool clicked = false;


        public SendUpload()
        {

            BindingContext = new SendUploadPages();

            //BindingContext = new CreateNewDrop();

            InitializeComponent();
        }

        void Upload_Clicked(System.Object sender, System.EventArgs e)
        {
            Upload.Source = ImageSource.FromResource("Prototype.assets.SendUpload.NavBar.UploadIcons.uploadIcon3x.png");
            clicked = true;
            i++;
            if (clicked == true)
            {
                
                UploadWindow.IsVisible = true;
                UploadWindow.FadeTo(1, 200);
                UploadWindow.InputTransparent = false;
            }
            if (clicked == true && i == 2)
            {
                UploadWindow.FadeTo(0, 300);

                UploadWindow.IsVisible = false;
                UploadWindow.InputTransparent = true;
                
                clicked = false;
                i = 0;
                Upload.Source = ImageSource.FromResource("Prototype.assets.SendUpload.NavBar.UploadIcons.uploadIcon1-3x.png");
            }
        }

        void TextUpload_Clicked(System.Object sender, System.EventArgs e)
        {
            ChooseWindow.IsVisible = true;
            ChooseWindow.InputTransparent = false;
        }

        void CameraUpload_Clicked(System.Object sender, System.EventArgs e)
        {
            ChooseWindow.IsVisible = true;
            ChooseWindow.InputTransparent = false;
        }

        void NewDrop_Clicked(System.Object sender, System.EventArgs e)
        {
            BindingContext = new CreateNewDrop();
        }

        void SUSwiped(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Up:
                    
                    NavBar.TranslateTo(0, -60);
                    
                    NavBar.FadeTo(0, 150);
                    break;
                case SwipeDirection.Down:
                    
                    NavBar.TranslateTo(0, 0);
                    
                    NavBar.FadeTo(1, 150);
                    break;
            }
        }

    }

    public class DisSendUpload
    {
        public DisSendUpload()
        {
            ViewList = new List<View>()
            {
                new SendUpload()
            };
        }
        public IList<View> ViewList { get; set; }
    }

    public class CreateNewDrop
    {
        public CreateNewDrop()
        {
            SendUploadList = new List<View>()
            {
                new SendUploadCreateDrop()
            };

        }
        public IList<View> SendUploadList { get; set; }
    }
}
