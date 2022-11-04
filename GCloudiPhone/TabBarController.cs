using System;
using System.IO;
using GCloudiPhone.Caching;
using GCloudiPhone.Shared;
using GCloudShared.Repository;
using GCloudShared.Service;
using GCloudShared.Shared;
using Refit;
using UIKit;

namespace GCloudiPhone
{
    public partial class TabBarController : UITabBarController
    {
        IUserStoreService _userStoreService;
        IAuthService _authService;
        UserRepository _userRepository;
        MobilePhoneRepository _mobilePhoneRepository;

        string KundenkartePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "kundenkarte.jpg");

        public TabBarController(IntPtr handle) : base(handle)
        {
            _userStoreService = RestService.For<IUserStoreService>(HttpClientContainer.Instance.HttpClient);
            _authService = RestService.For<IAuthService>(HttpClientContainer.Instance.HttpClient);
            _userRepository = new UserRepository(DbBootstraper.Connection);
            _mobilePhoneRepository = new MobilePhoneRepository(DbBootstraper.Connection);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Delegate = new CustomUITabBarControllerDelegate();


            UITabBar.Appearance.SelectedImageTintColor = UIColor.FromRGB(255, 205, 103);
            //UITabBar.Appearance.TintColor = new UIColor(90 / 255f, 36 / 255f, 191 / 255f, 1.0f);
            //UITabBar.Appearance.BarTintColor = new UIColor(245 / 255f, 246 / 255f, 247 / 255f, 1.0f);

            // TabBarController.MoreNavigationController.NavigationBar.TopItem.Title = @"new title";

            //Promena ikonice na tab bar-u, ne mora da se radi na ovaj nacin jer se
            //ikonice mogu dodati i pomocu storyboarda
            //TabBar.Items[1].Image = GetTabIcon(UITabBarSystemItem.Bookmarks);

            //View.BackgroundColor = UIColor.FromRGB(255, 205, 103);

            //UITabBarController tabViewController = (UITabBarController)this.TabBarController;

            //UITabBar tb = MoreNavigationController.TabBarController.TabBar;
            //if (tb.Subviews.Length > 4)
            //{
            //    UIView tbb = tb.Subviews[4];
            //    UILabel label = (UILabel)tbb.Subviews[1];
            //    label.Text = "Mehr2";
            //}

            //Change Title from More/Mehr to Auswahl
            UINavigationBar moreNavigationBar = this.MoreNavigationController.NavigationBar;
            moreNavigationBar.TopItem.Title = @"Auswahl";

            //Remove Edit button from More Page
            UINavigationItem moreNavItem = moreNavigationBar.TopItem;
            moreNavItem.RightBarButtonItem.Title = "";
            moreNavItem.RightBarButtonItem.Enabled = false;

            //this.MoreNavigationController.NavigationBar.Hidden = true;
        }

        private UIImage GetTabIcon(UITabBarSystemItem systemItem)
        {
            //Convert UITabBarItem to UIImage
            UITabBarItem item = new UITabBarItem(systemItem, 0);

            return UIImage.FromImage(item.SelectedImage.CGImage, item.SelectedImage.CurrentScale, item.SelectedImage.Orientation);
        }

        public async void Logout(UIViewController sender)
        {
            //Remove all FCM Subscriptions
            NotificationsHelper.Instance.UnsubscribeAll();

            await _authService.Logout(_mobilePhoneRepository.FirstOrDefault()?.MobilePhoneId);

            _userRepository.DeleteAll();
            //_mobilePhoneRepository.DeleteAll();

            ////Not sure if Logout method does this anyways
            //if (File.Exists(KundenkartePath))
            //{
            //    File.Delete(KundenkartePath);
            //}

            //if (CacheHolder.Instance.LoyaltyCard != null)
            //{
            //    CacheHolder.Instance.LoyaltyCard.Dispose();
            //    CacheHolder.Instance.LoyaltyCard = null;
            //}
            //CachingService.ClearCachedImages();

            //((AppDelegate)UIApplication.SharedApplication.Delegate).IsLoggedIn = false;
            ((AppDelegate)UIApplication.SharedApplication.Delegate).AuthState = AuthState.Unauthorized;
            sender.ViewWillAppear(true);
        }

        public void ChangeSelectedItem(int itemIndex)
        {
            Delegate.ShouldSelectViewController(this, ViewControllers[itemIndex]);
            SelectedIndex = itemIndex;
        }
    }
}