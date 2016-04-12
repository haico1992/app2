using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace app2
{
    [Activity(Label = "app2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }

    [Activity(Label = "urlentryclass")]
    public class urlentryclass : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            Intent outsideIntent = Intent;
            AlertDialog.Builder CodeAD = new AlertDialog.Builder(this);

            CodeAD.SetTitle("Superduperapp");
            CodeAD.SetMessage("Code: " + Intent.Data.EncodedAuthority);
            CodeAD.Show();
        }
    }
}

