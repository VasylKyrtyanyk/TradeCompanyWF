using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
	public interface IFeedBackDAL
	{
		List<FeedBackDTO> GetFeedBacks();
		List<FeedBackDTO> GetFeedbackByGoodsId(int GoodId);
		List<FeedBackDTO> SortFeedBacks(List<FeedBackDTO> feeds, int type);
		List<FeedBackDTO> SearchFeedBackLogin(List<FeedBackDTO> feeds, string name);
	}
}
