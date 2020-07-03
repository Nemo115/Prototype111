using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class SendUpload : ContentView
    {
        public SendUpload()
        {
            
            BindingContext = new SendUploadPages();
            

            InitializeComponent();
        }
        
    }

    public class DisSendUpload
    {
        public DisSendUpload()
        {
            ViewList = new List<View>()
            {
                new SendUpload()
            };
        }
        public IList<View> ViewList { get; set; }
    }
}
