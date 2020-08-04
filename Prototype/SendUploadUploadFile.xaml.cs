using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Prototype;

namespace Prototype
{
    public partial class SendUploadUploadFile : ContentView
    {
        public SendUploadUploadFile()
        {
            InitializeComponent();
        }

        public async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }

            (sender as Button).IsEnabled = true;
        }
    }
}
