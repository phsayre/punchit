using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace punchit
{
    [Activity(Label = "punchit", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

        }
    }
}