using FormsTransparentModal;
using FormsTransparentModal.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof (MyModalPage), typeof (MyModalPageRenderer))]
namespace FormsTransparentModal.iOS
{
	public class MyModalPageRenderer : PageRenderer
	{
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			//ParentViewController here is of typer ModalWrapper, an internal class in Xamarin.Forms
			//need to set its background color here because it sets its own background color to White in ViewWillAppear()
			ParentViewController.View.BackgroundColor = UIColor.Clear;
		}

		public override void WillMoveToParentViewController (UIViewController parent)
		{
			base.WillMoveToParentViewController (parent);

			//again, the 'parent' here is of type ModalWrapper - set it up so it will show over top of the current page

			parent.ModalPresentationStyle = UIModalPresentationStyle.OverCurrentContext;
		}
	}
}