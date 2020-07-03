using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class SendUpload : ContentView
    {
        public SendUpload()
        {
            InitializeComponent();
            BindingContext = new SendUploadPages();
            SUList = new List<View>()
            {
                new SendUpload()
            };

        }
        public IList<View> SUList { get; set; }
    }
}
