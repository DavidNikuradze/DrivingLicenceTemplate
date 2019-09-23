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
using DrivingLTemplate.Models;
using DrivingLTemplate.ViewHolder;

namespace DrivingLTemplate.Adapter
{
    public class TicketsRecAdapter : RecyclerView.Adapter
    {
        List<TicketsCatModel> ticketsCatModels;

        public TicketsRecAdapter(List<TicketsCatModel> ticketsCats)
        {
            ticketsCatModels = ticketsCats;
        }
        public override int ItemCount => ticketsCatModels.Count();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            TicketsCatViewHolder tcvh = holder as TicketsCatViewHolder;
            tcvh.box.Id = ticketsCatModels.ElementAt(position).CheckBox;
            tcvh.textView.Text = ticketsCatModels.ElementAt(position).Text1;
            tcvh.textView2.Text = ticketsCatModels.ElementAt(position).Text2;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layoutResult = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.TicketsRecyclerView, parent, false);
            var holder = new TicketsCatViewHolder(layoutResult);
            return holder;
        }
    }
}