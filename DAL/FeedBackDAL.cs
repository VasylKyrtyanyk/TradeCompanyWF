using AutoMapper;
using DAL.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;
using TradeCompany.Database;

namespace DAL
{
	public class FeedBackDAL : companyEntities,IFeedBackDAL
	{
		IMapper _mapper;
		public FeedBackDAL()
		{
			var config = new AutoMapper.MapperConfiguration(c => c.AddProfiles(typeof(FeedBackDAL)));
			_mapper = config.CreateMapper();
		}

		public List<FeedBackDTO> GetFeedBacks()
		{
			List<FeedBackDTO> FedBack = new List<FeedBackDTO>();

			using (var entities = new CategoryDAL())
			{
				FedBack = _mapper.Map<List<FeedBackDTO>>(entities.tblFeedbacks).ToList();
			}
			return FedBack;
		}



		public List<FeedBackDTO> GetFeedbackByGoodsId(int GoodId)
		{
			List<FeedBackDTO> FedBack = new List<FeedBackDTO>();
			using (var entities = new FeedBackDAL())
			{

				var feed = entities.tblFeedbacks.Where(s => s.good_id == GoodId).ToList();

				return _mapper.Map<List<FeedBackDTO>>(feed);
			}

		}




		public List<FeedBackDTO> SortFeedBacks(List<FeedBackDTO> feeds, int type)
		{


			switch (type)
			{
				case 1: return feeds.OrderBy(f => f.tblUser.first_name).ToList();
				case 2: return (feeds.OrderBy(f => f.Date).ToList());
				default:
					return feeds;
			}
		}
		public List<FeedBackDTO> SearchFeedBackLogin(List<FeedBackDTO> feeds, string name)
		{
			return feeds.Where(u => u.tblUser.first_name.Contains(name)).ToList();
		}
	}
}
