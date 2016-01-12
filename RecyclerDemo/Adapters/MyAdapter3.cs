using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace RecyclerDemo
{
	public class MyAdapter3 : RecyclerView.Adapter
	{
		int[] items;

		public MyAdapter3 (int [] data)
		{
			items = data;
		}

		public override RecyclerView.ViewHolder OnCreateViewHolder (ViewGroup parent, int viewType)
		{	

			View v = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.inflator_layout3,parent,false);
			var vh = new MyViewHolder3(v);
			return vh;
		} 

		public override void OnBindViewHolder (RecyclerView.ViewHolder viewHolder, int position)
		{
			var item = items [position];
			var holder = viewHolder as MyViewHolder3;
			holder.imageView.SetBackgroundResource (items[position]);

		}

		public override int ItemCount {
			get {
				return items.Length;
			}
		}
	}


	public class MyViewHolder3 : RecyclerView.ViewHolder 
	{
		public ImageView imageView;

		public MyViewHolder3 (View v) : base (v)
		{
			imageView = v.FindViewById<ImageView> (Resource.Id.imageView1);
		}
	}
}

