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
        int i = 0;

        public PeoplePagePosts()
        {
            InitializeComponent();
            display();
        }

        async void display()
        {
            var blobList = await BlobStorageService.GetBlobs<CloudBlockBlob>("teststorage1");

            if (blobList != null)
            {
                NoPosts.IsVisible = false;
                var firstBlob = blobList?.FirstOrDefault();
                var photo = new PhotoModel { Title = firstBlob?.Name, Uri = firstBlob?.Uri };

                string description = photo?.Title;
                const string V = "!&%#%#&!";
                //string[] des = description.Split(V.ToCharArray());
                post0.Source = ImageSource.FromUri(photo?.Uri);
                foreach (var post in blobList)
                {
                    photoGrid.Children.Add(new Image
                    {
                        Source = ImageSource.FromUri(photo?.Uri)
                    });
                }
            }
            else
            {
                NoPosts.IsVisible = true;
            }
        }
    }
}
