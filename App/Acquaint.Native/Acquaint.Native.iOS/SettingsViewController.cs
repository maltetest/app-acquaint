// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Linq;
using Foundation;
using UIKit;

namespace Acquaint.Native.iOS
{
	public partial class SettingsViewController : UIViewController
	{
		UIBarButtonItem _SaveBarButtonItem;
		UIBarButtonItem _CancelBarButtonItem;

		public SettingsViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			_SaveBarButtonItem = NavigationItem.RightBarButtonItems[0];

			_CancelBarButtonItem = NavigationItem.RightBarButtonItems[1];

			_SaveBarButtonItem.Clicked += HandleSaveBarButtonItemClicked;

			_CancelBarButtonItem.Clicked += HandleCancelBarButtonItemClicked;
		}

		void HandleSaveBarButtonItemClicked(object sender, EventArgs ea)
		{
			if (!AllFieldsAreValid)
			{
				// TODO: display error messages

				return;
			}

			// TODO: perform saving actions

			DismissViewController(true, null);
		}

		void HandleCancelBarButtonItemClicked(object sender, EventArgs ea)
		{
			DismissViewController(true, null);
		}

		bool AllFieldsAreValid
		{
			get 
			{
				return true;
			}
		}
	}
}
