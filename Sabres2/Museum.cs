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
	[Activity (Label = "Museum")]			
	public class Museum : Activity
	{
		private Button _button;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView(Resource.Layout.layout_M);

			_button = FindViewById<Button>(Resource.Id.museumButton);


			_button.Click += (sender, e) => 
			{
				var transaction = FragmentManager.BeginTransaction();
				var dialog = new MuseumFilterDialog();
				dialog.Show(transaction, "dialog fragment");
			};
		}
	}
}