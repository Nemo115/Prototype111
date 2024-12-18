﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype
{
    public partial class SearchView : ContentView
    {
        public SearchView()
        {
            InitializeComponent();
            BindingContext = new SearchViewPages();
        }
        
        void Top_Clicked(System.Object sender, System.EventArgs e)
        {
            SearchCarousel.Position = 1;
        }

        void People_Clicked(System.Object sender, System.EventArgs e)
        {
            SearchCarousel.Position = 0;
        }

        void Posts_Clicked(System.Object sender, System.EventArgs e)
        {
            SearchCarousel.Position = 2;
        }

        void Drops_Clicked(System.Object sender, System.EventArgs e)
        {
            SearchCarousel.Position = 3;
        }

        void BackArrow_Clicked(System.Object sender, System.EventArgs e)
        {
            FilterSelect.FadeTo(0, 300);
            FilterSelect.IsVisible = false;
            FilterSelect.InputTransparent = true;
            FilterButton.RotateTo(0, 200);
            FilterButton.Source = ImageSource.FromResource("Prototype.assets.Search.TopSearchTab.Filter.FilterIcons.FilterIcon3x.png");
        }

        void FilterButton_Clicked(System.Object sender, System.EventArgs e)
        {
            FilterButton.RotateTo(90, 200);
            FilterButton.Source = ImageSource.FromResource("Prototype.assets.Search.TopSearchTab.Filter.FilterIcons.FilterIconBOLD3x.png");
            FilterSelect.FadeTo(1, 200);
            FilterSelect.IsVisible = true;
            FilterSelect.InputTransparent = false;
        }

        void SearchCarousel_PositionChanged(System.Object sender, Xamarin.Forms.PositionChangedEventArgs e)
        {
            switch (e.CurrentPosition)
            {
                case 0:
                    PeopleT.TextColor = Color.FromHex("#00BCCF");
                    TopT.TextColor = Color.FromHex("#FF8E5B");
                    PostsT.TextColor = Color.FromHex("#FF8E5B");
                    DropsT.TextColor = Color.FromHex("#FF8E5B");

                    Top.TextColor = Color.FromHex("#FF8E5B");
                    People.TextColor = Color.FromHex("#00BCCF");
                    Posts.TextColor = Color.FromHex("#FF8E5B");
                    Drops.TextColor = Color.FromHex("#FF8E5B");
                    break;
                case 1:
                    PeopleT.TextColor = Color.FromHex("#FF8E5B");
                    TopT.TextColor = Color.FromHex("#00BCCF");
                    PostsT.TextColor = Color.FromHex("#FF8E5B");
                    DropsT.TextColor = Color.FromHex("#FF8E5B");

                    Top.TextColor = Color.FromHex("#00BCCF");
                    People.TextColor = Color.FromHex("#FF8E5B");
                    Posts.TextColor = Color.FromHex("#FF8E5B");
                    Drops.TextColor = Color.FromHex("#FF8E5B");
                    break;
                case 2:
                    PeopleT.TextColor = Color.FromHex("#FF8E5B");
                    TopT.TextColor = Color.FromHex("#FF8E5B");
                    PostsT.TextColor = Color.FromHex("#00BCCF");
                    DropsT.TextColor = Color.FromHex("#FF8E5B");

                    Top.TextColor = Color.FromHex("#FF8E5B");
                    People.TextColor = Color.FromHex("#FF8E5B");
                    Posts.TextColor = Color.FromHex("#00BCCF");
                    Drops.TextColor = Color.FromHex("#FF8E5B");
                    break;
                case 3:
                    PeopleT.TextColor = Color.FromHex("#FF8E5B");
                    TopT.TextColor = Color.FromHex("#FF8E5B");
                    PostsT.TextColor = Color.FromHex("#FF8E5B");
                    DropsT.TextColor = Color.FromHex("#00BCCF");

                    Top.TextColor = Color.FromHex("#FF8E5B");
                    People.TextColor = Color.FromHex("#FF8E5B");
                    Posts.TextColor = Color.FromHex("#FF8E5B");
                    Drops.TextColor = Color.FromHex("#00BCCF");
                    break;
            }
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