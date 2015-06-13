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
	public class MuseumFilterDialog : DialogFragment
	{
		private Button button;
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView(inflater, container, savedInstanceState);
			var view = inflater.Inflate(Resource.Layout.MuseumFilters, container, false);

			button = view.FindViewById<Button> (Resource.Id.button1);

			button.Click += (object sender, EventArgs e) => 
			{
				Dismiss();
			};
			return view;
		}


		public override void OnActivityCreated(Bundle savedInstanceSaved)
		{
			Dialog.Window.RequestFeature (WindowFeatures.NoTitle);
			base.OnActivityCreated (savedInstanceSaved);
		}
	}
}

