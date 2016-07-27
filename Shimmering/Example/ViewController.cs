using System;

using UIKit;
using Shimmering;

namespace Example
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			FBShimmeringView shimmeringView = new FBShimmeringView() 
			{ 
				Frame = new CoreGraphics.CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, 200),
				BackgroundColor = UIColor.Blue
			};
			View.Add(shimmeringView);

			UILabel lbl = new UILabel() {
				Frame = new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, 200),
				Text = "Shimmering Text",
				Font = UIFont.BoldSystemFontOfSize(40),
				TextColor = UIColor.White,
				TextAlignment = UITextAlignment.Center
			};
			shimmeringView.ContentView = lbl;
			shimmeringView.Shimmering = true;

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

