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
    [Register ("SettingsTableViewController")]
    partial class SettingsTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell ChangePasswordCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EBill { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel EmailLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel InvitationCodeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LogoutButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell LogoutCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell PersonalInformationCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView SettingsTable { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ShareInvitationCodeButton { get; set; }

        [Action ("ShareInvitationCodeButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ShareInvitationCodeButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ChangePasswordCell != null) {
                ChangePasswordCell.Dispose ();
                ChangePasswordCell = null;
            }

            if (EBill != null) {
                EBill.Dispose ();
                EBill = null;
            }

            if (EmailLabel != null) {
                EmailLabel.Dispose ();
                EmailLabel = null;
            }

            if (InvitationCodeLabel != null) {
                InvitationCodeLabel.Dispose ();
                InvitationCodeLabel = null;
            }

            if (LoginButton != null) {
                LoginButton.Dispose ();
                LoginButton = null;
            }

            if (LogoutButton != null) {
                LogoutButton.Dispose ();
                LogoutButton = null;
            }

            if (LogoutCell != null) {
                LogoutCell.Dispose ();
                LogoutCell = null;
            }

            if (PersonalInformationCell != null) {
                PersonalInformationCell.Dispose ();
                PersonalInformationCell = null;
            }

            if (SettingsTable != null) {
                SettingsTable.Dispose ();
                SettingsTable = null;
            }

            if (ShareInvitationCodeButton != null) {
                ShareInvitationCodeButton.Dispose ();
                ShareInvitationCodeButton = null;
            }
        }
    }
}