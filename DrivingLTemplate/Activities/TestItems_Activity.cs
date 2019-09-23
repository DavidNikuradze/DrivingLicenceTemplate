using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace DrivingLTemplate.Activities
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = false, ScreenOrientation = ScreenOrientation.Portrait)]
    class TestItems_Activity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.TestItemRecyclerView);


            var Result = Convert.ToInt32(Intent.Extras.GetString("TestsImage"));
            var img = FindViewById<ImageView>(Resource.Id.TSImage);
            img.SetBackgroundResource(Result);

        }
    }
}