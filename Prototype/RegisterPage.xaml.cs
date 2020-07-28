using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using System.IO;
using SQLite;
using Prototype.data;

namespace Prototype
{
    public partial class RegisterPage : ContentPage
    {
        /*
        public readonly string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=extractions;AccountKey=UE7maR5oz/OJbXkQyzr45zLT935vQ5CHztsTeXT+eqvicT7AZRRyCtVeMufkAzrNdk4M4wmXpKIaffX1jF9iWg==;EndpointSuffix=core.windows.net";
        public readonly CloudBlobClient client;
        */

        public RegisterPage()
        {
            InitializeComponent();
            /*
            var account = CloudStorageAccount.Parse(ConnectionString);
            client = account.CreateCloudBlobClient();
            */
        }

        void RegisterButton_Clicked(System.Object sender, System.EventArgs e)
        {

            if (PasswordInp.Text == ConfPasswordInp.Text)
            {
                Global.Signed = true;
                var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                db.CreateTable<RegistrationTable>();

                var item = new RegistrationTable()
                {
                    UserName = UsernameInp.Text,
                    Email = EmailInp.Text,
                    Password = PasswordInp.Text,
                    PhoneNumber = PhoneNumInp.Text,
                    SignedIn = true
                };

                db.Insert(item);
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Congratulations", "Account Registration Successful", "Ok", "Cancel");

                    if (result)
                    {
                        Application parentApp = (Application)this.Parent.Parent;
                        parentApp.MainPage = new HomePage();
                    }

                }
                );
            }

            else
            {
                uint timeout = 50;

                RegisterButton.TranslateTo(-15, 0, timeout);
                RegisterButton.TranslateTo(15, 0, timeout);
                RegisterButton.TranslateTo(-10, 0, timeout);
                RegisterButton.TranslateTo(10, 0, timeout);
                RegisterButton.TranslateTo(-5, 0, timeout);
                RegisterButton.TranslateTo(5, 0, timeout);

                RegisterButton.TranslationX = 0;
            }

            /*
            string container = "stuff";
            string blobTitle = "verify";
            string verify = "true";

            var blobContainer = client.GetContainerReference(container);
            var blockBlob = blobContainer.GetBlockBlobReference(blobTitle);
            blockBlob.UploadTextAsync(verify);
            */
        }
    }
}