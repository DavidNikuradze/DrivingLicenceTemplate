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
    public class ItemRecyclerAdapter : RecyclerView.Adapter
    {

        List<ItemModel> itemModels;


        public ItemRecyclerAdapter(List<ItemModel> items)
        {
            itemModels = items;
        }



        public override int ItemCount => itemModels.Count();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ItemCategoryViewHolder icvh = holder as ItemCategoryViewHolder;
            icvh.checkBox.Id = itemModels.ElementAt(position).CheckBox;
            icvh.image.SetImageResource(itemModels.ElementAt(position).Image);
            icvh.textview.Text = itemModels.ElementAt(position).Textview;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layoutResult = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ItemCatRecyclerWiew, parent, false);
            var holder = new ItemCategoryViewHolder(layoutResult);
            return holder;
        }
       
    }
}