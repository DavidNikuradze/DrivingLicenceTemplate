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
using static Android.Support.V7.Widget.RecyclerView;

namespace DrivingLTemplate.ViewHolder
{
    public class ItemCategoryViewHolder : RecyclerView.ViewHolder
    {
        

        public ImageView image { get; set; }
        public CheckBox checkBox { get; set; }
        public TextView textview { get; set; }

        public ItemCategoryViewHolder(View itemView) : base(itemView)
        {
            image = itemView.FindViewById<ImageView>(Resource.Id.DrivingLicence_ACategory);
            checkBox = itemView.FindViewById<CheckBox>(Resource.Id.CheckBoxCheck);
            textview = itemView.FindViewById<TextView>(Resource.Id.TextItemCategory);

        }


      

    }
}