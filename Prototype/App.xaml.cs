using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;

namespace Prototype
{
    public partial class App : Application
    {
        /*
        public string GetBlob(string containerName, string fileName)
        {
            
            return contents;
        }
        */

        public App()
        {
            InitializeComponent();

            //MainPage = new PeoplePage();

            //MainPage = new SearchView();

            //MainPage = new HomePage();

            //MainPage = new AchievementsPage();

            //MainPage = new RecommendedTab();

            //MainPage = new SendUpload();

            //MainPage = new LoginPage();

            /*

            string connectionString = "DefaultEndpointsProtocol=https;AccountName=extractions;AccountKey=UE7maR5oz/OJbXkQyzr45zLT935vQ5CHztsTeXT+eqvicT7AZRRyCtVeMufkAzrNdk4M4wmXpKIaffX1jF9iWg==;EndpointSuffix=core.windows.net";

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);

            CloudBlobClient serviceClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = serviceClient.GetContainerReference("stuff");
            CloudBlockBlob blob = container.GetBlockBlobReference("verify");

            string contents = blob.DownloadTextAsync().Result;
            */

            if (Global.Signed == false)
            {
                MainPage = new NavigationPage(new MainPage());
            }
            else if (Global.Signed == true)
            {
                MainPage = new HomePage();
            }

            //*/

            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
    public static class Global
    {
        public static bool Signed;
        
    }
}
