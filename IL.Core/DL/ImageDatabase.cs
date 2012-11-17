using System;
using SQLite;
using IL.Core.BL;
using System.Collections.Generic;

namespace IL.Core.DL
{
	public class ImageDatabase : SQLiteConnection
	{
		public ImageDatabase (string path) : base(path)
		{
			CreateTable<Image>();
			DeleteAllImages();
			LoadFixtures();
		}

		public IEnumerable<Image> GetImages ()
		{
			return (from i in this.Table<Image>() select i);
		}

		public void DeleteAllImages ()
		{
			this.DeleteAll<Image>();
		}

		protected void LoadFixtures ()
		{
			string[] urls = {
				"http://24.media.tumblr.com/tumblr_mctcki5x1y1rxdhn1o1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_mctckcwXwb1rxdhn1o1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_mctcjumfbe1rxdhn1o1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_mctcjb4Enw1rxdhn1o1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_mctchbd1OD1rxdhn1o1_1280.jpg"
			};
			List<Image> images = new List<Image> ();

			foreach (string url in urls) {
				images.Add(new Image(url));
			}
			this.InsertAll(images, typeof(Image));
		}
	}
}

