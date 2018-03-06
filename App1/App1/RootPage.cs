using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App1
{
    public class RootPage : BottomBarPage
    {
        private object _selectedMenu;
        //private MenuPage menuPage;

        MainPage homePage;

        public RootPage()
        {
            //Common.RootPage = this;

            //FashionBook.Mobile.Data.PingData.Ping();

            NavigationPage.SetHasNavigationBar(this, true);

            //Home
            homePage = new MainPage();
            //homePage.Icon = "ic_home.png";
            //homePage.Title = AppResources.Home;
            BottomBarPageExtensions.SetTabColor(homePage, Color.FromHex("#0075E6"));
            this.Children.Add(homePage);

            //Catalogue
            var cataloguePage = new Test();
            cataloguePage.Title = "Test";
            //cataloguePage.Icon = "ic_catalogue.png";
            BottomBarPageExtensions.SetTabColor(cataloguePage, Color.FromHex("#0B87FF"));
            this.Children.Add(cataloguePage);

            ////Orders list
            //var ordersListPage = new OrdersListPage();
            //ordersListPage.Title = AppResources.Orders;
            //ordersListPage.Icon = "ic_orders.png";
            //BottomBarPageExtensions.SetTabColor(ordersListPage, Color.FromHex("#0B8900"));
            //this.Children.Add(ordersListPage);

            ////Orders list
            //var cartPage = new CartPage();
            //cartPage.Title = AppResources.Cart;
            //cartPage.Icon = "ic_cart.png";
            //BottomBarPageExtensions.SetTabColor(cartPage, Color.FromHex("#0B8900"));
            //this.Children.Add(cartPage);

            ////Profile
            //var profilePage = new ProfilePage();
            //profilePage.Icon = "ic_profile.png";
            //profilePage.Title = AppResources.Profile;
            //BottomBarPageExtensions.SetTabColor(profilePage, Color.FromHex("#0054A5"));
            //this.Children.Add(profilePage);

            ////Settings
            //var settingsPage = new SettingsMainPage();
            //settingsPage.Icon = "ic_settings.png";
            //settingsPage.Title = AppResources.Settings;
            //BottomBarPageExtensions.SetTabColor(settingsPage, Color.FromHex("#004282"));
            //this.Children.Add(settingsPage);

            //Check is must redirect to login
            //if (Session.Current == "")
            //    LogOut();
            //else
            //{
            //    var ret = Auth.TokenValidate(Session.Current);
            //    if (ret.succeed == false)
            //    {
            //        LogOut();
            //    }
            //}
        }

        //
        // Summary:
        //     Raises the Xamarin.Forms.MultiPage{T}.CurrentPageChanged event.
        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            //var page = ;
            //if (page!=null)
            if (this.CurrentPage != null)
                this.Title = this.CurrentPage.Title;
        }

        //public RootPage()
        //{
        //    BindableObject tabPage;
        //    //bottomBarPage.BarBackgroundColor = Color.Pink;


        //    // You can only define the color for the active icon if you set the Bottombar to fixed mode
        //    // So if you want to try this, just uncomment the next two lines

        //    //bottomBarPage.BarTextColor = Color.Blue; // Setting Color of selected Text and Icon
        //    //bottomBarPage.FixedMode = true;
        //    //this.BarTextColor = Color.Black;
        //    //this.FixedMode = true;

        //    // Whith BarTheme you can select between light and dark theming when using FixedMode
        //    // When using DarkTheme you can set the Background Color by adding a colors.xml to you Android.Resources.Values
        //    // with content
        //    //
        //    //  <color name="white">#ffffff</color>
        //    //  < color name = "bb_darkBackgroundColor" >#000000</color>
        //    //
        //    // by setting "white" you can select the color of the non selected items and texts in dark theme
        //    // The Difference between DarkThemeWithAlpha and DarkThemeWithoutAlpha is that WithAlpha will draw not selected items with halfe the 
        //    // intensity instaed of solid "white" value
        //    //
        //    // Uncomment next line to use Dark Theme
        //    // bottomBarPage.BarTheme = BottomBarPage.BarThemeTypes.DarkWithAlpha;

        //    //string[] tabTitles = { "Favorites", "Friends", "Nearby", "Recents", "Restaurants" };
        //    string[] tabTitles = { "Favorites", "Friends", "Home", "Recents", "Restaurants" };
        //    string[] tabColors = { null, "#5D4037", "#7B1FA2", "#FF5252", "#FF9800" };
        //    int[] tabBadgeCounts = { 0, 1, 5, 3, 4 };
        //    string[] tabBadgeColors = { "#000000", "#FF0000", "#000000", "#000000", "#000000" };

        //    //Add tabs

        //    //Home
        //    var homePage = new HomePage();
        //    homePage.Icon = "ic_home.png";
        //    BottomBarPageExtensions.SetTabColor(homePage, Color.FromHex("#5D4037"));
        //    BottomBarPageExtensions.SetBadgeCount(homePage, 3);
        //    BottomBarPageExtensions.SetBadgeColor(homePage, Color.FromHex("#FF0000"));
        //    this.Children.Add(homePage);


        //    //Catalogue
        //    var testPage = new TestPage();
        //    testPage.Title = "More";
        //    testPage.Icon = "ic_favorites.png";
        //    BottomBarPageExtensions.SetTabColor(testPage, Color.FromHex("#7B1FA2"));
        //    //BottomBarPageExtensions.SetBadgeCount(cataloguePage, 3);
        //    //BottomBarPageExtensions.SetBadgeColor(cataloguePage, Color.FromHex("#FF0000"));
        //    this.Children.Add(testPage);

        //    //Home
        //    var homePage2 = new HomePage();
        //    homePage.Icon = "ic_home.png";
        //    BottomBarPageExtensions.SetTabColor(homePage, Color.FromHex("#FF5252"));
        //    BottomBarPageExtensions.SetBadgeCount(homePage, 3);
        //    BottomBarPageExtensions.SetBadgeColor(homePage, Color.FromHex("#FF0000"));
        //    this.Children.Add(homePage2);

        //    ////Home
        //    //var homePage3 = new HomePage();
        //    //homePage.Icon = "ic_home.png";
        //    //BottomBarPageExtensions.SetTabColor(homePage, Color.FromHex("#FF9800"));
        //    //BottomBarPageExtensions.SetBadgeCount(homePage, 3);
        //    //BottomBarPageExtensions.SetBadgeColor(homePage, Color.FromHex("#FF0000"));
        //    //this.Children.Add(homePage3);

        //    //for (int i = 0; i < tabTitles.Length; ++i)
        //    //for (int i = 0; i < 4; ++i)
        //    //{
        //    //    string title = tabTitles[i];
        //    //    string tabColor = tabColors[i];
        //    //    int tabBadgeCount = tabBadgeCounts[i];
        //    //    string tabBadgeColor = tabBadgeColors[i];

        //    //    FileImageSource icon = (FileImageSource)FileImageSource.FromFile(string.Format("ic_{0}.png", title.ToLowerInvariant()));

        //    //    if (i != 2)
        //    //    {
        //    //        tabPage = new HomePage()
        //    //        {
        //    //            Title = title,
        //    //            Icon = icon
        //    //        };
        //    //    }
        //    //    else
        //    //    {
        //    //        tabPage = new CataloguePage()
        //    //        {
        //    //            Title = title,
        //    //            Icon = icon
        //    //        };
        //    //    }

        //    //    // set tab color
        //    //    if (tabColor != null)
        //    //    {
        //    //        BottomBarPageExtensions.SetTabColor(tabPage, Color.FromHex(tabColor));
        //    //    }

        //    //    // Set badges
        //    //    BottomBarPageExtensions.SetBadgeCount(tabPage, tabBadgeCount);
        //    //    BottomBarPageExtensions.SetBadgeColor(tabPage, Color.FromHex(tabBadgeColor));

        //    //    // set label based on title
        //    //    //tabPage.UpdateLabel();

        //    //    // add tab pag to tab control
        //    //    this.Children.Add(tabPage as Page);
        //    //}
        //}

        //public string SelectedMenuCode
        //{
        //    get
        //    {
        //        return (_selectedMenu as MenuItem).Code;
        //    }
        //}

        //public void SetLastSelectedMenu()
        //{
        //    if (menuPage.Menu.SelectedItem != _selectedMenu)
        //        menuPage.Menu.SelectedItem = _selectedMenu;
        //    else
        //        LoadPageData();
        //}

        //public RootPage()
        //{
        //    menuPage = new MenuPage();
        //    menuPage.Menu.ItemSelected += (sender, e) =>
        //    {
        //        var menuItem = e.SelectedItem as MenuItem;
        //        if (menuItem == null)
        //            return;

        //        //If lougout set back the previous menu
        //        if (menuItem.Title == AppResources.LogOut)
        //        {
        //            //menuPage.Menu.SelectedItem = _selectedMenu;
        //            LogOut();
        //        }
        //        else
        //        {
        //            _selectedMenu = e.SelectedItem;
        //            NavigateTo(menuItem);
        //            LoadPageData();
        //        }
        //    };

        //    Master = menuPage;
        //    Detail = new NavigationPage(new HomePage());
        //    _selectedMenu = menuPage.Menu.SelectedItem;

        //    //Check is must redirect to login
        //    if (Session.Current == "")
        //        LogOut();
        //    else
        //    {
        //        var ret = Auth.TokenValidate(Session.Current);
        //        if (ret == false)
        //            LogOut();
        //        else
        //            LoadPageData();
        //    }
        //}


        //public void LoadPageData()
        //{
        //    try
        //    {
        //        switch (SelectedMenuCode)
        //        {
        //            case "FashionBook":
        //                //MessagingCenter.Send<RootPage>(this, Common.MsgCenterType.RouteListModified.ToString());
        //                break;
        //            case "SalesOrders":
        //                MessagingCenter.Send<RootPage>(this, Common.MsgCenterType.OrdersListModified.ToString());
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Common.Log(ex);
        //    }
        //}


        //void NavigateTo(MenuItem menu)
        //{
        //    //Unsubscribe previuos page
        //    var page = (Detail as NavigationPage).CurrentPage as IPageMethods;
        //    page.UnsubscribeMessages();

        //    //Go
        //    Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
        //    Detail = new NavigationPage(displayPage);
        //    IsPresented = false;
        //}

        //public void LogOut()
        //{
        //    bool val;
        //    try
        //    {
        //        Common.Logout();
        //        Device.BeginInvokeOnMainThread(async () =>
        //        {
        //            this.CurrentPage = homePage;
        //            await Navigation.PushModalAsync(new NavigationPage(new LoginPage()));
        //            //}
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        Common.Log(ex);
        //    }
        //}
    }
}

