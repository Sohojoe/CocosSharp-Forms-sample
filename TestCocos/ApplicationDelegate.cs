using CocosDenshion;
using CocosSharp;

namespace TestCocos
{
	public class ApplicationDelegate: CCApplicationDelegate
	{
		public override void ApplicationDidFinishLaunching (CCApplication application, CCWindow mainWindow)
		{
			application.PreferMultiSampling = false;
			application.ContentRootDirectory = "Content";

			mainWindow.SupportedDisplayOrientations = CCDisplayOrientation.Portrait | CCDisplayOrientation.LandscapeLeft | CCDisplayOrientation.LandscapeRight;

			application.ContentSearchPaths.Add ("hd");


			CCSimpleAudioEngine.SharedEngine.PreloadEffect ("Sounds/tap");

			CCScene scene = GameStartLayer.GameStartLayerScene (mainWindow);
			mainWindow.RunWithScene (scene);
		}

		public override void ApplicationDidEnterBackground (CCApplication application)
		{
			// stop all of the animation actions that are running.
			application.Paused = true;

			// if you use SimpleAudioEngine, your music must be paused
			CCSimpleAudioEngine.SharedEngine.PauseBackgroundMusic ();
		}

		public override void ApplicationWillEnterForeground (CCApplication application)
		{
			application.Paused = false;

			// if you use SimpleAudioEngine, your background music track must resume here. 
			CCSimpleAudioEngine.SharedEngine.ResumeBackgroundMusic ();
		}
	}
}

