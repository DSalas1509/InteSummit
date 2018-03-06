using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            MainPage = new NavigationPage(new RootPage());

            BottomBarPage bottomBarPage = new BottomBarPage();

            //MainPage = new BarPage();


            string[] tabTitles = { "Favorites", "Friends", "Nearby", "Recents", "Restaurants" };
            string[] tabColors = { null, "#5D4037", "#7B1FA2", "#FF5252", "#FF9800" };
            int[] tabBadgeCounts = { 0, 1, 5, 3, 4 };
            string[] tabBadgeColors = { "#000000", "#FF0000", "#000000", "#000000", "#000000" };

            FileImageSource iconFavorites = (FileImageSource)FileImageSource.FromFile("ic_home.png");
            var tabPageHome = new MainPage()
            {
                Icon = iconFavorites
            };
            BottomBarPageExtensions.SetTabColor(tabPageHome, Color.FromHex("#0075E6"));
            bottomBarPage.Children.Add(tabPageHome);

            FileImageSource iconTest = (FileImageSource)FileImageSource.FromFile("ic_catalogue.png");
            var tabPageTest = new Test()
            {
                Icon = iconTest
            };
            
            BottomBarPageExtensions.SetTabColor(tabPageTest, Color.FromHex("#0075E6"));
            bottomBarPage.Children.Add(tabPageTest);


            //for (int i = 0; i < tabTitles.Length; ++i)
            //{
            //    string title = tabTitles[i];
            //    string tabColor = tabColors[i];
            //    int tabBadgeCount = tabBadgeCounts[i];
            //    string tabBadgeColor = tabBadgeColors[i];

            //    FileImageSource icon = (FileImageSource)FileImageSource.FromFile(string.Format("ic_{0}.png", title.ToLowerInvariant()));

            //    // create tab page
            //    var tabPage = new MainPage()
            //    {
            //        Title = title,
            //        Icon = icon
            //    };

            //    // set tab color
            //    if (tabColor != null)
            //    {
            //        BottomBarPageExtensions.SetTabColor(tabPage, Color.FromHex(tabColor));
            //    }

            //    // Set badges
            //    BottomBarPageExtensions.SetBadgeCount(tabPage, tabBadgeCount);
            //    BottomBarPageExtensions.SetBadgeColor(tabPage, Color.FromHex(tabBadgeColor));

            //    // set label based on title
            //    tabPage.UpdateLabel();

            //    // add tab pag to tab control
            //    bottomBarPage.Children.Add(tabPage);
            //}

            MainPage = bottomBarPage;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
