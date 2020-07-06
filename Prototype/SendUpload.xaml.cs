using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class SendUpload : ContentView
    {
        int i = 0;
        bool clicked;
        public SendUpload()
        {
            
            BindingContext = new SendUploadPages();
            

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
                UploadWindow.InputTransparent = false;
            }
            
            if (clicked == true && i == 2)
            {
                UploadWindow.IsVisible = false;
                UploadWindow.InputTransparent = true;
                clicked = false;
                i = 0;
                Upload.Source = ImageSource.FromResource("Prototype.assets.SendUpload.NavBar.UploadIcons.uploadIcon1-3x.png");
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
}
