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
using DrivingLTemplate.ViewHolder;
using DrivingLTemplate.Models;

namespace DrivingLTemplate.Adapter
{
    public class TestItemsRecAdapter : RecyclerView.Adapter
    {

        List<TestsItemsModel> TestModel;


        public TestItemsRecAdapter(List<TestsItemsModel> items)
        {
            TestModel = items;
        }



        public override int ItemCount => TestModel.Count();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            TestItemsViewHolder tivh = holder as TestItemsViewHolder;

            tivh.image.SetImageResource(TestModel.ElementAt(position).Image);
            tivh.answer1.Text = TestModel.ElementAt(position).Answer1;
            tivh.answer2.Text = TestModel.ElementAt(position).Answer2;
            tivh.answer3.Text = TestModel.ElementAt(position).Answer3;
            tivh.answer4.Text = TestModel.ElementAt(position).Answer4;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layoutResult = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.TestItemRecyclerView, parent, false);
            var holder = new TestItemsViewHolder(layoutResult);
            return holder;
        }
    }
}