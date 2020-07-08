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

        void PPSwiped(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Up:

                    ProfileBar.TranslateTo(0, -60);

                    ProfileBar.FadeTo(0, 150);
                    break;
                case SwipeDirection.Down:

                    ProfileBar.TranslateTo(0, 0);

                    ProfileBar.FadeTo(1, 150);
                    break;
            }
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
                new PeoplePagePosts(), new PeoplePageActivity()
            };
        }

        public IList<View> PPList { get; set; }
    }
}
