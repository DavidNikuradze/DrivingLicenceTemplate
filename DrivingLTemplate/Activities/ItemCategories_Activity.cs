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
    class ItemCategories_Activity : AppCompatActivity
    {

        TextView text;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.ItemCategories);




            text = FindViewById<TextView>(Resource.Id.TestStart2TXT);

            text.Click += (s, e) =>
            {
                text.TransitionName = "imageview1";
                Intent intent = new Intent(this, typeof(Activities.Tests_Activity));
                intent.PutExtra("ImageId", Resource.Drawable.BlurWay5.ToString());
                ActivityOptions options = ActivityOptions.MakeSceneTransitionAnimation(this, text, text.TransitionName);
                StartActivity(intent, options.ToBundle());
            };




        }
    }
}