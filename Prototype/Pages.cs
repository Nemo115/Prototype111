using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Prototype
{
    public class Pages
    {
        public Pages()
        {
            ViewList = new List<View>()
            {
                //put recomended and activity pages here
                new RecentActivity() ,new MainHomeView(), new RecommendedTab()
            };
        }

        public IList<View> ViewList { get; set; }
    }
}
