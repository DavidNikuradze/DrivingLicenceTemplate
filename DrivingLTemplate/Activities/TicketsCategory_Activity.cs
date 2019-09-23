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
    public class TicketsCategory_Activity : AppCompatActivity
    {


        private List<TicketsCatModel> tickets = new List<TicketsCatModel>()
        {
            new TicketsCatModel(){CheckBox= Resource.Id.TicketsCard_CHeckB, Text1="22 კითხვა კატეგორიიდან თუ რაღაც :D", Text2="მაფრთხილებელი"},
            new TicketsCatModel(){CheckBox= Resource.Id.TicketsCard_CHeckB, Text1="22 კითხვა კატეგორიიდან თუ რაღაც :D", Text2="მაფრთხილებელი"},
            new TicketsCatModel(){CheckBox= Resource.Id.TicketsCard_CHeckB, Text1="22 კითხვა კატეგორიიდან თუ რაღაც :D", Text2="მაფრთხილებელი"},
            new TicketsCatModel(){CheckBox= Resource.Id.TicketsCard_CHeckB, Text1="22 კითხვა კატეგორიიდან თუ რაღაც :D", Text2="მაფრთხილებელი"},
            new TicketsCatModel(){CheckBox= Resource.Id.TicketsCard_CHeckB, Text1="22 კითხვა კატეგორიიდან თუ რაღაც :D", Text2="მაფრთხილებელი"},
        };


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.TicketsCategory);





            TicketsRecAdapter adapter = new TicketsRecAdapter(tickets);
            RecyclerView recycler = FindViewById<RecyclerView>(Resource.Id.RecyclerView3);
            recycler.SetLayoutManager(new LinearLayoutManager(this));
            recycler.SetAdapter(adapter);



        }

    }
}