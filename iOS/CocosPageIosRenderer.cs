using System;
using Xamarin.Forms;
using TestCocos;
using TestCocos.iOS;
using Xamarin.Forms.Platform.iOS;
using GoneBananas;

[assembly:ExportRenderer(typeof(CocosPage), typeof(CocosPageIosRenderer))]
namespace TestCocos.iOS
{
	public class CocosPageIosRenderer : PageRenderer
	{
		public CocosPageIosRenderer ()
		{
			AppDelegate.CCApplication.ApplicationDelegate = new GoneBananasApplicationDelegate ();
			AppDelegate.CCApplication.StartGame ();
		}
	}
}

