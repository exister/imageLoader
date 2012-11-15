using System;
using SQLite;
using IL.Core.BL;

namespace IL.Core.DL
{
	public class ImageDatabase : SQLiteConnection
	{
		public ImageDatabase (string path) : base(path)
		{
			CreateTable<Image>();
		}
	}
}

