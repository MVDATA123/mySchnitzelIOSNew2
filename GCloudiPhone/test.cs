using Foundation;
using System;
using UIKit;

namespace GCloudiPhone
{
    public partial class test : UIViewController
    {
        public test (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.NavigationController.SetNavigationBarHidden(false, true);

            //UINavigationItem uiNavItem = this.NavigationController.TopItem;
            //NavigationItem.LeftBarButtonItem.Title = "tt";
            //NavigationItem.BackBarButtonItem = null;
        }
    }
}