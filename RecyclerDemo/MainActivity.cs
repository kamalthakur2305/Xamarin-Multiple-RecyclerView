using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Content;

namespace RecyclerDemo
{
	[Activity (Label = "RecyclerDemo", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		RecyclerView recyclerView1,recyclerView2,recyclerView3,recyclerView4;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);


			recyclerView1 = FindViewById<RecyclerView> (Resource.Id.recycler_view1);
			recyclerView2 = FindViewById<RecyclerView> (Resource.Id.recycler_view2);
			recyclerView3 = FindViewById<RecyclerView> (Resource.Id.recycler_view3);
			recyclerView4 = FindViewById<RecyclerView> (Resource.Id.recycler_view4);

			// improve performance if you know that changes in content
			// do not change the size of the RecyclerView
			recyclerView1.HasFixedSize = true;
			recyclerView2.HasFixedSize = true;
			recyclerView3.HasFixedSize = true;
			recyclerView4.HasFixedSize = true;


			recyclerView1.SetLayoutManager (new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false));
			int[] array1 = { Resource.Drawable.test1, Resource.Drawable.test2, Resource.Drawable.test3,
				Resource.Drawable.test4,Resource.Drawable.test5, Resource.Drawable.test6};
			MyAdapter1 adapter1 = new MyAdapter1 (array1);
			recyclerView1.SetAdapter (adapter1);

			recyclerView2.SetLayoutManager (new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false));
			int[] array2 = { Resource.Drawable.test6, Resource.Drawable.test5, Resource.Drawable.test4,
				Resource.Drawable.test3,Resource.Drawable.test2, Resource.Drawable.test1};
			MyAdapter2 adapter2 = new MyAdapter2 (array2);
			recyclerView2.SetAdapter (adapter2);

			recyclerView3.SetLayoutManager (new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false));
			int[] array3 = { Resource.Drawable.test1, Resource.Drawable.test3, Resource.Drawable.test5,
				Resource.Drawable.test2,Resource.Drawable.test4, Resource.Drawable.test6};
			MyAdapter3 adapter3 = new MyAdapter3 (array3);
			recyclerView3.SetAdapter (adapter3);

			recyclerView4.SetLayoutManager (new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false));
			int[] array4 = { Resource.Drawable.test2, Resource.Drawable.test4, Resource.Drawable.test6,
				Resource.Drawable.test1,Resource.Drawable.test3, Resource.Drawable.test5};
			MyAdapter4 adapter4 = new MyAdapter4 (array4);
			recyclerView4.SetAdapter (adapter4);
		}
	}
}
