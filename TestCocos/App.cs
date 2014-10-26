using System;
using Xamarin.Forms;

namespace TestCocos
{
	public class App
	{
		static NavigationPage page;
		public static Page GetMainPage ()
		{	

			var detail = new ContentPage { 
				BackgroundColor = Color.Transparent,
				Content = new StackLayout (){
					Children = {
						new Label {
							Text = "",
						},
						new Label {
							Text = "Hello, Forms!",
							VerticalOptions = LayoutOptions.Center,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							BackgroundColor = Color.Transparent,
						 },
						GetButtonStartCC(),
					},

				},
			};
			page = new NavigationPage (detail);
			return page;
		}

		static Button GetButtonStartCC() {
			var but = new Button {
				Text = "Start Cocos",
				Command = new Command((e1)=>{
					var newp = new CocosPage();
					page.Navigation.PushAsync(newp);
				}),
			};
			return but;

		}


	}
}

