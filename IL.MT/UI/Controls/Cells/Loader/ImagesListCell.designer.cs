// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace IL.MT.UI
{
	[Register ("ImagesListCell")]
	partial class ImagesListCell
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView imageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel urlLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}

			if (urlLabel != null) {
				urlLabel.Dispose ();
				urlLabel = null;
			}
		}
	}
}
