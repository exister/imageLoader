
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

using IL.MD.AL;

namespace IL.MD.UI
{
	[Activity (Label = "ImagesListActivity", MainLauncher = true)]			
	public class ImagesListActivity : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			ListAdapter = new ImagesListAdapter(this, IL.Core.BL.Managers.ImageManager.GetImages());
		}
	}
}

