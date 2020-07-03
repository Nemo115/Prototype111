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
}
