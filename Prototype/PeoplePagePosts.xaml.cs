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
        int columnI = 0;
        int rowI = 0;

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
                
                //string description = photo?.Title;
                //const string V = "!&%#%#&!";
                //string[] des = description.Split(V.ToCharArray());
                //post0.Source = ImageSource.FromUri(photo?.Uri);

                foreach (var post in blobList)
                {
                    var aBlob = post;
                    var photo = new PhotoModel { Title = aBlob?.Name, Uri = aBlob?.Uri };

                    photoGrid.Children.Add(new Image
                    {
                        Source = ImageSource.FromUri(photo?.Uri)
                    }, columnI, rowI);

                    columnI++;

                    if (columnI == 3)
                    {
                        columnI = 0;
                        rowI++;
                    }
                }
            }
            else
            {
                NoPosts.IsVisible = true;
            }
        }
    }
}
