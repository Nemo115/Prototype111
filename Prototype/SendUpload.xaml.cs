using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class SendUpload : ContentView
    {
        public SendUpload()
        {
            
            BindingContext = new SendUploadPages();
            

            InitializeComponent();
        }

        void Upload_Clicked(System.Object sender, System.EventArgs e)
        {
            Upload.Source = ImageSource.FromResource("Prototype.assets.SendUpload.NavBar.UploadIcons.uploadIcon3x.png");
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
