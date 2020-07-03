using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Prototype
{
    public partial class RecommendedTab : ContentView
    {
        public RecommendedTab()
        {
            InitializeComponent();
        }
    }
    public class DisRecommendedTab
    {
        public DisRecommendedTab()
        {
            ViewList = new List<View>()
            {
                new RecommendedTab()
            };
        }
        public IList<View> ViewList { get; set; }
    }
}
