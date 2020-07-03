using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class PeoplePage : ContentView
    {
        public PeoplePage()
        {
            InitializeComponent();
        }
    }

    public class DisPeoplePage
    {
        public DisPeoplePage()
        {
            ViewList = new List<View>()
            {
                new PeoplePage()
            };
        }

        public IList<View> ViewList { get; set; }
    }
}
