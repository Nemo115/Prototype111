using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype
{
    public partial class App : Application
    {
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

            ///*

            if (Global.Signed == true)
            {
                MainPage = new HomePage();
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
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
