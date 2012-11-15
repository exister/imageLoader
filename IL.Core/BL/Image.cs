using System;
using IL.Core.BL.Contracts;
using SQLite;

namespace IL.Core.BL
{
	public class Image : IBusinessEntity
	{
		public Image ()
		{
		}

		#region IBusinessEntity implementation
		[PrimaryKey, AutoIncrement]
		public int id {
			get;
			set;
		}
		#endregion

		public string url {
			get;
			set;
		}
	}
}

