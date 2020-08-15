using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;
using Xamarin.Forms;

namespace Prototype
{
    public partial class PeoplePagePosts : ContentView
    {
        public PeoplePagePosts()
        {
            InitializeComponent();
            display();
        }

        async void display()
        {
            var blobList = await BlobStorageService.GetBlobs<CloudBlockBlob>("teststorage1");

            var firstBlob = blobList?.FirstOrDefault();
            var photo = new PhotoModel { Title = firstBlob?.Name, Uri = firstBlob?.Uri };
            
            string description = photo?.Title;
            const string V = "!&%#%#&!";
            //string[] des = description.Split(V.ToCharArray());
            post0.Source = ImageSource.FromUri(photo?.Uri);
        }
    }
}
