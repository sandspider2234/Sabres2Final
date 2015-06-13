
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Sabres2
{
	[Activity (Label = "Beach")]			
	public class Beach : Activity
	{
		private Button _button;
		private ImageButton _Beach;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView(Resource.Layout.layout_B);
			// Create your application here
			_button = FindViewById<Button>(Resource.Id.button1);

			_button.Click += (sender, e) => 
			{
				var transaction = FragmentManager.BeginTransaction();
				var dialog = new BeachFilterDialog();
				dialog.Show(transaction, "dialog fragment2");
			};

			_Beach = FindViewById<ImageButton> (Resource.Id.imageButton1);

			_Beach.Click += (sender, e) => 
			{

				StartActivity(typeof(AfterBAct));

			};
		}
	}
}

