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

            // Get our UI controls from the layout
            Button activateNFCButton = FindViewById<Button>(Resource.Id.activateNFCButton);

            // Perform action on user click
            activateNFCButton.Click += (sender, e) =>
            {
                // Activate NFC beacon
                
            };
        }
    }
}