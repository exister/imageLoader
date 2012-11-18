
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using IL.Core.BL;

namespace IL.MD.AL
{
	class ImagesListAdapter : BaseAdapter<Image>
	{
		Activity context;
		IList<Image> rows;

		public ImagesListAdapter (Activity context, IList<Image> images) : base()
		{
			this.context = context;
			rows = images;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View view = convertView;

			if (view == null) {
				view = context.LayoutInflater.Inflate(Resource.Layout.ImagesListCell, null);
			}

			Image image = this[position];

			view.FindViewById<ImageView> (Resource.Id.photo).SetImageResource(Resource.Drawable.placeholder);
			view.FindViewById<TextView> (Resource.Id.url).Text = image.url;

			return view;
		}

		public override int Count {
			get {
				return rows.Count;
			}
		}

		public override Image this[int position] {
			get {
				return rows[position];
			}
		}
	}
}

