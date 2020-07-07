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
            BindingContext = new SearchViewPages();
        }

        void BackArrow_Clicked(System.Object sender, System.EventArgs e)
        {
            FilterSelect.IsVisible = false;
            FilterSelect.InputTransparent = true;
            FilterButton.RotateTo(0, 200);
            FilterButton.Source = ImageSource.FromResource("Prototype.assets.Search.TopSearchTab.Filter.FilterIcons.FilterIcon3x.png");
        }

        void FilterButton_Clicked(System.Object sender, System.EventArgs e)
        {
            FilterButton.RotateTo(90, 200);
            FilterButton.Source = ImageSource.FromResource("Prototype.assets.Search.TopSearchTab.Filter.FilterIcons.FilterIconBOLD3x.png");
            FilterSelect.IsVisible = true;
            FilterSelect.InputTransparent = false;
            
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
    
    public class SearchViewPages
    {
        public SearchViewPages()
        {
            SearchList = new List<View>()
            {
                //new People, new Top, new Posts, new Drops
                new SearchPeopleTab(), new SearchTopTab(), new SearchPostsTab(), new SearchDropsTab()
            };
        }
        public IList<View> SearchList { get; set; }
    }
}
