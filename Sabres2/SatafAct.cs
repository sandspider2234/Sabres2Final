
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
	[Activity (Label = "More Info")]			
	public class SatafAct : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView(Resource.Layout.AfterSataf);

			// Create your application here
		}
	}
}

