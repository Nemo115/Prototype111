using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using Prototype.data;
using System.IO;
using SQLite;

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

            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbPath);

            var SignInQuery = db.Table<RegistrationTable>().Where(u => u.SignedIn.Equals(true)).FirstOrDefault();

            if (SignInQuery != null)
            {
                MainPage = new HomePage();
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }
            /*
            

            if (RegistrationTable.SignedIn == true)
            {
                MainPage = new HomePage();
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }

            

            */

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
