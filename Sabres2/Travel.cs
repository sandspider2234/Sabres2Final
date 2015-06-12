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
    [Activity(Label = "Travel")]
    public class Travel : Activity
    {
        private Button _dialog;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.layout_T);

            _dialog = FindViewById<Button>(Resource.Id.button1);


            _dialog.Click += _b_Click;


        }

        void _b_Click(object sender, EventArgs e)
        {
            var transaction = FragmentManager.BeginTransaction();
            var dialog = new FilterDialog();
            dialog.Show(transaction, "dialog fragment");

        }
    }
}