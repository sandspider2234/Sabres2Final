using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Sabres2
{
    [Activity(Label = "Sabres", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ImageButton travelButton = FindViewById<ImageButton>(Resource.Id.TravelB);
            travelButton.Click += (sender, args) =>
            {
                StartActivity(typeof(Travel));
            };

			ImageButton beachButton = FindViewById<ImageButton> (Resource.Id.imageButton2);
			beachButton.Click += (sender, args) => 
			{
				StartActivity(typeof(Beach));
			};

			ImageButton museumButton = FindViewById<ImageButton> (Resource.Id.museumButton);
			museumButton.Click += (sender, args) => 
			{
				StartActivity(typeof(Museum));
			};


        }
    }
}

