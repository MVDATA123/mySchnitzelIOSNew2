// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GCloudiPhone
{
    [Register ("ActionCouponListViewController")]
    partial class ActionCouponListViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView CouponListNew { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CouponListNew != null) {
                CouponListNew.Dispose ();
                CouponListNew = null;
            }
        }
    }
}