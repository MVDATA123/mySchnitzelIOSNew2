using System;
namespace GCloudiPhone
{
    public class CustomShellRenderer : ShellRenderer
    {
        protected override IShellTabBarAppearanceTracker CreateTabBarAppearanceTracker()
        {
            return new TabBarAppearance();
        }
    }

    public class TabBarAppearance : IShellTabBarAppearanceTracker
    {
        public void Dispose()
        {
        }

        public void ResetAppearance(UITabBarController controller)
        {
        }

        public void SetAppearance(UITabBarController controller, ShellAppearance appearance)
        {
        }

        public void UpdateLayout(UITabBarController controller)
        {
            UITabBar tb = controller.MoreNavigationController.TabBarController.TabBar;
            if (tb.Subviews.Length > 4)
            {
                UIView tbb = tb.Subviews[4];
                UILabel label = (UILabel)tbb.Subviews[1];
                label.Text = "Mehr";
            }
        }
    }
}
