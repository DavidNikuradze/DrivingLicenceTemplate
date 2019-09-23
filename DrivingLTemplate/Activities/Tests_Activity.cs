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

    public class Tests_Activity : AppCompatActivity
    {

        private List<TestsItemsModel> testsItems = new List<TestsItemsModel>()
       {
           new TestsItemsModel(){ Image=Resource.Drawable.wall1, Answer1="alskdjbgg;kasjbdg;",Answer2="as;btg;kasjbhdt",Answer3="a;nas;kjdtb",Answer4=";aldjtbh;kasjbdg"},
       };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.Tests_Activity);



            TestItemsRecAdapter adapter = new TestItemsRecAdapter(testsItems);
            RecyclerView recycler = FindViewById<RecyclerView>(Resource.Id.RecyclerView2);
            recycler.SetLayoutManager(new LinearLayoutManager(this));
            recycler.SetAdapter(adapter);





        }


    }
}