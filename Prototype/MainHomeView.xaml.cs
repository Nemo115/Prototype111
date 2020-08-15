using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Storage.Blob;
using Prototype;
using Xamarin.Forms;

namespace Prototype
{
    public partial class MainHomeView : ContentView
    {
        

        public MainHomeView()
        {
            InitializeComponent();
        }

        /*public async void Appearing()
        {
            var blobList = await BlobStorageService.GetBlobs<CloudBlockBlob>("Photos");

            var firstBlob = blobList?.FirstOrDefault();
            var photo = new PhotoModel {Title = firstBlob?.Name, Uri = firstBlob?.Uri };

            DescriptionT.Text = photo?.Title;
            PostImage.Source = ImageSource.FromUri(photo?.Uri);


        } */

        async void DropVote_Clicked(System.Object sender, System.EventArgs e)
        {
            var blobList = await BlobStorageService.GetBlobs<CloudBlockBlob>("teststorage1");

            var firstBlob = blobList?.FirstOrDefault();
            var photo = new PhotoModel { Title = firstBlob?.Name, Uri = firstBlob?.Uri };

            string description = photo?.Title;
            const string V = "!&%#%#&!";
            string[] des = description.Split(V.ToCharArray());
            DescriptionT.Text = des[0];
            PostImage.Source = ImageSource.FromUri(photo?.Uri);
        }
    }
}