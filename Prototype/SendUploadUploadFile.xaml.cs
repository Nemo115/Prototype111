using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Prototype;
using Plugin.Media.Abstractions;
using Plugin.Media;
using System.Diagnostics;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure;

namespace Prototype
{
    public partial class SendUploadUploadFile : ContentView
    {
        private MediaFile mediaFile;
        Stream stream;

        public SendUploadUploadFile()
        {
            InitializeComponent();
        }

        public async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            /*
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                //await DisplayAlert("Error", "Cannot Pick Photo from Library", "OK");
                return;
            }
            else
            {
                var mediaOption = new PickMediaOptions()
                {
                    PhotoSize = PhotoSize.Medium
                };
                mediaFile = await CrossMedia.Current.PickPhotoAsync();
                if (mediaFile == null)
                {
                    return;
                }
                image.Source = ImageSource.FromStream(() => mediaFile.GetStream());
            }
            */

            ///*
            (sender as Button).IsEnabled = false;

            stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }
            
            (sender as Button).IsEnabled = true;
            ///*/
        }

        public async void UploadFileButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Upload(stream);
        }

        public async void Upload(Stream s)
        {
            var account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=dropvoteprototype;AccountKey=3q4b3dn686HyF4jzTpRh/6cbuu8K6MNkXLgTC5kqabqlz0d6UOl9g60QjdjQszXkGM/DwEugjBP/LzC8rjN2DA==;EndpointSuffix=core.windows.net");
            var client = account.CreateCloudBlobClient();
            var container = client.GetContainerReference("teststorage1");
            await container.CreateIfNotExistsAsync();
            var name = Guid.NewGuid().ToString();
            var blockBlob = container.GetBlockBlobReference($"{name}.png");
            await blockBlob.UploadFromStreamAsync(s);
            //URL = blockBlob.Uri.OriginalString;
            //UploadedUrl.Text = URL;
        }
    }
}
