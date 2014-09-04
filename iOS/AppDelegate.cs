using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using CocosSharp;
using GoneBananas;


namespace TestCocos.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		/*
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{

			if (true) {
				// create a new window instance based on the screen size
				window = new UIWindow (UIScreen.MainScreen.Bounds);

				// If you have defined a root view controller, set it here:
				// window.RootViewController = myViewController;

				// make the window visible
				window.MakeKeyAndVisible ();
				return true;

			} else {
				Forms.Init ();


				window = new UIWindow (UIScreen.MainScreen.Bounds);
			
				window.RootViewController = App.GetMainPage ().CreateViewController ();
				window.MakeKeyAndVisible ();
				return true;
			
			}
		}
*/
		public override void FinishedLaunching (UIApplication app)
		{
			var application = new CCApplication ();
			application.ApplicationDelegate = new GoneBananasApplicationDelegate ();
			application.StartGame ();
		}
	}
}

