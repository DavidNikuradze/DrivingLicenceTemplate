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
    public class TicketsCatViewHolder : RecyclerView.ViewHolder
    {
        public TextView textView { get; set; }

        public TextView textView2 { get; set; }

        public CheckBox box { get; set; }

        public TicketsCatViewHolder(View view) : base(view)
        {

            textView = view.FindViewById<TextView>(Resource.Id.TicketsCategory_CardTXT);

            box = view.FindViewById<CheckBox>(Resource.Id.TicketsCard_CHeckB);

            textView2 = view.FindViewById<TextView>(Resource.Id.TicketsName_CardTXT);
        }

    }
}