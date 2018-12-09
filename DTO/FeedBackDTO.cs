using System;
using TradeCompany.Database;

namespace DTO
{
	public class FeedBackDTO
	{
		public int id { get; set; }
		public int user_id { get; set; }
		public int good_id { get; set; }
		public string text { get; set; }
		public Nullable<System.DateTime> Date { get; set; }

		public virtual tblGood tblGood { get; set; }
		public virtual tblUser tblUser { get; set; }
	}
}
