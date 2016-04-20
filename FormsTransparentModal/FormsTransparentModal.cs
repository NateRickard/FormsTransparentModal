using System;

using Xamarin.Forms;

namespace FormsTransparentModal
{
	public class App : Application
	{
		public App ()
		{
			var button = new Button {
				Text = "Click me to launch modal"
			};
			button.Clicked += onClicked;

			// The root page of your application
			var content = new ContentPage {
				BackgroundColor = Color.Pink,
				Title = "FormsTransparentModal",
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						button
					}
				}
			};

			MainPage = new NavigationPage (content);
		}

		void onClicked (object sender, EventArgs e)
		{
			MainPage.Navigation.PushModalAsync (new MyModalPage ());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

