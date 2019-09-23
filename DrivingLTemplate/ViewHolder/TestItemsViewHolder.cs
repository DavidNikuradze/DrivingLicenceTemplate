using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace DrivingLTemplate.ViewHolder
{
   public class TestItemsViewHolder : RecyclerView.ViewHolder
    {
        public ImageView image { get; set; }
      
        public TextView answer1 { get; set; }
        public TextView answer2 { get; set; }
        public TextView answer3 { get; set; }
        public TextView answer4 { get; set; }

        public TestItemsViewHolder(View view) : base(view)
        {
            image = view.FindViewById<ImageView>(Resource.Id.TSImage);
           
            answer1 = view.FindViewById<TextView>(Resource.Id.TRA1_TXT);
            answer2 = view.FindViewById<TextView>(Resource.Id.TRA2_TXT);
            answer3 = view.FindViewById<TextView>(Resource.Id.TRA3_TXT);
            answer4 = view.FindViewById<TextView>(Resource.Id.TRA4_TXT);


        }
    }
}