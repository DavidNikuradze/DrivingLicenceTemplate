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
    class LogIn_Activity : AppCompatActivity
    {
        TextView Tview;
        TextView view;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.Login_Form);




            Tview = FindViewById<TextView>(Resource.Id.RegTXT);

            Tview.Click += (s, e) =>
            {
                Tview.TransitionName = "imageview1";
                Intent intent = new Intent(this, typeof(Activities.Register_Activity));
                intent.PutExtra("ImageId", Resource.Drawable.BlurWay5.ToString());
                ActivityOptions options = ActivityOptions.MakeSceneTransitionAnimation(this, Tview, Tview.TransitionName);
                StartActivity(intent, options.ToBundle());
            };



            view = FindViewById<TextView>(Resource.Id.PasswordForgotTXT);

            view.Click += (s, e) =>
            {
                view.TransitionName = "imageview1";
                Intent intent = new Intent(this, typeof(Activities.PasswordReset_Activity));
                intent.PutExtra("ImageId", Resource.Drawable.BlurWay2.ToString());
                ActivityOptions options = ActivityOptions.MakeSceneTransitionAnimation(this, view, view.TransitionName);
                StartActivity(intent, options.ToBundle());
            };



        }
    }
}