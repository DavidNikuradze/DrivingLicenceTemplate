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
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using DrivingLTemplate.Adapter;
using DrivingLTemplate.Models;

namespace DrivingLTemplate.Activities
{

    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = false, ScreenOrientation = ScreenOrientation.Portrait)]
    class ItemCategory_Activity : AppCompatActivity
    {

        TextView text;

        
        


        private List<ItemModel> Myitems = new List<ItemModel>()
        {

            new ItemModel(){Image=Resource.Drawable.motorcycleIcon1, CheckBox = Resource.Id.CheckBoxCheck, Textview ="A,A1"},

              new ItemModel(){Image=Resource.Drawable.carIcon, CheckBox = Resource.Id.CheckBoxCheck, Textview ="B1,B,BE"},

                new ItemModel(){Image=Resource.Drawable.truckIcon, CheckBox = Resource.Id.CheckBoxCheck, Textview ="C"},
                 new ItemModel(){Image=Resource.Drawable.trolleyTramIcon1, CheckBox = Resource.Id.CheckBoxCheck, Textview ="TRAM"},
                  new ItemModel(){Image=Resource.Drawable.VanICon1, CheckBox = Resource.Id.CheckBoxCheck, Textview ="C1"},
                   new ItemModel(){Image=Resource.Drawable.miniBusVan1, CheckBox = Resource.Id.CheckBoxCheck, Textview ="D1"},
                   new ItemModel(){Image=Resource.Drawable.busIcon1, CheckBox = Resource.Id.CheckBoxCheck, Textview ="D"},




        };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.ItemCategory);


            ItemRecyclerAdapter adapter = new ItemRecyclerAdapter(Myitems);
            RecyclerView recycler = FindViewById<RecyclerView>(Resource.Id.RecyclerView1);
            recycler.SetLayoutManager(new LinearLayoutManager(this) {Orientation = LinearLayoutManager.Horizontal});
            recycler.SetAdapter(adapter);


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