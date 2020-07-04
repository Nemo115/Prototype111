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
            BindingContext = new PeoplePages();
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

    public class PeoplePages
    {
        public PeoplePages()
        {
            PPList = new List<View>()
            {
                new PeoplePagePosts()
            };
        }

        public IList<View> PPList { get; set; }
    }
}
