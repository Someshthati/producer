// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Producer.iOS
{
	[Register ("ProduceTvCell")]
	partial class ProduceTvCell
	{
		[Outlet]
		UIKit.UILabel accessoryLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (accessoryLabel != null) {
				accessoryLabel.Dispose ();
				accessoryLabel = null;
			}
		}
	}
}
