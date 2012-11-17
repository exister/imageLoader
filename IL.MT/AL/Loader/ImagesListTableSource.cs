using System;
using MonoTouch.UIKit;
using System.Collections.Generic;
using IL.Core.BL;

namespace IL.MT.AL
{
	public class ImagesListTableSource : UITableViewSource
	{
		protected IList<Image> _images = null;
		protected string _cellId = "defaultCell";
		protected UIImage placeholder { get; set; }

		public ImagesListTableSource (IList<Image> images) : base()
		{
			this._images = images;
			placeholder = UIImage.FromFile("Images/Shared/placeholder.jpg");
		}

		public IList<Image> Images {
			get {
				return this._images;
			}
			set {
				this._images = value;
			}
		}

		public override int RowsInSection (UITableView tableView, int section)
		{
			return this._images.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			UI.ImagesListCell cell = tableView.DequeueReusableCell (this._cellId) as UI.ImagesListCell;

			cell.setUrl(this._images[indexPath.Row].url);
			cell.setImage(placeholder);

			return cell;
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override string TitleForHeader (UITableView tableView, int section)
		{
			return "Картинки";
		}

		public override string TitleForFooter (UITableView tableView, int section)
		{
			return String.Format("Всего: {0}", this.RowsInSection(tableView, section).ToString());
		}
	}
}

