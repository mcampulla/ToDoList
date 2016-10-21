// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ToDoList.iOS
{
	[Register ("SplashViewController")]
	partial class SplashViewController
	{
		[Outlet]
		UIKit.UIImageView LogoImage { get; set; }

		[Outlet]
		UIKit.UILabel LogoLabel { get; set; }

		[Outlet]
		UIKit.UILabel VersionLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LogoImage != null) {
				LogoImage.Dispose ();
				LogoImage = null;
			}

			if (LogoLabel != null) {
				LogoLabel.Dispose ();
				LogoLabel = null;
			}

			if (VersionLabel != null) {
				VersionLabel.Dispose ();
				VersionLabel = null;
			}
		}
	}
}
