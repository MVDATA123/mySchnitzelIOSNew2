using Foundation;
using System;
using UIKit;
using WebKit;

namespace GCloudiPhone
{
    public partial class webViewSiteController : UIViewController
    {
        private readonly NSUrl url = new NSUrl("https://myschnitzel.at/apppart/speisekarte-produkte/");

        public webViewSiteController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Dodato jer ukidamo tab bar
            this.NavigationController.SetNavigationBarHidden(false, true);

            var webView = new WKWebView(View.Frame, new WKWebViewConfiguration());
            View.AddSubview(webView);

            webView.LoadRequest(new NSUrlRequest(url));
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            NavigationItem.Title = "Produkte";
        }
    }
}