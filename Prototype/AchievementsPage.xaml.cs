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
        void AchvSwipe(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Up:

                    TopNavigationBar.TranslateTo(0, -60);

                    TopNavigationBar.FadeTo(0, 150);
                    break;
                case SwipeDirection.Down:

                    TopNavigationBar.TranslateTo(0, 0);

                    TopNavigationBar.FadeTo(1, 150);
                    break;
            }
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
                new AchvPagePosts(), new AchvProgress(), new AchvPageTotalScores()
            };
        }
        public IList<View> AchvPages { get; set; }
    }
}
