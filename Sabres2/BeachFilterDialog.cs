﻿using System;
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
	class BeachFilterDialog : DialogFragment
	{
		private Button button;
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView(inflater, container, savedInstanceState);
			var view = inflater.Inflate(Resource.Layout.BeachFilters, container, false);

			button = view.FindViewById<Button> (Resource.Id.button2);

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

