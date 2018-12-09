using System.Collections.Generic;
using TradeCompany.Database;

namespace DTO
{
	public class CategoryDTO
	{
		public int id { get; set; }
		public string name { get; set; }
		public virtual ICollection<tblGood> tblGoods { get; set; }
	}
}
