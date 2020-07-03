using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class SearchView : ContentView
    {
        public SearchView()
        {
            InitializeComponent();
        }
    }

    public class DisSearchView
    {
        public DisSearchView()
        {
            ViewList = new List<View>()
            {
                new SearchView()
            };
        }
        public IList<View> ViewList { get; set; }
    }
}
