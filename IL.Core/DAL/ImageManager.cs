using System;
using System.IO;
using System.Collections.Generic;

namespace IL.Core.DAL
{
	public class ImageManager
	{
		protected DL.ImageDatabase _db = null;
		protected static string _dbLocation;
		protected static ImageManager _singleton;

		static ImageManager ()
		{
			_singleton = new ImageManager();
		}

		protected ImageManager ()
		{
			_dbLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ImageDB.sqlite");
			this._db = new DL.ImageDatabase(_dbLocation);
		}

		public static IEnumerable<BL.Image> GetImages() 
		{
			return _singleton._db.GetImages();
		}
	}
}

