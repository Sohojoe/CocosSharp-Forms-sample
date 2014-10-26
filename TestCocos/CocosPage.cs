using System;
using Xamarin.Forms;

namespace TestCocos
{
	public class CocosPage : ContentPage
	{
		public CocosPage ()
		{
			var stack = new StackLayout {
				Children = {
					new Label {
						Text = "Hello, Coscus!",
						VerticalOptions = LayoutOptions.Center,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
						BackgroundColor = Color.Transparent,
					},
				},
			};
			Content = stack;
			Device.StartTimer(TimeSpan.FromSeconds(1), ()=>{
				var lab = new Label {
					Text = "Hello, Again!",
					TextColor = Color.Yellow,
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					BackgroundColor = Color.Transparent,
				};
				stack.Children.Add(lab);
				return true;
			});
		}
	}
}

