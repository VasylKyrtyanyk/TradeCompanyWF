using AutoMapper;
using DTO;
using TradeCompany.Database;

namespace DAL.Mapping_configuration
{
	public class FeedBackProfile : Profile
	{
		public FeedBackProfile()
		{
			CreateMap<tblFeedback, FeedBackDTO>().ReverseMap();
		}
	}
}
