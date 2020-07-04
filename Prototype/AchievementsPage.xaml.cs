using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class AchievementsPage : ContentView
    {
        public AchievementsPage()
        {
            InitializeComponent();
            BindingContext = new AchievementPageAchv();
        }
    }

    public class DisAchievementsPage
    {
        public DisAchievementsPage()
        {
            ViewList = new List<View>()
            {
                new AchievementsPage()
            };
        }

        public IList<View> ViewList { get; set; }
    }

    public class AchievementPageAchv
    {
        public AchievementPageAchv()
        {
            AchvPages = new List<View>()
            {
                new AchvProgress() ,new AchvPagePosts(), new AchvPageTotalScores()
            };
        }
        public IList<View> AchvPages { get; set; }
    }
}
