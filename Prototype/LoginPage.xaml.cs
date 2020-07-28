using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prototype.data;

namespace Prototype
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void LoginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegistrationTable>().Where(u => u.UserName.Equals(UsernameInput.Text) && u.Password.Equals(PasswordInput.Text)).FirstOrDefault();

            if (myquery != null)
            {
                Application parentApp = (Application)this.Parent.Parent;
                parentApp.MainPage = new HomePage();
            }
            else
            {
                uint timeout = 50;

                LoginButton.TranslateTo(-15,0,timeout);
                LoginButton.TranslateTo(15, 0, timeout);
                LoginButton.TranslateTo(-10, 0, timeout);
                LoginButton.TranslateTo(10, 0, timeout);
                LoginButton.TranslateTo(-5, 0, timeout);
                LoginButton.TranslateTo(5, 0, timeout);
                LoginButton.TranslationX = 0;
            }
            
        }
    }
}