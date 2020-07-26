using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Prototype
{
    public partial class PeoplePageActivity : ContentView
    {
        public PeoplePageActivity()
        {
            InitializeComponent();
            NoActivity.IsVisible = true;
            NoActivity.InputTransparent = false;
        }
    }
}
