using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content.PM;
using Android.Content;


namespace DrivingLTemplate
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    
    public class MainActivity : AppCompatActivity
    {
        TextView textView;
        TextView ItemCategories;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);




            textView = FindViewById<TextView>(Resource.Id.Log_InTxt);

            textView.Click += (s, e) =>
            {
                textView.TransitionName = "imageview1";
                Intent intent = new Intent(this, typeof(Activities.LogIn_Activity));
                intent.PutExtra("ImageId", Resource.Drawable.BlurWay5.ToString());
                ActivityOptions options = ActivityOptions.MakeSceneTransitionAnimation(this, textView, textView.TransitionName);
                StartActivity(intent, options.ToBundle());
            };


            ItemCategories = FindViewById<TextView>(Resource.Id.TestStartTXT);

            ItemCategories.Click += (s, e) =>
            {
                ItemCategories.TransitionName = "imageview1";
                Intent intent = new Intent(this, typeof(Activities.ItemCategories_Activity));
                intent.PutExtra("ImageId", Resource.Drawable.BlurWay5.ToString());
                ActivityOptions options = ActivityOptions.MakeSceneTransitionAnimation(this, ItemCategories, ItemCategories.TransitionName);
                StartActivity(intent, options.ToBundle());
            };



            textView = FindViewById<TextView>(Resource.Id.TicketsRecyclerTXT);

            textView.Click += (s, e) =>
            {
                textView.TransitionName = "imageview1";
                Intent intent = new Intent(this, typeof(Activities.TicketsCategory_Activity));
                intent.PutExtra("ImageId", Resource.Drawable.BlurWay2.ToString());
                ActivityOptions options = ActivityOptions.MakeSceneTransitionAnimation(this, textView, textView.TransitionName);
                StartActivity(intent, options.ToBundle());
            };


            textView = FindViewById<TextView>(Resource.Id.StatisticTxt);

            textView.Click += (s, e) =>
            {
                textView.TransitionName = "imageview1";
                Intent intent = new Intent(this, typeof(Activities.StatisticCategory_Activity));
                intent.PutExtra("ImageId", Resource.Drawable.BlurWay2.ToString());
                ActivityOptions options = ActivityOptions.MakeSceneTransitionAnimation(this, textView, textView.TransitionName);
                StartActivity(intent, options.ToBundle());
            };

        }
        
    }
}