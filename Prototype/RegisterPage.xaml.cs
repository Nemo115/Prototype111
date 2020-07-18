using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        void RegisterButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Global.Signed = true;
            Application parentApp = (Application)this.Parent.Parent;
            parentApp.MainPage = new HomePage();
        }
    }
}