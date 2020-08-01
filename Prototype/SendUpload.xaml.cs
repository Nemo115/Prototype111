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
            if (ChooseWindow.IsVisible == false && ChooseWindow.InputTransparent == true)
            {
                ChooseWindow.IsVisible = true;
                ChooseWindow.InputTransparent = false;
            }
            else if (ChooseWindow.IsVisible == true && ChooseWindow.InputTransparent == true)
            {

                ChooseWindow.IsVisible = false;
                ChooseWindow.InputTransparent = true;
            }
        }

        void CameraUpload_Clicked(System.Object sender, System.EventArgs e)
        {
            if (ChooseWindow.IsVisible == false && ChooseWindow.InputTransparent == true)
            {
                ChooseWindow.IsVisible = true;
                ChooseWindow.InputTransparent = false;
            }
            else if (ChooseWindow.IsVisible == true && ChooseWindow.InputTransparent == true)
            {
                ChooseWindow.IsVisible = false;
                ChooseWindow.InputTransparent = true;
            }
        }

        void NewDrop_Clicked(System.Object sender, System.EventArgs e)
        {
            UploadWindow.IsVisible = false;
            UploadWindow.InputTransparent = true;

            Upload.IsVisible = false;
            Upload.InputTransparent = true;

            BackArrow.IsVisible = true;
            BackArrow.InputTransparent = false;

            OrangeLine.IsVisible = false;
            BlueLine.IsVisible = false;

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

        void BackArrow_Clicked(System.Object sender, System.EventArgs e)
        {
            Upload.IsVisible = true;
            Upload.InputTransparent = false;
            Upload.Source = ImageSource.FromResource("Prototype.assets.SendUpload.NavBar.UploadIcons.uploadIcon1-3x.png");

            BackArrow.IsVisible = false;
            BackArrow.InputTransparent = true;

            OrangeLine.IsVisible = true;
            BlueLine.IsVisible = true;

            BindingContext = new SendUploadPages();
        }

        void UploadButton_Clicked(System.Object sender, System.EventArgs e)
        {
            UploadWindow.IsVisible = false;
            UploadWindow.InputTransparent = true;

            Upload.IsVisible = false;
            Upload.InputTransparent = true;

            BackArrow.IsVisible = true;
            BackArrow.InputTransparent = false;

            OrangeLine.IsVisible = false;
            BlueLine.IsVisible = false;

            BindingContext = new UploadFiles();
        }

        void CheckBox_CheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            if (DropCheck.IsChecked == true)
            {
                UploadButton.IsVisible = true;
                UploadButton.InputTransparent = false;
            }
            else if (DropCheck.IsChecked == false)
            {
                UploadButton.IsVisible = false;
                UploadButton.InputTransparent = true;
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

    public class UploadFiles
    {
        public UploadFiles()
        {
            UploadFileList = new List<View>()
            {
                new SendUploadUploadFile()
            };
        }
        public IList<View> UploadFileList { get; set; }
    }
}
