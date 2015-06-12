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
    class FilterDialog : DialogFragment
    {
		private Button rButton;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
			var view = inflater.Inflate(Resource.Layout.Filters, container, false);

			rButton = view.FindViewById<Button> (Resource.Id.returnButton);

			rButton.Click += (object sender, EventArgs e) => 
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