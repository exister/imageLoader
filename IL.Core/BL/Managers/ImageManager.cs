using System;
using System.Collections.Generic;

namespace IL.Core.BL.Managers
{
	public static class ImageManager
	{
		static ImageManager ()
		{
		}

		public static IList<Image> GetImages ()
		{
			return new List<Image>(IL.Core.DAL.ImageManager.GetImages());
		}
	}
}

