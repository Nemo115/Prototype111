﻿using System;
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
